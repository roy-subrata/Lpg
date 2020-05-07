using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lpg.Data.Entity;
using Lpg.Data.Enty;
using AutoMapper;
using Lpg.App.Models;

namespace Lpg.App.Controllers
{
    public class CylinderController : Controller
    {
        private readonly IMapper _mapper;
        private readonly LpgDbContext _context;

        public CylinderController(LpgDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }


        public IActionResult List(string brandSearch, string sizeSearch, int? gasWeightSearch, int? pageNumber)
        {
            int pageSize = 10;
            var cylinders = from s in _context.Cylinder
                            select s;
            if (!string.IsNullOrEmpty(brandSearch) )
                cylinders = cylinders.Where(f => f.Brand.Contains(brandSearch));
            if (!string.IsNullOrEmpty(sizeSearch))
                cylinders = cylinders.Where(f => f.Size.Contains(sizeSearch));
            if (gasWeightSearch >= 1)
                cylinders = cylinders.Where(f => f.GasWeight==gasWeightSearch);

            var brands = _context.Cylinder.Select(s => new { Brand=s.Brand}).Distinct();
            var sizes = _context.Cylinder.Select(s => new { Size = s.Size}).Distinct();
            var GasWeights = _context.Cylinder.Select(s => new { GasWeight = s.GasWeight}).Distinct();

            ViewBag.searchParam= new { brand=brandSearch,size=sizeSearch,gasWeight=gasWeightSearch };
            ViewData["BrandList"] = new SelectList(brands, "Brand","Brand" );
            ViewData["SizeList"] = new SelectList(sizes, "Size", "Size");
            ViewData["GasWeightList"] = new SelectList(GasWeights, "GasWeight", "GasWeight");


            return View(PaginatedList<CylinderViewModel>.Create(_mapper.Map<List<CylinderViewModel>>(cylinders.ToList()), pageNumber ?? 1, pageSize));

       
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cylinder = await _context.Cylinder
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cylinder == null)
            {
                return NotFound();
            }

            return View(_mapper.Map<CylinderViewModel>(cylinder));
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Size,Color,GasWeight,CylinderWeight,TotalWeight,Brand,Id")] CylinderViewModel cylinder)
        {
            if (ModelState.IsValid)
            {
                var newClylinder = _mapper.Map<Cylinder>(cylinder);
                _context.Add(newClylinder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(cylinder);
        }

  
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cylinder = await _context.Cylinder.FindAsync(id);
            if (cylinder == null)
            {
                return NotFound();
            }
            return View(_mapper.Map<CylinderViewModel>(cylinder));
        }

   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Size,Color,CylinderWeight,GasWeight,TotalWeight,Brand,Id")] CylinderViewModel cylinder)
        {
            if (id != cylinder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                  var updateClylinder=  _mapper.Map<Cylinder>(cylinder);
                    _context.Update(updateClylinder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CylinderExists(cylinder.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(List));
            }
            return View(_mapper.Map<CylinderViewModel>(cylinder));
        }

    
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cylinder = await _context.Cylinder
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cylinder == null)
            {
                return NotFound();
            }

            return View(_mapper.Map<CylinderViewModel>(cylinder));
        }

        // POST: Clylinder/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cylinder = await _context.Cylinder.FindAsync(id);
            _context.Cylinder.Remove(cylinder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(List));
        }

        private bool CylinderExists(int id)
        {
            return _context.Cylinder.Any(e => e.Id == id);
        }
    }
}
