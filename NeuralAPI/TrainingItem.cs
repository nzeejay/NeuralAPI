using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralAPI
{
    public class TrainingItem
    {
        public float[] input;
        public float[] output;

        public TrainingItem(float[] input, float[] output)
        {
            this.input = input;
            this.output = output;
        }
    }
}
