using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using ManagedCuda;

namespace NeuralAPI
{
    public class FileLayer
    {
        public float[] data;
        public float[] weights;
        public float[] bias;
               
        public Int3 size;
        public Int3 prevSize;
        public int type;
               
        public string forward;
        public string activate;
        public string back;
        public string clear;

        public FileLayer(Layer layer) {
            prevSize = new Int3((int)layer.forward.BlockDimensions.x,
                                (int)layer.forward.BlockDimensions.y,
                                (int)layer.forward.BlockDimensions.z);

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

        public FileNetwork(string file) {
            var reader = new System.Xml.Serialization.XmlSerializer(typeof(FileNetwork));
            StreamReader SR = new StreamReader(file);
            var fileN = (FileNetwork)reader.Deserialize(SR);
            layers = fileN.layers;
            SR.Close();
        }

        public FileNetwork(NeuralNetwork nn) {
            layers = new FileLayer[nn.layers.Length];

            for (int i = 0; i < layers.Length; i++) {
                layers[i] = new FileLayer(nn.layers[i]);
            }
        }

        public NeuralNetwork getNeuralNetwork(ref CudaContext ctx) {
            var nn = new NeuralNetwork();

            nn.layers = new Layer[layers.Length];

            for (int i = 0; i < nn.layers.Length; i++) {
                nn.layers[i] = new Layer(layers[i], ref ctx);
            }

            return nn;
        }

        public void Save(string file) {
            var writer = new System.Xml.Serialization.XmlSerializer(typeof(FileNetwork));
            var wfile = new StreamWriter(file);
            writer.Serialize(wfile, this);
            wfile.Close();
        }
    }
}
