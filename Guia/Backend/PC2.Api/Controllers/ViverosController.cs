using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PC2.Service;
using PC2.Domain;
using PC2.Domain.ViewModel;

namespace PC2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViverosController : ControllerBase
    {
        private IViveroService viveroService;

        public ViverosController(IViveroService viveroService)
        {
            this.viveroService = viveroService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Vivero>> Get()
        {
            return Ok(
                viveroService.FindAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Vivero> Get(int id)
        {
            return Ok(
                viveroService.FindById(id)
            );
        }

        // GET api/values/5
        [HttpGet("Plantas/{nombre}")]
        public ActionResult<Planta_Vivero> GetPlantas(string nombre)
        {
            return Ok(
                viveroService.ListarPlantas(nombre)
            );
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] ViveroViewModel vivero)
        {
            return Ok(
                viveroService.guardar(vivero)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] Vivero vivero)
        {
            return Ok(
            viveroService.Update(vivero)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
            viveroService.Delete(id)
            );
        }
    }
}