//Kernel code:
extern "C"
{
	__device__ int getIndex(int x, int y, int z, int X, int Y) {
		return (x + (y * Y)) + (z * X * Y);
	}

	// Device code
	__global__ void Forward(float* data, float* weights, float* prev) {

		__shared__ float thisNode;

		int thisLayerID = getIndex(blockIdx.x, blockIdx.y, blockIdx.z, gridDim.x, gridDim.y);

		int prevLayerID = getIndex(threadIdx.x, threadIdx.y, threadIdx.z, blockDim.x, blockDim.y);

		int weightID = thisLayerID * (blockDim.x * blockDim.y * blockDim.z) + prevLayerID;

		atomicAdd(&thisNode, prev[prevLayerID] * weights[weightID]);

		__syncthreads();

		//activation function
		if (threadIdx.x + threadIdx.y + threadIdx.z == 0) {
			if (thisNode > 1)
				thisNode = 1.f;
			else if (thisNode < 0)
				thisNode = 0.f;

			data[thisLayerID] = thisNode;
		}
	}
}