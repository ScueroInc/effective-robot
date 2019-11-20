using System.Collections.Generic;
using PC2.Domain;
using PC2.Domain.ViewModel;

namespace PC2.Service
{
    public interface IViveroService : IService<Vivero>
    {
        IEnumerable<Planta_Vivero> ListarPlantas(string nombre);
        bool guardar(ViveroViewModel entity);
    }
}