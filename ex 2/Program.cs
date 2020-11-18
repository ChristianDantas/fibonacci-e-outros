using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            string senha =  "";

            while(true){
                Console.WriteLine("digite seu nome:");
                    nome= Console.ReadLine();

                Console.WriteLine("digite sua senha :");
                senha = Console.ReadLine();

                if(nome == senha){
                    Console.WriteLine("você nao pode ter seu nome em sua senha");
                }else{break;}
            }
            Console.WriteLine("obrigado!!! seja bem-vindo " + nome);
            }
        }
    }

