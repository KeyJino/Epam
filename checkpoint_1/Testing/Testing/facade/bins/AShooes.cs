using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin
{
    public abstract class AShooes
    {
        private int size;
        private int price;
        private int materialId;

        public AShooes(int size, int price, int materialId)
        {
            this.price = price;
            this.size = size;
            this.materialId = materialId;
        }

        public int getSize()
        {
            return size;
        }

        public int getPrice()
        {
            return price;
        }

        public int getMaterialID()
        {
            return materialId;
        }


    }
}
