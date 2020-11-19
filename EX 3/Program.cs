using System;

namespace EX_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade = 0;
            double salario =0;
            string estado;
           do
           {  
               Console.WriteLine("Qual seu nome?");
              nome = Console.ReadLine();

                Console.WriteLine("qual a sua idade");
                idade =int.Parse(Console.ReadLine());

                 Console.WriteLine("qual é o seu salario?");
                salario= double.Parse(Console.ReadLine());

                  Console.WriteLine("seu estado civil é: (s)solteiro/a | (c)casado/a | (v)viuvo/a | (d)divorciado/a | ?");
                 estado= Console.ReadLine();
                   if(nome == ""){Console.WriteLine("Defina um nome valido"); nome = "";}

                if(idade < 0 || idade >150){ Console.WriteLine("Defina uma idade valido"); idade = 1;}

                if(salario == 0){ Console.WriteLine("Defina um salario valido"); salario = 0;}

                if(estado == "s" || estado == "c" || estado == "v" || estado == "d"){}
                
                else{
                    Console.WriteLine("Defina um estado civil valido");
                    estado = "";
           }
           }
           while(nome == "" || idade == 1 || salario == 0 || estado == "" );

            Console.WriteLine("Confirme seus dados");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salario: " + salario);
            Console.WriteLine("Estado Civil: " + estado);

            Console.WriteLine("Validação concluida");
           
        }
    }
}
