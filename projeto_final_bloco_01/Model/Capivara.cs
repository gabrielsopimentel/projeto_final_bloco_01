using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    internal class Capivara : Animal
    {
        private int deh;
        public Capivara(int id, string nome, char genero, int idade, int deh) : base(id, nome, genero, idade)
        {
            this.deh = deh;
        }

        public int GetDeh() { return deh; }
        public void SetDeh(int deh) { this.deh = deh; }

        public override void Correr()
        {
            Console.WriteLine("Estou correndo...");
        }

        public override void Nadar()
        {
            Console.WriteLine("Estou nadando...");
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.Write($"Documento específico hydrochoerus hydrochaeris: {this.deh} \n");
        }
    }
}
