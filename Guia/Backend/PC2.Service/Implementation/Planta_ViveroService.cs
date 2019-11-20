using System.Collections.Generic;
using PC2.Domain;
using PC2.Repository;

namespace PC2.Service.Implementation
{
    public class Planta_ViveroService : IPlanta_ViveroService
    {
        private IPlanta_ViveroRepository planta_viveroRepository;

        public Planta_ViveroService(IPlanta_ViveroRepository planta_viveroRepository)
        {
            this.planta_viveroRepository = planta_viveroRepository;
        }

        public bool Delete(int id)
        {
            return planta_viveroRepository.Delete(id);
        }

        public IEnumerable<Planta_Vivero> FindAll()
        {
            return planta_viveroRepository.FindAll();
        }

        public Planta_Vivero FindById(int id)
        {
            return planta_viveroRepository.FindById(id);
        }

        public bool Save(Planta_Vivero entity)
        {
            return planta_viveroRepository.Save(entity);
        }

        public bool Update(Planta_Vivero entity)
        {
            return planta_viveroRepository.Update(entity);
        }
    }
}