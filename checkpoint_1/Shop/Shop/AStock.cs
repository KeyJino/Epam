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
        private List<AShooes> _shoes = new List<AShooes>();
        private static Random _random = new Random();

        private List<AShooes> _typeSeason =
            new List<AShooes>(4){
                new Season(_random.Next(7) + 37, _random.Next(50) + 100, _random.Next(10)),
                new Summer(_random.Next(7) + 37, _random.Next(50) + 100, _random.Next(10)),
                new Winter(_random.Next(7) + 37, _random.Next(50) + 100, _random.Next(10)),
                new SpringAutumn(_random.Next(7) + 37, _random.Next(50) + 100, _random.Next(10))
        };

        public void addToStock()
        {
            for (int i = 0; i < 10; i++)
            {
                _shoes.Add(_typeSeason[_random.Next(4)]);
            }
        }

        public void sorting()
        {
            _shoes.OrderBy(x => x.getPrice()).ThenBy(x => x.getMaterialID());
        }

        public List<AShooes> search(int minSize, int maxSize)
        {
            List<AShooes> _temp = new List<AShooes>();
            foreach (var size in _shoes)
            {
                if (size.getSize() >= minSize && size.getSize() <= maxSize)
                {
                    _temp.Add(size);
                }
            }
            return _temp;
        }

        public List<AShooes> complect(AShooes season, int maxPrice)
        {
            int _sum = 0;
            List<AShooes> _temp = new List<AShooes>();
            foreach (AShooes model in _shoes)
            {
                if (Object.ReferenceEquals(model.GetType(), season.GetType()) && 
                   (model.getPrice() + _sum <= maxPrice))
                {
                    _temp.Add(model);
                    _sum += model.getPrice();
                }
            }
            return _temp;
        }

        public List<AShooes> seasonsComplect()
        {
            List<AShooes> _temp = new List<AShooes>();

            foreach (AShooes _model in _shoes)
            {
                if (_shoes.Contains(_model) == true && _temp.Contains(_model) != true)
                {
                    _temp.Add(_model);
                }

                else
                {
                    continue;
                }
            }
            return _temp;
        }

        
      
        




  



    }
}
