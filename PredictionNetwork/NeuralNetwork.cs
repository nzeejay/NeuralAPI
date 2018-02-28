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

        public List<TrainingItem> trainingItems = new List<TrainingItem>();

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

        public void trainStep(int batchSize, float learningRate)
        {
            Random r = new Random();

            for (int i = 0; i < batchSize; i++)
            {
                int index = r.Next(trainingItems.Count);

                clearNetwork();
                layers[0].data.CopyToDevice(trainingItems[index].input);
                runNetwork();
                layers[layers.Length - 1].error.CopyToDevice(trainingItems[index].input);
                backpropNetwork(learningRate);
            }
        }

        public float getError()
        {

        }
    }
}
