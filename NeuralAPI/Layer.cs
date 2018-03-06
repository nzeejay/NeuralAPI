using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ManagedCuda;
using ManagedCuda.VectorTypes;

namespace NeuralAPI
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

        CudaContext ctx;

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

        public Layer(Int3 size, Layer prev, ref CudaContext ctx, int type)
        {
            this.ctx = ctx;

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

        public Layer(FileLayer fl, ref CudaContext ctx) {
            this.ctx = ctx;

            type = fl.type;
            size = fl.size;

            data = new float[fl.size.Mul];
            bias = new float[fl.size.Mul];
            error = new float[fl.size.Mul];

            forward = ctx.LoadKernel("kernel.ptx", "Forward");
            forward.GridDimensions = new dim3(size.x, size.y, size.z);
            forward.BlockDimensions = new dim3(fl.prevSize.x, fl.prevSize.y, fl.prevSize.z);

            back = ctx.LoadKernel("kernel.ptx", "Backprop");
            back.GridDimensions = new dim3(size.x, size.y, size.z);
            back.BlockDimensions = new dim3(fl.prevSize.x, fl.prevSize.y, fl.prevSize.z);

            clear = ctx.LoadKernel("kernel.ptx", "Clear");
            clear.GridDimensions = new dim3(size.x, size.y, size.z);

            activate = ctx.LoadKernel("kernel.ptx", "Activate");
            activate.GridDimensions = new dim3(size.x, size.y, size.z);
        }

        private void generateKernels(string forwardName, string backName, string clrName, string activeName, dim3 kernelSize) {
            forward = ctx.LoadKernel("kernel.ptx", forwardName);
            forward.GridDimensions = new dim3(size.x, size.y, size.z);
            forward.BlockDimensions = kernelSize;

            back = ctx.LoadKernel("kernel.ptx", backName);
            back.GridDimensions = new dim3(size.x, size.y, size.z);
            back.BlockDimensions = kernelSize;

            clear = ctx.LoadKernel("kernel.ptx", activeName);
            clear.GridDimensions = new dim3(size.x, size.y, size.z);

            activate = ctx.LoadKernel("kernel.ptx", activeName);
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