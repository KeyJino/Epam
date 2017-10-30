using System;
using System.Collections.Generic;
using Epam.Shop.Bins;
using Epam.Shop.Abstract;
using Shop.Interface;

namespace Epam.Shop.Repository
{
    class FemaleStock : AStock, IStock
    {
        private static ICollection<AShooes> _shoes;
        private static Random _random = new Random();

        private static List<AShooes> _typeSeason =
            new List<AShooes>(4){
                new Season(_random.Next(7) + 37, _random.Next(50) + 100, _random.Next(10)),
                new Summer(_random.Next(7) + 37, _random.Next(50) + 100, _random.Next(10)),
                new Winter(_random.Next(7) + 37, _random.Next(50) + 100, _random.Next(10)),
                new SpringAutumn(_random.Next(7) + 37, _random.Next(50) + 100, _random.Next(10))
        };

        public FemaleStock() : base(_typeSeason, _shoes)
        {
            
        }

        public void addToStock()
        {
            for (int i = 0; i < 10; i++)
            {
                _shoes.Add(_typeSeason[_random.Next(4)]);
            }
        }
    }
}
