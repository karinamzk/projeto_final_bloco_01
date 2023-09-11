using projeto_final_bloco_01_.Model;
using projeto_final_bloco_01_.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01_.Controller
{
    public class ProdutoController : IProdutoRepository
    {

        private readonly List<PetShop> ListaProduto = new List<PetShop>();
        int id = 0;

        //Métodos Crud
        /*public void AtualizarProduto(PetShop produto)
        {
            var buscarProduto = BuscarColletion(produto.GetId());

            if(buscarProduto is not null)
            {
                var index = ListaProduto.IndexOf(buscarProduto);

                ListaProduto[index] = produto;

                Console.WriteLine($"O Produto {produto.GetId()} foi atualizado!");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O Produto {id} não foi encontrado!");
                Console.ResetColor();
            }
        } */

        private PetShop? BuscarColletion(int id)
        {
            foreach (var produto in ListaProduto)
            {
                if (produto.GetId() == id)
                    return produto;
            }
            return null;
        }

        public void BuscarProduto(int id)
        {
            var produto = BuscarColletion(id);

            if (produto is not null)
            {
                produto.Visualizar();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O Produto {id} não foi encontrado!");
                Console.ResetColor();
                        
            }
        }
        public void CriarProduto(PetShop p)
        {
            ListaProduto.Add(p);  
            Console.WriteLine($"O Produto{p.GetId()} foi criado com sucesso!");
        }

        public void DeletarProduto(int id)
        {
            var produto = BuscarColletion(id);

            if (produto is not null)
            {
                if (ListaProduto.Remove(produto) == true)
                    Console.WriteLine($"O Produto {id} foi apagado com sucesso!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O Produto {id} não foi encontrado!");
                Console.ResetColor();
            }
        }

        public void ListarTodos()
        {
            foreach(var p in ListaProduto)
            {
                p.Visualizar();
            }
        }
        public int GerarId()
        {
            return ++id;
        }

        public void BuscarProduto(PetShop produto)
        {
            var produto = BuscarColletion(id);

            if (produto is not null)
            {
                produto.Visualizar();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O Produto {id} não foi encontrado!");
                Console.ResetColor();

            }
        }

        public void AtualizarProduto(PetShop produto)
        {
            var buscarProduto = BuscarColletion(produto.GetId());

            if (buscarProduto is not null)
            {
                var index = ListaProduto.IndexOf(buscarProduto);

                ListaProduto[index] = produto;

                Console.WriteLine($"O Produto {produto.GetId()} foi atualizado!");

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"O Produto {id} não foi encontrado!");
                Console.ResetColor();
            }
        }
    }
}
