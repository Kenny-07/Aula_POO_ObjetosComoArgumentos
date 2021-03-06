using System;
using System.Collections.Generic;

namespace Aula_POO_ObjetosComoArgumentos.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            carrinho.Add(produto);
        }
        
        public void MostrarProdutos(){

            if(carrinho != null){

                foreach (var item in carrinho)
                {
                    Console.WriteLine($"{item.Codigo}, {item.Nome}, {item.Preco}");
                    Console.ResetColor();
                }
            }
        }
    }
}