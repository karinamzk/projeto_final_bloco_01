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
        private readonly List<PetShop> ListaProduto = new ();
        int id = 0;

        //Métodos Crud
        public void AtualizarProduto(PetShop produto)
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"A Conta {id} não foi encontrada!");
                Console.ResetColor();
            }
        }

        public void CriarProduto(PetShop produto)
        {
            ListaProduto.Add(produto);
            Console.WriteLine($"O Produto {produto.GetId()} foi criado com sucesso!");
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
            foreach(var produto in ListaProduto)
            {
                produto.Visualizar();
            }
        }

        //Métodos 
        public int GerarId()
        {
            return ++id;
        }

        public PetShop? BuscarColletion(int numero)
        {
            foreach (var produto in ListaProduto)
            {
                if (produto.GetId() == id)
                    return produto;
            }
            return null;
        }

    }

}

