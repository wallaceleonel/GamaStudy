using System;
namespace Menu
{
    public class Esfera
    {
        public void Main (double entrada1){
            double v;
            double pi =3.14;
            double R = entrada1;

            v =(4/3*(pi*(R*R*R)));
             
            Console.WriteLine(" O volume da esfeta é de {0}",v);      
        }
    }
}