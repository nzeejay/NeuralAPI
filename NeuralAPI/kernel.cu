//Kernel code:
extern "C"
{
	__device__ int getIndex(int x, int y, int z, int X, int Y) {
		return (x + (y * Y)) + (z * X * Y);
	}

	__device__ float sigmoid(float f) {
		return 1 / (1 + __expf(-f));
	}

	__device__ float sigmoidDer(float f) {
		return f * (1 - f);
	}

	__device__ float relu(float f) {

		return fmaxf(0, f);
	}

	__device__ float reluDer(float f) {
		float ret = 1;

		if (f <= 0)
			ret = 0;

		return ret;
	}

	//activations
	__global__ void Activate(float* data, float* bias, int activationID) {
		int ID = getIndex(blockIdx.x, blockIdx.y, blockIdx.z, gridDim.x, gridDim.y);

		switch (activationID)
		{
		case(0):
			data[ID] = sigmoid(data[ID] + bias[ID]);
			break;

		case(1):
			data[ID] = relu(data[ID] + bias[ID]);
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
		case(1):
			return reluDer(f);
			break;
		}
		return 1.f;
	}

	__global__ float SoftmaxSigma(float *data, float ret) {
		int thisLayerID = getIndex(blockIdx.x, blockIdx.y, blockIdx.z, gridDim.x, gridDim.y);
		
		atomicAdd(&ret, data[thisLayerID]);
	}

	__global__ void SoftmaxFinal(float *data, float val) {
		int thisLayerID = getIndex(blockIdx.x, blockIdx.y, blockIdx.z, gridDim.x, gridDim.y);
		
		data[thisLayerID] /= val; 
	}

	// Device code
	__global__ void Forward(float* data, 
							float* weights, 
						    float* prev) {

		int thisLayerID = getIndex(blockIdx.x, blockIdx.y, blockIdx.z, gridDim.x, gridDim.y);

		int prevLayerID = getIndex(threadIdx.x, threadIdx.y, threadIdx.z, blockDim.x, blockDim.y);

		int weightID = thisLayerID * (blockDim.x * blockDim.y * blockDim.z) + prevLayerID;

		float val = prev[prevLayerID] * weights[weightID];
	
		atomicAdd(&data[thisLayerID], val);
	}

	__global__ void Backprop(float* data, 
							 float* weights, 
							 float* bias, 
							 float* prev, 
							 float* error, 
							 float* prevError, 
							 float* vel, 
							 float step, 
							 float mu, 
							 int type) {
		int blockSize = (blockDim.x * blockDim.y * blockDim.z);

		int thisLayerID = getIndex(blockIdx.x, blockIdx.y, blockIdx.z, gridDim.x, gridDim.y);

		int prevLayerID = getIndex(threadIdx.x, threadIdx.y, threadIdx.z, blockDim.x, blockDim.y);

		int weightID = thisLayerID * blockSize + prevLayerID;

		float gradient = (activateDer(prev[prevLayerID], type) * 2 * error[thisLayerID]);			
		
		bias[thisLayerID] += -step * gradient;

		float velocity = vel[weightID] * mu - step * prev[prevLayerID] * gradient;
		vel[weightID] = velocity;// mu * vel[weightID] + (1 - mu) * powf(gradient, 2);
		weights[weightID] += velocity;// prev[prevLayerID] * gradient / (sqrtf(vel[weightID]) + 0.000001f);

		float prevActGD = weights[weightID] * gradient;
//printf("grad: %f act: %f err: %f prev: %f prevActGD: %f\n", gradient, activateDer(prev[prevLayerID], type), error[thisLayerID], prev[prevLayerID], prevActGD);
		atomicAdd(&prevError[prevLayerID], prevActGD);
	}


	__global__ void Clear(float* data, float* error) {
		int ID = getIndex(blockIdx.x, blockIdx.y, blockIdx.z, gridDim.x, gridDim.y);
		
		data[ID] = 0.f;
		error[ID] = 0.f;
	}
}