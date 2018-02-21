using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ManagedCuda;

namespace PredictionNetwork
{
    public class NeuralNetwork
    {
        public Layer[] layers;

        CudaContext ctx;

        public void buildNetwork(Int3[] size)
        {
            ctx = new CudaContext();

            layers = new Layer[size.Length];

            layers[0] = new Layer(size[0]);

            Random r = new Random();

            for (int i = 0; i < layers[0].data.Size; i++)
                layers[0].data[i] = (float)r.NextDouble(); 

            for (int i = 1; i < layers.Length; i++)
            {
                layers[i] = new Layer(size[i], layers[i - 1], ctx, kernelType.fullyConnected);
            }
        }

        public void runNetwork()
        {
            for (int i = 1; i < layers.Length; i++)
            {
                layers[i].kernel.Run(layers[i].data.DevicePointer, 
                                     layers[i].weights.DevicePointer, 
                                     layers[i - 1].data.DevicePointer);
            }
        }

        public void clearNetwork()
        {
            for (int i = 0; i < layers.Length; i++)
            {
                for (int j = 0; j < layers[i].data.Size; j++)
                {
                    layers[i].data[j] = 0;
                }
            }
        }

        public void trainStep()
        {
            float error = 0;
            float oldError = -1;

            (float x, float y, float a)[] test = { (0, 0, 0), (1, 0, 1), (0, 1, 1), (1, 1, 0) };

            Random r = new Random();
            int layer = r.Next(1, 3);
            int weight = r.Next(layers[layer].weights.Size);
            for (int j = 0; j < 11; j++)
            {
                for (int i = 0; i < test.Length; i++)
                {
                    clearNetwork();

                    layers[0].data[0] = test[i].x;
                    layers[0].data[1] = test[i].y;

                    runNetwork();

                    error +=  (float)Math.Pow(layers[2].data[0] - test[i].a, 2);
                }

                error /= test.Length;

                if (oldError != -1)
                {


                    layers[layer].weights[weight] += (oldError - error) * 0.1f;
                }

                oldError = error;
            }
        }
    }
}
