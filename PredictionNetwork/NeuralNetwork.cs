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

        public CudaContext ctx;

        public void buildNetwork(Int3[] size)
        {
            ctx = new CudaContext();

            layers = new Layer[size.Length];

            layers[0] = new Layer(size[0], ctx);

            for (int i = 1; i < layers.Length; i++)
            {
                layers[i] = new Layer(size[i], layers[i - 1], ctx, kernelType.fullyConnected);
            }
        }

        public void runNetwork()
        {
            for (int i = 1; i < layers.Length; i++)
            {
                layers[i].forward.Run(layers[i].data.DevicePointer,
                                      layers[i].weights.DevicePointer, 
                                      layers[i - 1].data.DevicePointer);

                layers[i].activate.Run(layers[i].data.DevicePointer, layers[i].bias.DevicePointer);
            }
        }

        public void backpropNetwork(float step)
        {
            for (int i = layers.Length - 1; i > 0; i--)
            {
                layers[i].back.Run(layers[i].data.DevicePointer,
                                   layers[i].weights.DevicePointer,
                                   layers[i].bias.DevicePointer,
                                   layers[i - 1].data.DevicePointer,
                                   layers[i].error.DevicePointer,
                                   layers[i - 1].error.DevicePointer,
                                   layers[i].vel.DevicePointer,
                                   step,
                                   0.01f);
            }
        }

        public void clearNetwork()
        {
            foreach (var layer in layers)
            {

                layer.clear.Run(layer.data.DevicePointer, layer.error.DevicePointer);
            }
        }

        public void trainStep()
        {
            (float x, float y, float a)[] test = { (0, 0, 0), (1, 0, 1), (0, 1, 1), (1, 1, 0)};

            float error = 0;
            float trueError = 0;

            for (int i = 0; i < test.Length; i++)
            {
                clearNetwork();
                layers[0].data[0] = test[i].x;
                layers[0].data[1] = test[i].y;
                runNetwork();
                float err = (layers[layers.Length - 1].data[0] - test[i].a);

                layers[layers.Length - 1].error[0] = err;
                backpropNetwork(0.1f);

                error += err;
                trueError += err * err;
            }

            //error /= test.Length;
            //trueError /= test.Length;
            //
            //layers[layers.Length - 1].error[0] = trueError;
            //
            //backpropNetwork(0.1f);


            //error = 0;
            //
            //for (int i = 0; i < test.Length; i++)
            //{ 
            //    clearNetwork();
            //    layers[0].data[0] = test[i].x;
            //    layers[0].data[1] = test[i].y;
            //    runNetwork();
            //    error += (float)Math.Pow(layers[2].data[0] - test[i].a, 2);
            //}
            //
            //error /= 4;
            //
            //clearNetwork();
        }
    }
}
