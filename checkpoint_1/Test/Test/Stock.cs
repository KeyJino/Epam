using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Appointments.AppointmentsProvider;
using Bin;

namespace test
{
    class Stock
    {
        List<Shooes> maleShoeses = new List<Shooes>(100);
        List<Shooes> femaleShoeses = new List<Shooes>(100);
        List<Shooes> childShoeses = new List<Shooes>(100);

        static Random random = new Random();

        private List<Shooes> typeSeason =
        new List<Shooes>(4){

            new Season(random.Next(7) + 37, random.Next(50) + 100, random.Next(10000)),
            new Summer(random.Next(7) + 37, random.Next(50) + 10, random.Next(10000)),
            new Winter(random.Next(7) + 37, random.Next(50) + 100, random.Next(10000)),
            new SpringAutumn(random.Next(7) + 37, random.Next(50) + 100, random.Next(10000))

        };


        private void addToStock()
        {
            for (int i = 0; i < maleShoeses.Count; i++)
            {
                maleShoeses[i] = typeSeason[random.Next(4)];
                femaleShoeses[i] = typeSeason[random.Next(4)];
                childShoeses[i] = typeSeason[random.Next(4)];
            }
        }



        

    }
}
