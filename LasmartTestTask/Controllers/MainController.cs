using LasmartTestTask.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LasmartTestTask.Controllers
{
    public class MainController : Controller
    {

        private readonly IPointRepository pointRepository;
        public MainController(IPointRepository pointRepository)
        {
            this.pointRepository = pointRepository;
        }
  
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<JsonResult> GetAllPoints()
        {

            var points = await pointRepository.GetAllPoints();
            return new JsonResult(Ok(points));
        }

        [HttpDelete]
        public async Task<IActionResult> RemovePoint(int id)
        {

            await pointRepository.RemovePoint(id);
            return Ok(StatusCode(200));
        }
    }
}
