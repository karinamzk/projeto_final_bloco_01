using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01_.Model
{
    public abstract class PetShop
    {
        //Atributos
        private int id, tipo;
        private string nome;
        private decimal preco;

        //Métodos Construtor 
        protected PetShop(int id, int tipo, string nome, decimal preco)
        {
            this.id = id;
            this.tipo = tipo;
            this.nome = nome;
            this.preco = preco;
        }

        //Polimorfismo de sobrecarga

        /*public Produto() { }*/

        //Métodos GET e SET

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            this.id = id;
        }



        public int GetTipo()
        {
            return tipo;
        }

        public void SetTipo(int tipo)
        {
            this.tipo= tipo;
        }



        public string GetNome()
        {
            return nome;
        }

        public void SetNome(string name)
        {
            this.nome = name;
        }


        public decimal GetPreco()
        {
            return preco;
        }

        public void Setpreco(decimal preco)
        {
            this.preco= preco;  
        }

        public virtual void Visualizar()
        {
            string tipo = "";

            switch (this.tipo)
            {
                case 1:
                    tipo = "Rações";
                    break;
                case 2:
                    tipo = "Medicamento";
                    break;
            }
            Console.WriteLine("*********************************");
            Console.WriteLine("Dados do Produto");
            Console.WriteLine("*********************************");
            Console.WriteLine($"Produto : {this.nome}");
            Console.WriteLine($"Id : {this.id}");
            Console.WriteLine($"Tipo : {tipo}");
            Console.WriteLine($"Preço : {this.preco}");
        }
    }
}
