using System.Collections.Generic;
using PC2.Domain;
using PC2.Domain.ViewModel;
using PC2.Repository;

namespace PC2.Service.Implementation
{
    public class ViveroService : IViveroService
    {
        private IViveroRepository viveroRepository;
        public ViveroService(IViveroRepository viveroRepository)
        {
            this.viveroRepository = viveroRepository;
        }
        public bool Delete(int id)
        {
            return viveroRepository.Delete(id);
        }

        public IEnumerable<Vivero> FindAll()
        {
            return viveroRepository.FindAll();
        }
        public IEnumerable<Planta_Vivero> ListarPlantas(string nombre)
        {
            return viveroRepository.ListarPlantas(nombre);
        }
        public Vivero FindById(int id)
        {
            return viveroRepository.FindById(id);
        }

        public bool Save(Vivero entity)
        {
            return viveroRepository.Save(entity);
        }
        public bool guardar(ViveroViewModel entity)
        {
            return viveroRepository.guardar(entity);
        }

        public bool Update(Vivero entity)
        {
            return viveroRepository.Update(entity);
        }
    }
}