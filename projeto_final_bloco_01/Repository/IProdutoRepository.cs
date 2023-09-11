using projeto_final_bloco_01_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01_.Repository
{
    public   interface IProdutoRepository
    {
        public void CriarProduto(PetShop produto);

        public void ListarTodos();

        public void BuscarProduto(PetShop produto);

        public void AtualizarProduto();

        public void DeletarProduto(int id);
     
    }
}
