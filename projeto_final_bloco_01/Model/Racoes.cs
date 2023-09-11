using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01_.Model
{
    internal class Racoes : PetShop
    {
        public string usoPara;
        public Racoes(int id, int tipo, string nome, decimal preco, string usoPara) : base(id, tipo, nome, preco)
        {
            this.usoPara = usoPara; 
        }

        //Métodos Get e Set de UsoPara

        public string GetUsoPara()
        {
            return usoPara;
        }

        public void SetUsoPara(string usoPara)
        {
            this.usoPara = usoPara;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Ração para:{usoPara}");
        }
    }
}
