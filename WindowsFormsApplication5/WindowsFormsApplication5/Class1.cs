using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public class Class1
    {
        public static double rast(double x1,double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2,2) + Math.Pow(y1 - y2,2));
        }

        public static string Min(double[] x, double[] y)
        {
            double min = rast(x[0], y[0], x[1], y[1]);
            string a = "0 и 1 = ";
            for (int i = 0; i < x.Length; i++)
            {
                for (int ii = 0; ii < x.Length; ii++)
                {
                    if (i != ii)
                    {
                        if (min > rast(x[i],y[i],x[ii],y[ii]))
                        {
                            min = rast(x[i], y[i], x[ii], y[ii]);
                            a = Convert.ToString(i) + " и " + Convert.ToString(ii) + " = ";
                        }
                    }
                }
            }
            return a + min.ToString();
        }
    }
}