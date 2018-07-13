using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ManagedCuda;
using NeuralAPI;

namespace multi {
    class Program {
        static Random r = new Random();

        static void Main(string[] args) {
            var param = new(Int3 size, int type)[] { (new Int3(20,1,1), 0),
                                                     (new Int3(256,1,1), 0),
                                                     (new Int3(82,1,1), 0),};

            var nn = new NeuralNetwork(param);

            nn.trainingItems = getData(2000);

            long tick = 0;
            float learn = 0.01f;

            while (true) {
                Console.WriteLine($"{Math.Sqrt(nn.printError(-1))} - {tick}:{learn}");

                for (int i = 0; i < 10; i++) {
                    nn.trainStep(256, learn, 0.5f);

                    learn *= 0.995f;

                    //var outp = testNet(nn, 4, 4);

                    //int big = getBiggest(outp);

                    //float[] w = nn.layers[3].weights;
                    //float[] v = nn.layers[3].data;

                    if (learn < 0.000005f)
                        learn = 0.000005f;
                }
            }
        }

        static int getBiggest(float[] fa) {
            int current = 0;
            float biggest = 0;
            for (int i = 0; i < fa.Length; i++) {
                if (fa[i] > biggest) {
                    biggest = fa[i];
                    current = i;
                }
            }

            return current;
        }

        static float[] testNet(NeuralNetwork nn, int x, int y) {
            nn.clearNetwork();

            nn.layers[0].data = new float[20];
            nn.layers[0].data[x] = 1;
            nn.layers[0].data[10 + y] = 1;

            nn.runNetwork();

            float[] outp = nn.layers[nn.layers.Length - 1].data;

            nn.clearNetwork();

            return outp;
        }

        static List<TrainingItem> getData(int count) {
            var ret = new List<TrainingItem>();

            for (int i = 0; i < count; i++) {
                int num1 = r.Next(10);
                int num2 = r.Next(10);

                var input = new float[20];
                var output = new float[82];

                input[num1] = 1;
                input[num2 + 10] = 1;

                output[num1 * num2] = 1;

                if (num1 == 5 && num2 == 5 ||
                    num1 == 4 && num2 == 4 ||
                    num1 == 1 && num2 == 8)
                    continue;

                ret.Add(new TrainingItem(input, output));
            }

            return ret;
        }
    }
}
