using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01_.Model
{
    public class Medicamentos : PetShop
    {
        public string marca, nome;
        public Medicamentos(int id, int tipo, string nome, decimal preco, string marca) : base(id, tipo, nome, preco)
        {
            this.marca = nome;  
        }

        //Métodos Get e Set de Marca
        public string Marca ()
        { 
            return marca; 
        }

        public void SetMarca(string marca)
        {
            this.marca= marca;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Marca do Medicamento {nome}: {marca}");
        }

    }
}
