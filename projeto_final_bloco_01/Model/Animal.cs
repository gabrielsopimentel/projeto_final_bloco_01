using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Model
{
    public abstract class Animal
    {
        private int id;
        private string nome;
        private char genero;
        private int idade;

        protected Animal(int id, string nome, char genero, int idade)
        {
            this.id = id;
            this.nome = nome;
            this.genero = genero;
            this.idade = idade;
        }

        public int GetId() { return id; }
        public string GetNome() { return nome; }
        public char GetGenero() { return genero; }
        public int GetIdade() { return idade; }

        public void SetId(int id) { this.id = id; }
        public void SetNome(string nome) { this.nome = nome; }
        public void SetGenero(char genero) { this.genero = genero; }
        public void SetIdade(int idade) { this.idade = idade; }

        public abstract void Nadar();
        public abstract void Correr();

        public virtual void Visualizar()
        {
            Console.WriteLine("**************");
            Console.WriteLine("Dados da capivara");
            Console.WriteLine("**************");
            Console.WriteLine($"Identificação: {this.id}");
            Console.WriteLine($"Nome da capivara: {this.nome}");
            Console.WriteLine($"Genero da capivara: {this.genero}");
            Console.WriteLine($"Idade da capivara:{this.idade}");
        }
    }

}
