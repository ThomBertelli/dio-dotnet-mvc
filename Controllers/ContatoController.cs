using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC.Context;
using MVC.Models;

namespace MVC.Controllers
{
    public class ContatoController : Controller
    {

        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var contatos = _context.Contatos.ToList();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato contato)
        {
            if (ModelState.IsValid)
            {
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        public IActionResult Editar(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato == null)
            {
                return NotFound();
            }
            return View(contato);
        }

        [HttpPost]
        public IActionResult Editar(int id, Contato contato)
        {
            if (id != contato.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Contatos.Update(contato);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }

        public IActionResult Deletar(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato == null)
            {
                return NotFound();
            }
            return View(contato);
        }


        [HttpPost]
        public IActionResult Deletar(Contato contato)
        {
            var contatoBanco = _context.Contatos.Find(contato.Id);
            if (contato == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contatoBanco);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detalhes(int id)
        {
            var contato = _context.Contatos.Find(id);
            if (contato == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }
        

    }
}