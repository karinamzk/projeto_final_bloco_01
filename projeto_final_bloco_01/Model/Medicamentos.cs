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
        public string marca;
        public Medicamentos(int id, int tipo, string nome, decimal preco, string marca) 
            : base(id, tipo, nome, preco)
        {
            this.marca = marca;  
        }

        //Métodos Get e Set de Marca
        public string GetMarca ()
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
            Console.WriteLine($"Marca do Medicamento: {marca}");
        }

    }
}
