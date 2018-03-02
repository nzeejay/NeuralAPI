using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralAPI
{
    class FileLayer
    {
        float[] data;
        float[] weights;
        float[] bias;

        Int3 size;
        Int3 prevSize;
        int type;

        string forward;
        string activate;
        string back;
        string clear;

        public FileLayer(Layer layer) {
            data = layer.data;
            weights = layer.weights;
            bias = layer.bias;

            size = layer.size;

            type = layer.type;

            forward = layer.forward.KernelName;
            activate = layer.activate.KernelName;
            back = layer.back.KernelName;
            clear = layer.clear.KernelName;
        }
    }

    [Serializable]
    public class FileNetwork
    {
        FileLayer[] layers;
        public FileNetwork(NeuralNetwork nn) {

        }
    }
}
