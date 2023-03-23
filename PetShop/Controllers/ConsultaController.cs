using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PetShop.Data;
using PetShop.Models;

namespace PetShop.Controllers
{
    public class ConsultaController : Controller
    {
        private readonly PetShopDbContext _context;

        public ConsultaController(PetShopDbContext context)
        {
            _context = context;
        }

        // GET: Consulta
        public async Task<IActionResult> Index()
        {
              return _context.Consultas != null ? 
                          View(await _context.Consultas.ToListAsync()) :
                          Problem("Entity set 'PetShopDbContext.Consultas'  is null.");
        }

        // GET: Consulta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Consultas == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // GET: Consulta/Create
        public IActionResult Create()
        {
            List<Cliente> clientes = _context.Clientes.AsNoTracking().ToList();
            List<SelectListItem> selectListClientes = clientes.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Nome
            }).ToList();
            ViewBag.Cliente = selectListClientes;

            List<Estoque> Estoque = _context.Estoques.AsNoTracking().ToList();
            List<SelectListItem> selectListEstoque = Estoque.Select(e => new SelectListItem
            {
                Value = e.Id.ToString(),
                Text = e.Nome
            }).ToList();
            ViewBag.Estoque = selectListEstoque;

            List<Funcionario> Funcionario = _context.Funcionarios.AsNoTracking().ToList();
            List<SelectListItem> selectListFuncionario = Funcionario.Select(f => new SelectListItem
            {
                Value = f.Id.ToString(),
                Text = f.Nome
            }).ToList();
            ViewBag.Funcionario = selectListFuncionario;
            return View();
        }

        // POST: Consulta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       public async Task<IActionResult> Create([Bind("Id,Valor,Atividade,Data,Clientes,Funcionarios,Estoques")] Consulta consulta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consulta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(consulta);
        }

        // GET: Consulta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Consultas == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta == null)
            {
                return NotFound();
            }
            return View(consulta);
        }

        // POST: Consulta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Valor,Atividade,Data")] Consulta consulta)
        {
            if (id != consulta.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consulta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsultaExists(consulta.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(consulta);
        }

        // GET: Consulta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Consultas == null)
            {
                return NotFound();
            }

            var consulta = await _context.Consultas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (consulta == null)
            {
                return NotFound();
            }

            return View(consulta);
        }

        // POST: Consulta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Consultas == null)
            {
                return Problem("Entity set 'PetShopDbContext.Consultas'  is null.");
            }
            var consulta = await _context.Consultas.FindAsync(id);
            if (consulta != null)
            {
                _context.Consultas.Remove(consulta);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsultaExists(int id)
        {
          return (_context.Consultas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
