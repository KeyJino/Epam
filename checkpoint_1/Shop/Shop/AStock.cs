using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public abstract class AStock
    {
        private List<AShooes> shoes = new List<AShooes>();
        private static Random random = new Random();

        private List<AShooes> typeSeason =
        new List<AShooes>(4){
    
            new Season(random.Next(7) + 37, random.Next(50) + 100, random.Next(10)),
            new Summer(random.Next(7) + 37, random.Next(50) + 10, random.Next(10)),
            new Winter(random.Next(7) + 37, random.Next(50) + 100, random.Next(10)),
            new SpringAutumn(random.Next(7) + 37, random.Next(50) + 100, random.Next(10))

        };

        public AStock()
        {

        }

        public void addToStock()
        {
            for (int i = 0; i < 10; i++)
            {
                shoes.Add(typeSeason[random.Next(4)]);
            }
        }

        public void sorting()
        {
            shoes.OrderBy(x => x.getPrice()).ThenBy(x => x.getMaterialID());
        }

        public List<AShooes> search(int minSize, int maxSize)
        {
            List<AShooes> temp = new List<AShooes>();
            foreach (var size in shoes)
            {
                if (size.getSize() >= minSize && size.getSize() <= maxSize)
                {
                    temp.Add(size);
                }
            }
            return temp;
        }

        public List<AShooes> complect(AShooes season, int maxPrice)
        {

            int sum = 0;
            List<AShooes> temp = new List<AShooes>();
            foreach (AShooes model in shoes)
            {
                if (shoes.Contains(season) == true && (model.getPrice() + sum <= maxPrice))
                {
                    temp.Add(model);
                    sum += model.getPrice();
                }
            }
            return temp;
        }

        
      
        




  



    }
}
