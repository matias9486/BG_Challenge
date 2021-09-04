using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Challenge.Data;
using Challenge.Models;

namespace Challenge.Controllers
{
    public class VehiculosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VehiculosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Vehiculos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vehiculos.ToListAsync());
        }

        
        // GET: Vehiculos/Create
        public IActionResult Create()
        {
            
            ViewBag.Marcas = getMarcas();
            return View();
        }

        //Metodo creado para crear una lista de marcas y luego mostrarlas en la vista
        public List<string> getMarcas()
        {
            List<string> marcas = new List<string>();
            marcas.Add("Audi");
            marcas.Add("Chevrolet");
            marcas.Add("Fiat");
            marcas.Add("Ford");
            marcas.Add("Peugeot");

            return marcas;
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Patente,Marca,Modelo,Puertas,Titular")] Vehiculo vehiculo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehiculo);
                await _context.SaveChangesAsync();

                TempData["Mensaje"] = "Se agregó vehículo con éxito.";
                return RedirectToAction(nameof(Index));
            }
            return View(vehiculo);
        }

        
    }
}
