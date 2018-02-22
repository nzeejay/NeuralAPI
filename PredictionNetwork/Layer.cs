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
        public CudaDeviceVariable<float> bpData;
        public CudaDeviceVariable<float> weights; //weights to the forward layer 

        //backprop
        public CudaDeviceVariable<float> error;

        public Int3 size;

        public CudaKernel forward;
        public CudaKernel activate;
        public CudaKernel back;
        public CudaKernel clear;

        public Layer(Int3 size, CudaContext ctx)
        {
            this.size = size;

            data = new float[size.Mul];
            bpData = new float[size.Mul];
            error = new float[size.Mul];

            clear = ctx.LoadKernel("kernel.ptx", "Clear");
            clear.GridDimensions = new dim3(size.x, size.y, size.z);
        }

        public Layer(Int3 size, Layer prev, CudaContext ctx, kernelType kType)
        {
            this.size = size;

            data = new float[size.Mul];
            bpData = new float[size.Mul];
            error = new float[size.Mul];

            generateWeights(size, prev.size, kType);

            forward = ctx.LoadKernel("kernel.ptx", "Forward");
            forward.GridDimensions = new dim3(size.x, size.y, size.z);
            forward.BlockDimensions = new dim3(prev.size.x, prev.size.y, prev.size.z);

            back = ctx.LoadKernel("kernel.ptx", "Backprop");
            back.GridDimensions = new dim3(size.x, size.y, size.z);
            back.BlockDimensions = new dim3(prev.size.x, prev.size.y, prev.size.z);

            clear = ctx.LoadKernel("kernel.ptx", "Clear");
            clear.GridDimensions = new dim3(size.x, size.y, size.z);

            activate = ctx.LoadKernel("kernel.ptx", "Sigmoid");
            activate.GridDimensions = new dim3(size.x, size.y, size.z);
        }

        private void generateWeights(Int3 size, Int3 prevSize, kernelType kType)
        {
            switch (kType)
            {
                case (kernelType.fullyConnected):
                    var wei = new float[size.Mul * prevSize.Mul];

                    Random r = new Random();

                    for (int i = 0; i < wei.Length; i++)
                        wei[i] = (float)(r.NextDouble()-0.5) * 5;

                    weights = wei;

                    return;
            }
            
            throw new Exception("Failed to generate weights");
        }
    }
}