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
        public CudaDeviceVariable<float> bias;
        public CudaDeviceVariable<float> weights; //weights to the forward layer 

        //backprop
        public CudaDeviceVariable<float> error;
        public CudaDeviceVariable<float> vel;

        public Int3 size;

        public int type = -1;

        public CudaKernel forward;
        public CudaKernel activate;
        public CudaKernel back;
        public CudaKernel clear;

        Random r = new Random();

        public Layer(Int3 size, CudaContext ctx)
        {
            this.size = size;

            data = new float[size.Mul];
            bias = new float[size.Mul];
            error = new float[size.Mul];

            clear = ctx.LoadKernel("kernel.ptx", "Clear");
            clear.GridDimensions = new dim3(size.x, size.y, size.z);
        }

        public Layer(Int3 size, Layer prev, CudaContext ctx, int type)
        {
            this.type = type;
            this.size = size;

            data = new float[size.Mul];
            bias = new float[size.Mul];
            error = new float[size.Mul];

            generateWeights(size, prev.size, kernelType.fullyConnected);

            forward = ctx.LoadKernel("kernel.ptx", "Forward");
            forward.GridDimensions = new dim3(size.x, size.y, size.z);
            forward.BlockDimensions = new dim3(prev.size.x, prev.size.y, prev.size.z);

            back = ctx.LoadKernel("kernel.ptx", "Backprop");
            back.GridDimensions = new dim3(size.x, size.y, size.z);
            back.BlockDimensions = new dim3(prev.size.x, prev.size.y, prev.size.z);

            clear = ctx.LoadKernel("kernel.ptx", "Clear");
            clear.GridDimensions = new dim3(size.x, size.y, size.z);

            activate = ctx.LoadKernel("kernel.ptx", "Activate");
            activate.GridDimensions = new dim3(size.x, size.y, size.z);
        }

        private void generateWeights(Int3 size, Int3 prevSize, kernelType kType)
        {
            switch (kType)
            {
                case (kernelType.fullyConnected):
                    var wei = new float[size.Mul * prevSize.Mul];
                    vel = new float[size.Mul * prevSize.Mul];

                    for (int i = 0; i < wei.Length; i++)
                        wei[i] = (float)(r.NextDouble() - 0.5) * 2;

                    weights = wei;

                    return;
            }
            
            throw new Exception("Failed to generate weights");
        }
    }
}