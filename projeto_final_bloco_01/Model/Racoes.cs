using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01_.Model
{
    public class Racoes : PetShop
    {
        private string animal;
        
        public Racoes(int id, int tipo, string nome, decimal preco, string animal) 
            : base(id, tipo, nome, preco)
        {
            this.animal = animal; 
        }

        //Métodos Get e Set de UsoPara

        public string GetAnimal()
        {
            return animal;
        }

        public void SetAnimal(string animal)
        {
            this.animal = animal;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Ração para:{animal}");
        }
    }
}
