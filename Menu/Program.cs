using System;

namespace Menu
{
    class Program
  {
        static void Main(string[] args){
        
            int opcao;
            double Entrada1;
            double Entrada2;
            double Entrada3;
            
            bool validate = true;
            
            Program program = new Program();
            
            Console.WriteLine("### sejam bem vindos a calculadora DOTNET####");
        do 
        {
            Console.WriteLine("Qual a operação desjada ? :");
            Console.WriteLine("(1)Calculo IMC");
            Console.WriteLine("(2)Calculo Salario");
            Console.WriteLine("(3)Calculo Esfera");
            Console.WriteLine("(4)Calculo media escolar ");
            Console.WriteLine("(5)Banco de animais ");
            Console.WriteLine("(6)Finalizar Progama");
            
            Console.WriteLine("Digite a sua opção: ");
            
            opcao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(opcao);
            
           switch (opcao)
                {
                    case 1:
                        Console.WriteLine("informe seu peso");
                        Entrada1=Convert.ToDouble(Console.ReadLine());
                        
                        Console.WriteLine("informe sua altura");
                        Entrada2 =Convert.ToDouble(Console.ReadLine());

                        CalculoImc imc = new CalculoImc();
                        imc.Main(Entrada1,Entrada2);                     
                        
                        break;
                    case 2:

                     Console.WriteLine("Calculadora para saber o quanto voce ganah em salarios minimos:");
                     Console.WriteLine("O salario minimo atual é de 1.100 R$ ,tendo esta valor como base iremos calclular o quando vc ganha");
                     Console.WriteLine("informe seu salario :  ");
                     Entrada1 = Convert.ToDouble(Console.ReadLine());

                        SalarioMinimo converter = new SalarioMinimo();
                        converter.Main(Entrada1);

                        break;
                    case 3:
                        Console.WriteLine("Bem vindo ao Calculo de efera , para descobir , informe o raio desejado :  ");
                        Entrada1 =Convert.ToDouble(Console.ReadLine());

                             Esfera calc = new Esfera();
                             calc.Main(Entrada1);
                        break;
                    case 4:
                        Console.WriteLine("Descubra a sua media : ");
                        Console.WriteLine("informe sua nota p1");
                        Entrada1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("informe sua nota p2");
                        Entrada2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("informe sua nota p3");
                        Entrada3 = Convert.ToDouble(Console.ReadLine());

                        MediaEscolar med = new MediaEscolar();
                            
                            med.Main(Entrada1,Entrada2,Entrada3);

                         break;
                    case 5:
                
                        BancoAnimais Animais = new BancoAnimais();
                        Animais.Main();

                        break;
                    case 6:
                        validate = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.Clear();
                        break;
                }

                Console.WriteLine("Aperte ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
            } while (validate);
        }
    }
}
