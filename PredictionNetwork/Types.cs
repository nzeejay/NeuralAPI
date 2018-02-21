using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictionNetwork
{
    public class Int2
    {

    }

    public class Int3
    {
        public int x, y, z;

        public int Mul
        {
            get { return x * y * z; }
        }

        public Int3(int x)
        {
            this.x = x;
            y = 1;
            z = 1;
        }

        public Int3(int x, int y)
        {
            this.x = x;
            this.y = y;
            z = 1;
        }

        public Int3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
