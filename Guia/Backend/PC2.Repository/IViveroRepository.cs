using System.Collections.Generic;
using PC2.Domain.ViewModel;

using PC2.Domain;

namespace PC2.Repository
{
    public interface IViveroRepository : IRepository<Vivero>
    {
        IEnumerable<Planta_Vivero>ListarPlantas(string nombre);
        bool guardar(ViveroViewModel entity);
    }
}