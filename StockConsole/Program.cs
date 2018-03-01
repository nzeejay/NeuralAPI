using System;
using System.IO;    
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PredictionNetwork;


namespace StockConsole
{
    class Program
    {

        static NeuralNetwork nn;

        static void Main(string[] args)
        {
            nn = new NeuralNetwork();

            nn.buildNetwork(new (Int3 size, int type)[] {(new Int3(784,1,1), 0 ),
                                                         //(new Int3(1024,1,1), 0 ),
                                                         (new Int3(512,1,1), 0 ),
                                                         (new Int3(256,1,1), 0 ),
                                                         (new Int3(10,1,1), 0 )
                                                         });

            getData();

            long tick = 0;
            float learn = 0.1f;

            while (true)
            {
                Console.WriteLine($"{nn.printError(128)} - {tick}:{learn}");

                for (int i = 0; i < 5; i++)
                {
                    nn.trainStep(1024, learn, 0.8f);
                    learn *= 0.999f;
                }
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
        
        /*

        public static void getData()
        {
            string[] flowers = File.ReadAllText("iris.data").Split('\n');
            for (int i = 0; i < flowers.Length-2; i++)
            {
                string[] flower = flowers[i].Split(',');
                var input = new float[] {float.Parse(flower[0]),
                                         float.Parse(flower[1]),
                                         float.Parse(flower[2]),
                                         float.Parse(flower[3]) };



                float[] output;

                switch (flower[4])
                {
                    case ("Iris-setosa"):
                        output = new float[] { 1, 0, 0 };
                        break;
                    case ("Iris-versicolor"):
                        output = new float[] { 0, 1, 0 };
                        break;
                    case ("Iris-virginica"):
                        output = new float[] { 0, 0, 1 };
                        break;

                    default:
                        output = new float[] { 0, 0, 1 };
                        break;
                }

                nn.trainingItems.Add(new TrainingItem(input, output));
            }
        }
        */
        
        public static void getData()
        {
            string[] img = File.ReadAllText("mnist_train.csv").Split('\n');
            for (int i = 0; i < 6000; i++)
            {
                string[] str = img[i].Split(',');

                var input = new List<float>();
                var output = new float[10];

                for (int j = 0; j < 785; j++)
                {
                    string thiStr = str[j];
                    float f = float.Parse(thiStr);
                    if (j == 0)
                    {
                        output[(int)f] = 1;                        
                    }
                    else
                        input.Add(f/255);
                        
                }
                nn.trainingItems.Add(new TrainingItem(input.ToArray(), output.ToArray()));
            }

            img = null;
        }
        
    }
}