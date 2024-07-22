using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StudentGradesCalculator
{
    public class Std
    {
        public string GetGradesByPercentage(int percentage)
        {
            if (percentage > 90 && percentage < 100)
            {
                return "A+";
            }
            else if (percentage > 80 && percentage < 90)
            {
                return "A Grade";
            }
            else
            {
                return "Fail";
            }
        }
    }
}
