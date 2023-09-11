using projeto_final_bloco_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_final_bloco_01.Repository
{
    public interface IAnimalRepository
    {
        public void Criar(Animal animal);
        public void ListarCapivaras();
        public void ConsultarPorId(int id);
        public void Atualizar(Animal animal);
        public void Deletar(int id);
    }
}
