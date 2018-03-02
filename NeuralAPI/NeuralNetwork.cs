using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ManagedCuda;

namespace NeuralAPI
{
    public partial class NeuralNetwork
    {
        public Layer[] layers;

        public List<TrainingItem> trainingItems = new List<TrainingItem>();

        public CudaContext ctx;

        Random r = new Random();

        public void buildNetwork(dynamic[] info)
        {
            ctx = new CudaContext();

            layers = new Layer[info.Length];

            layers[0] = new Layer(info[0].size, ctx);

            for (int i = 1; i < layers.Length; i++)
            {
                layers[i] = new Layer(info[i].size, layers[i - 1], ctx, info[i].type);
            }

        }

        public void runNetwork()
        {
            for (int i = 1; i < layers.Length; i++)
            {
                layers[i].forward.Run(layers[i].data.DevicePointer,
                                      layers[i].weights.DevicePointer, 
                                      layers[i - 1].data.DevicePointer);

                layers[i].activate.Run(layers[i].data.DevicePointer, 
                                       layers[i].bias.DevicePointer, 
                                       layers[i].type);
            }
        }

        public void backpropNetwork(float step, float mu)
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
                                   mu,
                                   layers[i].type);
            }
        }

        public void clearNetwork()
        {
            foreach (var layer in layers)
            {

                layer.clear.Run(layer.data.DevicePointer, layer.error.DevicePointer);
            }
        }

        public void trainStep(int batchSize, float learningRate, float mu)
        {
            bool isScholastic = false;

            if (batchSize == -1)
                isScholastic = true;

            if (isScholastic)
                batchSize = trainingItems.Count();

            for (int i = 0; i < batchSize; i++)
            {
                int index = i;

                if (!isScholastic)
                    r.Next(trainingItems.Count);

                clearNetwork();
                layers[0].data.CopyToDevice(trainingItems[index].input);
                runNetwork();

                var err = getError(layers[layers.Length - 1].data, trainingItems[index].output);

                layers[layers.Length - 1].error.CopyToDevice(err);

                backpropNetwork(learningRate, mu);
            }

            clearNetwork();
        }

        private float[] getError(float[] data, float[] expected)
        {
            float[] ret = new float[data.Length];
            for (int i = 0; i < ret.Length; i++)
            {
                //ret[i] = data[i] - expected[i];
                ret[i] = expected[i] - data[i];
            }

            return ret;
        }

        public float printError(int batchSize)
        {
            bool isScholastic = false;

            if (batchSize == -1)
                isScholastic = true;

            if (isScholastic)
                batchSize = trainingItems.Count();

            float err = 0;

            for (int i = 0; i < batchSize; i++)
            {
                int index = i;

                if (!isScholastic)
                    r.Next(trainingItems.Count);

                clearNetwork();
                layers[0].data.CopyToDevice(trainingItems[index].input);
                runNetwork();

                float[] output = layers[layers.Length - 1].data;

                float tempErr = 0;

                for (int j = 0; j < output.Length; j++)
                {
                    tempErr += (float)Math.Pow(trainingItems[index].output[j] - output[j], 2);
                }

                err += tempErr / output.Length;
            }

            clearNetwork();
            return err / batchSize;
        }

        public void SaveNetwork()
        {

        }

        public void LoadNetwork()
        {

        }
    }
}
