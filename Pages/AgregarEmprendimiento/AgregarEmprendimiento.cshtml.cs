using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ComprandoNicaragua.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography.X509Certificates;

namespace ComprandoNicaragua.Pages.AgregarEmprendimiento
{
    public class AgregarEmprendimientoModel : PageModel
    {

        private readonly AppDbContext _db;

        public AgregarEmprendimientoModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Tiendas Tiendas { get; set; }
        public void OnGet()
        {
            LlenarCategorias();
        }

        public async Task<IActionResult> OnPost()
        {

            if (ModelState.IsValid)
            {
                //Ponemos por defecto el estado aprobado 0,y estado 1
                Tiendas.Estado = true;
                Tiendas.Aprobado = false;
                //Concatenamos el @ de la cuenta
                Tiendas.CuentaInstagram = "@" + Tiendas.CuentaInstagram;

                await _db.Tiendas.AddAsync(Tiendas);
                await _db.SaveChangesAsync();
                return RedirectToPage("AgregarEmprendimiento");
            }
            else
            {
                LlenarCategorias();
                return Page();
                
            }

        }


        //Metodos de datos
        public SelectList CatCategorias { get; set; }

        private void LlenarCategorias()
        {
            var Categorias = _db.CatCategorias.Where(x=>x.Estado==true).ToList();

            CatCategorias= new SelectList(Categorias, "Id", "Categoria");
        }
    }
}