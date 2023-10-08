using Microsoft.AspNetCore.Mvc;
using SMWebApp.Data;
using SMWebApp.Models;
using System.Reflection.Metadata.Ecma335;

namespace SMWebApp.Controllers
{
    public class PacienteController : Controller
    {
        private readonly SMWebDBContext _dbContext;

        public PacienteController(SMWebDBContext db)
        {
            _dbContext = db;
        }

        public IActionResult Index()
        {

            IEnumerable<Paciente> objPacientesList = _dbContext.Pacientes;
            return View(objPacientesList);
        }

        //GET
        public IActionResult CadastrarPaciente()
        {

            return View();
        }

        public IActionResult EditarPaciente(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var pacienteCarregado = _dbContext.Pacientes.Find(id);

            if (pacienteCarregado == null)
            {
                return NotFound();
            }

            return View(pacienteCarregado);
        }

        public IActionResult ExcluirPacienteGET(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var pacienteCarregado = _dbContext.Pacientes.Find(id);

            if (pacienteCarregado == null)
            {
                return NotFound();
            }

            return View(pacienteCarregado);
        }


        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CadastrarPaciente(Paciente obj)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Pacientes.Add(obj);
                _dbContext.SaveChanges();
                TempData["success"] = "Cadastrado com sucesso!";
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarPaciente(Paciente obj)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Pacientes.Update(obj);
                _dbContext.SaveChanges();
                TempData["success"] = "Salvo com sucesso!";
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ExcluirPaciente(int? id)
        {
            var obj = _dbContext.Pacientes.Find(id);

            if(obj == null)
            {
                return NotFound();
            }

            _dbContext.Pacientes.Remove(obj);
            _dbContext.SaveChanges();
            TempData["success"] = "Deletado com sucesso!";
            return RedirectToAction("Index");         

        }
    }
}
