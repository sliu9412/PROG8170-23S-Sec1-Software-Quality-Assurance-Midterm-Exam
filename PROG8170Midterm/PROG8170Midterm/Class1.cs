using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG8170Midterm
{
        public static class Temp
        {
            public static string TemperatureConverter(float ambientTemp)
            {
                string outputTemp = "";

                if (ambientTemp >= 30.0f && ambientTemp <= 40.0f)
                {
                    outputTemp = "It is boling hot outside!";
                }
                else if (ambientTemp >= 20.0f && ambientTemp <= 29.9f)
                {
                    outputTemp = "It is very comfortable.";
                }
                else if (ambientTemp >= 10.0f && ambientTemp <= 19.9f)
                {
                    outputTemp = "It is nice outside.";
                }
                else if (ambientTemp >= 0.0f && ambientTemp <= 9.9f)
                {
                    outputTemp = "Brrr...it is cold.";
                }
                else
                {
                    outputTemp = "Invalid Temperature";
                }
                return outputTemp;
            }
        }
    }





