using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShishkovIA.sprint1.task1.V0.lib
{
    public class DataService : ISprint1Task1V13
    {

        public double Calculate(double x)
        {
            return x / (0.5 / x);
        }

        public object Calculate()
        {
            throw new NotImplementedException();
        }
    }
}
