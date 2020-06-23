using System;
using System.Collections.Generic;

namespace AulaListas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // PRODUTOS
            System.Console.WriteLine("--Lista de Produtos--");
            List<Produto> produtos = new List<Produto>();

            Produto produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Nome = "Geladeira Brastemp";
            produto1.Preco = 1299.99f;
            produtos.Add(produto1);

            produtos.Add( new Produto(2, "SmartTV Samsung", 1999));
            produtos.Add( new Produto(3, "Fogão Eletrolux", 1999));
            produtos.Add( new Produto(4, "PS5", 3999));
            produtos.Add( new Produto(5, "Xbox", 3500));

            foreach(Produto item in produtos){
                Console.ForegroundColor = ConsoleColor.Blue;

                System.Console.WriteLine($"R${item.Preco} - {item.Nome}");

                Console.ResetColor();
                
            }

            produtos.Remove(produto1);

            produtos.RemoveAt(1);

            produtos.RemoveAll(y => y.Nome == "Microondas");

            foreach(Produto item in produtos){
                Console.ForegroundColor = ConsoleColor.Red;

                System.Console.WriteLine($"R${item.Preco} - {item.Nome}");

                Console.ResetColor();
                
            }

            produtos.Find(x => x.Codigo == 4);
            // FIM PRODUTOS

            //CARTAO
            System.Console.WriteLine("--Lista de Cartões--");
            List<Cartao> cartoes = new List<Cartao>();

            cartoes.Add( new Cartao("Pedro", "4556 4564 5464 5645", "Visa", "25/03/2025" ,"333"));
            cartoes.Add( new Cartao("Joao", "3463 3563 3257 6578", "Cielo", "15/04/2022" ,"353"));
            cartoes.Add( new Cartao("Marcela", "4568 7868 2344 8978", "Visa", "05/06/2026" ,"645"));
            cartoes.Add( new Cartao("Pietro", "9845 0956 9357 0988", "MasterCard", "18/11/2024" ,"356"));

            foreach (Cartao item in cartoes){
                Console.ForegroundColor = ConsoleColor.Red;

                System.Console.WriteLine($"Titular: {item.Titular} - Numero: {item.Numero}");

                Console.ResetColor();
            }
            

        }
    }
}
