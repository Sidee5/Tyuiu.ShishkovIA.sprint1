using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShishkovIA.sprint1.task2.V26.lib
{
    public class DataService : ISprint1Task2V26
    {
        public int CalculateMinutesSinceStart(int value, int valueTwo)
        {
            return value * 60 + valueTwo;
        }
    }
}
