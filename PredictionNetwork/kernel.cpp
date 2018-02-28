//Kernel code:
extern "C"
{
	__device__ int getIndex(int x, int y, int z, int X, int Y) {
		return (x + (y * Y)) + (z * X * Y);
	}

	//activations
	__global__ void Activate(float* data, float* bias, int activationID) {
		int ID = getIndex(blockIdx.x, blockIdx.y, blockIdx.z, gridDim.x, gridDim.y);

		switch (activationID)
		{
		case(0):
			data[ID] = sigmoid(data[ID] + bias[ID]);
			break;

		default:
			break;
		}
	}

	__device__ float activateDer(float f, int activationID) {
		switch (activationID)
		{
		case(0):
			return sigmoidDer(f);
			break;
		}

		return 1.f;
	}

	__device__ float sigmoid(float f) {
		return 1 / (1 + __expf(-f));
	}

	__device__ float sigmoidDer(float f) {
		return f * (1 - f);
	}

	// Device code
	__global__ void Forward(float* data, float* weights, float* prev) {

		int thisLayerID = getIndex(blockIdx.x, blockIdx.y, blockIdx.z, gridDim.x, gridDim.y);

		int prevLayerID = getIndex(threadIdx.x, threadIdx.y, threadIdx.z, blockDim.x, blockDim.y);

		int weightID = thisLayerID * (blockDim.x * blockDim.y * blockDim.z) + prevLayerID;

		float val = prev[prevLayerID] * weights[weightID];
	
		atomicAdd(&data[thisLayerID], val);
	}

	__global__ void Backprop(float* data, float* weights, float* bias, float* prev, float* error, float* prevError, float* vel, float step, float mu) {
		int blockSize = (blockDim.x * blockDim.y * blockDim.z);

		int thisLayerID = getIndex(blockIdx.x, blockIdx.y, blockIdx.z, gridDim.x, gridDim.y);

		int prevLayerID = getIndex(threadIdx.x, threadIdx.y, threadIdx.z, blockDim.x, blockDim.y);

		int weightID = thisLayerID * blockSize + prevLayerID;

		float err = 2 * (data[thisLayerID] - error[thisLayerID]);

		float prevActGD = weights[weightID] * activateDer(prev[prevLayerID], 0) * err;
		atomicAdd(&prevError[prevLayerID], prevActGD);

		float gradient = step * activateDer(prev[prevLayerID], 0) * err;

		float velocity = vel[weightID] * mu - (prev[prevLayerID] * gradient);
		vel[weightID] = velocity;
		weights[weightID] += velocity;
		bias[thisLayerID] += gradient;
	}

	__global__ void Clear(float* data, float* error) {
		int ID = getIndex(blockIdx.x, blockIdx.y, blockIdx.z, gridDim.x, gridDim.y);
		
		data[ID] = 0.f;
		error[ID] = 0.f;
	}
}