using Epam.Shop.Repository;
using Epam.Shop.Bins;
using System;


namespace Epam.Shop.Services
{
    public class Service
    {
        private MaleStock _maleStock = new MaleStock();
        private FemaleStock _femaleStock = new FemaleStock();
        private ChildStock _childStock = new ChildStock();

        private static Random _size = new Random();
        private static Random _price = new Random();
        private static Random _materialId = new Random();

        private Winter _winter = new Winter(_size.Next(37) + 7, _price.Next(50) + 100, _materialId.Next(10));
        private Summer _summer = new Summer(_size.Next(37) + 7, _price.Next(50) + 100, _materialId.Next(10));
        private SpringAutumn _springAutumn = new SpringAutumn(_size.Next(37) + 7, _price.Next(50) + 100, _materialId.Next(10));
        private Season _season = new Season(_size.Next(37) + 7, _price.Next(50) + 100, _materialId.Next(10));

        public Service()
        {
            _maleStock.addToStock();
            _maleStock.sorting();
            _maleStock.complect(_summer, 200);
            _maleStock.seasonsComplect();

            _femaleStock.addToStock();
            _femaleStock.sorting();
            _femaleStock.complect(_summer, 250);
            _femaleStock.seasonsComplect();

            _childStock.addToStock();
            _childStock.sorting();
            _childStock.complect(_summer, 250);
            _childStock.seasonsComplect();
        }
    }
}