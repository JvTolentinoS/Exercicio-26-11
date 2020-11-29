using System;

namespace Exercicio_26_11
{
    class Program
    {
        static void Main(string[] args0)
        {   
            int escolha;
            string[] nome = new string[2];
            float[] valor = new float[2];
            bool[] desconto = new bool[2];
            var contador = 0;
            do{
                Console.Clear();
                Console.WriteLine("Menu Inicial");
                Console.WriteLine("Seleciona uma opção");
                Console.WriteLine("[1] - Cadastrar produtos");
                Console.WriteLine("[2] - Listar produtos");
                Console.WriteLine("[3] - Sair");
                escolha = int.Parse(Console.ReadLine());

            switch (escolha){
                case 1:
                CadastrarProdutos();
                break;

                case 2:
                ListarProdutos();
                break;

                case 3:
                Console.WriteLine("Tenha um bom dia!");
                break;
            }
            
            void CadastrarProdutos(){
                for(contador = 0; contador < 2; contador++)
                {
                Console.WriteLine("Digite o nome do produto");
                nome[contador] = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto");
                valor[contador] = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite true para com desconto e false para sem desconto");
                desconto[contador] = bool.Parse(Console.ReadLine());
                }

                Console.WriteLine("Seleciona uma opção");
                Console.WriteLine("[1] - Cadastrar produtos novamente");
                Console.WriteLine("[2] - Listar produtos");
                Console.WriteLine("[3] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha){
                case 1:
                CadastrarProdutos();
                break;

                case 2:
                ListarProdutos();
                break;

                case 3:
                Console.WriteLine("-----------------");
                Console.WriteLine("Tenha um bom dia!");
                break;
            }
            }

            void ListarProdutos(){
                for(contador = 0; contador < 2; contador++)
                {
                    Console.WriteLine("Nome: "+nome[contador]);
                    Console.WriteLine("Preço: R$ "+valor[contador]);
                    if(desconto[contador] == true){
                        Console.WriteLine("Desconto: Sim");
                    }else{
                        Console.WriteLine("Desconto: Não");
                    }
                }
                Console.WriteLine("Seleciona uma opção");
                Console.WriteLine("[1] - Cadastrar produtos novamente");
                Console.WriteLine("[2] - Listar produtos");
                Console.WriteLine("[3] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha){
                case 1:
                CadastrarProdutos();
                break;

                case 2:
                ListarProdutos();
                break;

                case 3:
                Console.WriteLine("-----------------");
                Console.WriteLine("Tenha um bom dia!");
                break;
            }
            }
        } while (escolha !=3);
            



        }
    }
}
