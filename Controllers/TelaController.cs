using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTelas.Context;

namespace ApiTelas.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TelaController : ControllerBase
    {
        private readonly AppDbContext context;
        public TelaController(AppDbContext _context)
        {
            this.context = _context;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(context.tela.ToList());
        }
    }
}
