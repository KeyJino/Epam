using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    public class Service
    {
        MaleStock _maleStock = new MaleStock();
        FemaleStock _femaleStock = new FemaleStock();
        ChildStock _childStock = new ChildStock();

        private static Random size = new Random();
        private static Random price = new Random();
        private static Random materialId = new Random();

        private Winter _winter = new Winter(size.Next(37) + 7, price.Next(50) + 100, materialId.Next(10));
        private Summer _summer = new Summer(size.Next(37) + 7, price.Next(50) + 100, materialId.Next(10));
        private SpringAutumn _springAutumn = new SpringAutumn(size.Next(37) + 7, price.Next(50) + 100, materialId.Next(10));
        private Season _season = new Season(size.Next(37) + 7, price.Next(50) + 100, materialId.Next(10));

        public Service()
        {
            _maleStock.addToStock();
            _maleStock.sorting();
            _maleStock.complect(_summer, 1500);

            _femaleStock.addToStock();
            _femaleStock.sorting();
            _femaleStock.complect(_summer, 2500);

            _childStock.addToStock();
            _childStock.sorting();
            _childStock.complect(_summer, 2500);
        }


        /*
        public List<AShooes> familyComplect()
        {

            //do it
            List<AShooes> temp = new List<AShooes>();
            temp.Add(_childStock);
            return temp;
        }
        */

    }

}