using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumatoria_arrays
{
    internal class clsFuncionesArit
    {
        
        public double Num1 {  get; set; }
        public double Num2{ get; set;}
        public clsFuncionesArit(double n1,double n2) {
        Num1 = n1;
        Num2 = n2;  
        }
        // metodos

        public double area() { 
        double area = 0;
            area= Num1 * Num2;

            return area;
        }

    }
}
