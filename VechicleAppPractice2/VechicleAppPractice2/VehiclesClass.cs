using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VechicleAppPractice2
{
    public  class VehiclesClass
    {
        public string name { get; set; }
        public string reg { get; set; }

        public  List<double> speed = new List<double>();

        public Double MaxCalculate()
        {
            return speed.Max();
        }
        public Double MinCalculate()
        {
            return speed.Min();
        }
        public Double AvgCalculate()
        {
            return speed.Average();
        }



    }
}
