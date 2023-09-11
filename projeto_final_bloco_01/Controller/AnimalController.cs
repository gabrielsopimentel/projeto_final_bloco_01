using projeto_final_bloco_01.Model;
using projeto_final_bloco_01.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Controller
{
    internal class AnimalController : IAnimalRepository
    {
        private readonly List<Animal> listaCapivaras = new List<Animal>();

        int num = 0;

        public void Atualizar(Animal animal)
        {
            var busca = BuscarColletion(animal.GetId());

            if (busca != null)
            {
                var i = listaCapivaras.IndexOf(busca);
                listaCapivaras[i] = animal;
                Console.WriteLine($"A capivara {animal.GetId()} foi atualizada com sucesso!");
            }
            else
            {
                Console.WriteLine($"A capivara {num} não foi encontrada!");
            }
        }

        public void ConsultarPorId(int id)
        {
            var animal = BuscarColletion(id);

            if (animal != null)
            {
                animal.Visualizar();
            }
            else
            {
                Console.WriteLine($"A capivara {num} não foi encontrada!");
            }
        }

        public void Criar(Animal animal)
        {
            listaCapivaras.Add(animal);
            Console.WriteLine($"o produto {animal.GetId()} foi inserido com sucesso!");
        }

        public void Deletar(int id)
        {
            var animal = BuscarColletion(id);

            if (animal != null)
            {
                if (listaCapivaras.Remove(animal) == true)
                {
                    Console.WriteLine($"A capivara {num} foi apagada com sucesso!");
                }
            }
            else
            {
                Console.WriteLine($"A capivara {num} não foi encontrada!");
            }
        }

        public void ListarCapivaras()
        {
            foreach (var animal in listaCapivaras)
            {
                animal.Visualizar();
            }
        }

        public Animal BuscarColletion(int id)
        {
            foreach (var animal in listaCapivaras)
            {
                if (animal.GetId() == id)
                    return animal;
            }
            return null;
        }

        public int GerarNumero()
        {
            return ++num;
        }

        public int GeraRandom() 
        {
            var rand = new Random();
            return rand.Next(9999);
        }
    }
}
