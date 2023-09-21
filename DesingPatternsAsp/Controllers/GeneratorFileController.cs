using DesignPatterns.Repository;
using DesingPatternsAsp.Strategies;
using Microsoft.AspNetCore.Mvc;
using Tools.Generator;

namespace DesingPatternsAsp.Controllers
{
    public class GeneratorFileController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private GeneratorConcreteBuilder _builder;

        public GeneratorFileController(IUnitOfWork unitOfWork,GeneratorConcreteBuilder builder)
        {
            _unitOfWork = unitOfWork;
            _builder = builder;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateFile(int option)
        {
            try
            {

                var beers = _unitOfWork.Beers.Get();
                List<string> content = beers.Select(d=>d.Name).ToList();
                string path = "file" + DateTime.Now.Ticks + new Random().Next(1000) + ".txt";
                var generatorDirec = new GeneratorDirector(_builder);

                if (option == 1)
                    generatorDirec.CreateSimpleJsonGenerator(content, path);
                else
                    generatorDirec.CreateSimplePipeGenerator(content, path);

                var generator=_builder.GetGenerator();
                generator.Save();
                return Json("Archivo Generado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

    }
}
