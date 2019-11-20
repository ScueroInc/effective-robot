using System.Collections.Generic;
using PC2.Domain;
using PC2.Repository;

namespace PC2.Service.Implementation
{
    public class PlantaService : IPlantaService
    {
        private IPlantaRepository plantaRepository;

        public PlantaService(IPlantaRepository plantaRepository)
        {
            this.plantaRepository = plantaRepository;
        }
        public bool Delete(int id)
        {
            return plantaRepository.Delete(id);
        }

        public IEnumerable<Planta> FindAll()
        {
            return plantaRepository.FindAll();
        }

        public Planta FindById(int id)
        {
            return plantaRepository.FindById(id);
        }

        public bool Save(Planta entity)
        {
            return plantaRepository.Save(entity);
        }

        public bool Update(Planta entity)
        {
            return plantaRepository.Update(entity);
        }
    }
}