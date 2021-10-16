using System;

namespace Menu
{
    class SalarioMinimo{
        public void Main (double entrada1){

            double salariominimo = 1045;
            double Salario = entrada1;
            double salariosm ;
        
            salariosm = salariominimo/Salario;

            Console.WriteLine("seu salario em salarios minimos e de {0}",salariosm);
        
        }
    }
}