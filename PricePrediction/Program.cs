using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using NeuralAPI;

namespace PricePrediction {
    struct day {
        public float high;
        public float close;
        public float low;
    }

    class Program {

        static List<TrainingItem> tempTrain = new List<TrainingItem>();

        static Random r = new Random();

        static void Main(string[] args) {
            var param = new(Int3 size, int type)[] { (new Int3(10,1,1), 0),
                                                     //(new Int3(1024,1,1), 0),
                                                     //(new Int3(512,1,1), 0),
                                                     //(new Int3(128,1,1), 0),
                                                     (new Int3(1,1,1), 0),};

            var nn = new NeuralNetwork(param);

            getData(1000);

            nn.trainingItems = tempTrain;

            long tick = 0;
            float learn = 0.01f;

            while (true) {

                Console.WriteLine($"{Math.Sqrt(nn.printError(-1))} - {tick}:{learn}");

                //for (int i = 0; i < 10; i++) {
                    nn.trainStep(-1, learn, 0.0f);
                    learn *= 0.99f;

                    //float[] w = nn.layers[3].weights;
                    //float[] v = nn.layers[3].data;

                    if (learn < 0.000005f)
                        learn = 0.000005f;
                //}
            }
        }

        static void getData(int itemCount) {
            var dayMarketValues = new List<day[]>();

            string[] days = File.ReadAllText("GoldPrice.csv").Split('a');
            for (int i = 1; i < days.Length-1; i++) {
                var dayStr = days[i].Split('\n');

                day[] thisDay = new day[dayStr.Length];
                for (int j = 0; j < dayStr.Length-1; j++) {
                    thisDay[j].close = float.Parse(dayStr[j].Split(',')[1]);
                    thisDay[j].high = float.Parse(dayStr[j].Split(',')[2]);
                    thisDay[j].low = float.Parse(dayStr[j].Split(',')[3]);
                }

                dayMarketValues.Add(thisDay);
            }

            for (int i = 0; i < itemCount; i++) {
                float[] input = new float[10];
                float[] output = new float[1];

                int day = r.Next(dayMarketValues.Count);
                int min = r.Next(dayMarketValues[day].Length - (input.Length + 1));

                float ini = dayMarketValues[day][min].close;

                for (int j = 0; j < input.Length; j++) {
                    input[j]   = (dayMarketValues[day][min + j].close - ini);
                    //input[j+1] = (dayMarketValues[day][min + j/3].high - ini);
                    //input[j+2] = (dayMarketValues[day][min + j/3].low - ini);
                }

                if (input[input.Length-1] > input[input.Length - 2] + 0.01f)
                    output[0] = 1;

                tempTrain.Add(new TrainingItem(input, output));
            }
        }

        static float sigmoid(float f) {
            return (float)(1f / (1 + Math.Exp(-f)));
        }
    }
}
