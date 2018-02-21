using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ManagedCuda;
using ManagedCuda.VectorTypes;

namespace PredictionNetwork
{
    public enum kernelType
    {
        fullyConnected = 1,
    }

    public class Layer
    {
        public CudaDeviceVariable<float> data;
        public CudaDeviceVariable<float> weights; //weights to the forward layer 

        //backprop
        public CudaDeviceVariable<float> error;

        public Int3 size;

        public CudaKernel kernel;

        public Layer(Int3 size)
        {
            this.size = size;

            data = new float[size.Mul];
        }

        public Layer(Int3 size, Layer prev, CudaContext ctx, kernelType kType)
        {
            this.size = size;

            data = new float[size.Mul];

            generateWeights(size, prev.size, kType);

            kernel = ctx.LoadKernel("kernel.ptx", "Forward");
            kernel.GridDimensions = new dim3(size.x, size.y, size.z);
            kernel.BlockDimensions = new dim3(prev.size.x, prev.size.y, prev.size.z);
        }

        private void generateWeights(Int3 size, Int3 prevSize, kernelType kType)
        {
            switch (kType)
            {
                case (kernelType.fullyConnected):
                    weights = new float[size.Mul * prevSize.Mul];

                    Random r = new Random();

                    for (int i = 0; i < weights.Size; i++)
                        weights[i] = (float)r.NextDouble();

                    return;
            }
            
            throw new Exception("Failed to generate weights");
        }
    }
}