using System;
namespace Menu
{
    public class MediaEscolar
    {
        public void Main(double entrada1,double entrada2,double entrada3)
        {
            double media ;
            double p1 = entrada1 ;
            double p2 = entrada2 ;
            double p3 = entrada3 ;
            double resultado;
            double provaFinal;
            double mediaFinal;
            
            resultado = p1+p2+p3;
            media = resultado /3;

            
            if(media >= 6)
            {
                Console.WriteLine("suam media foi de {0}",media,"Parabens voce foi aprovado :D");

            }if(media <6)
            {  
                Console.WriteLine("Voce preicia da nota final para passar , informe a nota final ");
                provaFinal = Convert.ToDouble(Console.ReadLine());
                
                mediaFinal = (provaFinal + media)/2;
            if(mediaFinal>= 6){
                Console.WriteLine("parabens sua media foi de {0}, voce foi aprovado :D",mediaFinal);
            }else{
                Console.WriteLine("Parabens voce foi reprovado O.o");
            }
            }
            

        }
    }
}