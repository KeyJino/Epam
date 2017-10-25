using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Bin;

namespace Service
{
    class Service
    {
        public List<Shooes> Sorting(List<Shooes> list)
        {
           list.OrderBy(x => x.getPrice()).ThenBy(x => x.getMaterialID());
           return list;
        }

        public List<Shooes> Search(List<Shooes> list, int minSize, int maxSize)
        {
            List<Shooes> temp = new List<Shooes>();
            foreach (var size in list)
            {
                if (size.getSize() >= minSize && size.getSize() <= maxSize)
                {
                     temp.Add(size);
                }
            }

            return temp;
        }


    }
}
