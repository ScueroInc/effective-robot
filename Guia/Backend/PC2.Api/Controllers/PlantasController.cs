using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PC2.Service;
using PC2.Domain;

namespace PC2.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantasController : ControllerBase
    {
        private IPlantaService plantaService;

        public PlantasController(IPlantaService plantaService)
        {
            this.plantaService = plantaService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Planta>> Get()
        {
            return Ok(
                plantaService.FindAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Planta> Get(int id)
        {
            return Ok(
                plantaService.FindById(id)
            );
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Planta planta)
        {
            return Ok(
            plantaService.Save(planta)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public ActionResult Put([FromBody] Planta planta)
        {
            return Ok(
            plantaService.Update(planta)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
            plantaService.Delete(id)
            );
        }
    }
}