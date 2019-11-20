using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PC2.Service;
using PC2.Domain;

namespace PC2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Plantas_ViverosController : ControllerBase
    {
        private IPlanta_ViveroService planta_viveroService;

        public Plantas_ViverosController(IPlanta_ViveroService planta_viveroService)
        {
            this.planta_viveroService = planta_viveroService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Planta_Vivero>> Get()
        {
            return Ok(
                planta_viveroService.FindAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Planta_Vivero> Get(int id)
        {
            return Ok(
                planta_viveroService.FindById(id)
            );
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Planta_Vivero planta_vivero)
        {
            return Ok(
                planta_viveroService.Save(planta_vivero)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] Planta_Vivero planta_vivero)
        {
            return Ok(
                planta_viveroService.Update(planta_vivero)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                planta_viveroService.Delete(id)
            );
        }
    }
}