using System;
using System.Collections.Generic;
namespace Menu
{
    public class BancoAnimais
    {
        public void Main()
        {
            Console.WriteLine("Vamos calcular a quantidade de tipos dos animais inseridos:");
                        int contGato = 0;
                        int contCach = 0;
                        int contPex = 0;
                        string  nome;
                        string  tipo;

                       for (int i = 0; i < 5; i++) {
                            
                            Console.WriteLine("\nDigite o nome do seu animal de estimação:");
                            nome = Console.ReadLine().Trim();

                            Console.WriteLine("Digite o tipo do seu animal de estimação:");
                            tipo = Console.ReadLine().Trim().ToLower();

                            Console.WriteLine("\nO nome do seu {0} é: {0}.", tipo,nome);

                            if (tipo == "cachorro")
                            {
                                contCach++;
                            }
                            else if (tipo == "gato")
                            {
                                contGato++;
                            }
                            else
                            {
                                contPex++;
                            }

                       }
                        Console.WriteLine("\nO número de Cachorro é: {0} ", contCach);
                        Console.WriteLine("O número de Gato é: {0} ", contGato);
                        Console.WriteLine("O número de Peixe é: {0} ", contPex);

        }

    }
}