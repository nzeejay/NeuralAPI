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
                                         new Int3(2,1,1),
                                         new Int3(1,1,1)});

            nn.runNetwork();
        }
    }
}
