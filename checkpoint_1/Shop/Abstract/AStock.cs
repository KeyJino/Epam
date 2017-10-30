using System;
using System.Collections.Generic;
using System.Linq;


namespace Epam.Shop.Abstract
{
    public abstract class AStock
    {
        private ICollection<AShooes> _shoes;
        private ICollection<AShooes> _typeSeason;
        private static Random _random = new Random();

        public AStock(ICollection<AShooes> typeSeason, ICollection<AShooes> shoes)
        {
            _typeSeason = typeSeason;
            _shoes = shoes;
        }

        public void sorting()
        {
            _shoes.OrderBy(x => x.getPrice()).ThenBy(x => x.getMaterialID());
        }

        public ICollection<AShooes> search(int minSize, int maxSize)
        {
            ICollection<AShooes> _temp = new List<AShooes>();
            foreach (var size in _shoes)
            {
                if (size.getSize() >= minSize && size.getSize() <= maxSize)
                {
                    _temp.Add(size);
                }
            }
            return _temp;
        }

        public ICollection<AShooes> complect(AShooes season, int maxPrice)
        {
            int _sum = 0;
            ICollection<AShooes> _temp = new List<AShooes>();
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

        public ICollection<AShooes> seasonsComplect()
        {
            ICollection<AShooes> _temp = new List<AShooes>();

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
