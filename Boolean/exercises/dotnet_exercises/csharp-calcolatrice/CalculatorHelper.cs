using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    public static class CalculatorHelper
    {
        public static double Sum(double @num_1, double @num_2) => @num_1 + @num_2;
        public static double Sub(double @num_1, double @num_2) => @num_1 - @num_2;
        public static double Mlp(double @num_1, double @num_2) => @num_1 * @num_2;
        public static double Abs(double @num_1){
            if(@num_1 < 0){
                return @num_1 * (-1);
            } else {
                return @num_1;
            }
        }
        public static double MinMax(double @num_1, double @num_2){
            //string value = "ciao";
            if(@num_1 > @num_2){
                //value = "First num is Max and second num is Min";
                return @num_1;
            } else if (@num_1 == @num_2){
                //value = "First num and second num are equals";
                return @num_1;
            } else {
                //value = "First num is Min and second num is Max";
                return @num_2;
            }
        }
        public static int Exp(int a, int b){
            if(b > 0 && a > 0){
                int resutl = 1;
                for (int i = 0; i < b; i++)
                {
                    resutl *= a;
                }
                return resutl;
            } else if (b == 0 || (a == 0 && b == 0)) {
                return a = 1;
            } else if (b < 0 && a > 0) {
                int resutl = 1;
                for (int i = 0; i < b; i++)
                {
                    resutl *= a;
                }
                return 1/(resutl);
            } else if (a == 0 && b != 0){
                return a = 0;
            } else {
                return a;
            }
        }
    }
}