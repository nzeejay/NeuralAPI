using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PredictionNetwork;


namespace StockConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var nn = new NeuralNetwork();
            nn.buildNetwork(new Int3[] { new Int3(2,1,1),
                                         new Int3(4,1,1),
                                         new Int3(1,1,1)});

            for (int i = 0; i < 100; i++)
            {
                nn.trainStep();
            }

            nn.layers[0].data[0] = 1f;

            nn.runNetwork();

            float output = nn.layers[2].data[0];

            nn.clearNetwork();

            float output1 = nn.layers[2].data[0];

            nn.layers[0].data[0] = 0f;
            nn.layers[0].data[1] = 0f;

            nn.runNetwork();

            float output2 = nn.layers[2].data[0];

            float[] weights = nn.layers[1].weights;
            float[] weights1 = nn.layers[2].weights;
        }
    }
}
