using System;


public class Jogador{

      public int energia;
      public bool situacao;
      public string nome;
             public Jogador(string n){
        energia = 10;
        situacao = true;
        nome = n;

      }

   }

      class teste{
        static void Main (){

            string n1,n2,n3,res;
            

            Inicio:

          Console.Clear();
          Console.WriteLine("Digite o primeiro nome");
          n1=Console.ReadLine();
          Console.WriteLine("Digite o segundo nome");
          n2=Console.ReadLine();
          Console.WriteLine("Digite o terceiro nome");
          n3=Console.ReadLine();
          Console.Clear();

          Jogador j1=new Jogador(n1);
          Jogador j2=new Jogador(n2);
          Jogador j3=new Jogador(n3);

           Console.WriteLine("Nome do melhor jogador do mundo é {0}", j1.nome);
           Console.WriteLine("    ");
           Console.WriteLine("Nome do segundo melhor jogador do mundo é {0}", j2.nome);
           Console.WriteLine("    ");
           Console.WriteLine("Nome do terceiro melhor jogador do mundo é {0}", j3.nome);
            Console.WriteLine("    ");
            Console.WriteLine("    ");
            Console.WriteLine("Deseja continuar?(Apenas Sim/Não)");
            res=Console.ReadLine();



            switch(res){
            case "Sim":

            goto Inicio;

            break;

            case "Não":

            

              break;


            }
            






        }


      }
    
    



    

