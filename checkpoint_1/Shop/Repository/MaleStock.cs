using System.Collections.Generic;
using Epam.Shop.Abstract;
using Epam.Shop.Bins;
using Shop.Interface;
using System;

namespace Epam.Shop.Repository
{
    public class MaleStock : AStock, IStock
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

        public MaleStock() : base(_typeSeason, _shoes)
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
