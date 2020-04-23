using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Labb3Mvc2.Models;
using Labb3Mvc2.VIewModels;

namespace Labb3Mvc2.Controllers
{
    public class CarController : Controller
    {
        private readonly CarShopDbContext _context;
             
        public CarController(CarShopDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            var model = _context.Cars.Select(x => new CarViewModel { ID = x.Id, Manufacturer = x.Manufacturer, Model = x.Model }).ToList();
            return View(model);
        }

        public IActionResult New()
        {
            var viewmodel = new NewCarViewModel();
            
            return View(viewmodel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public IActionResult New(NewCarViewModel viewModel)
        {
            var car = new Car();
            car.Manufacturer = viewModel.Manufacturer;
            car.Model = viewModel.Model;
            car.Price = viewModel.Price;
            car.Seats = viewModel.Seats;
            car.Year = viewModel.Year;

            _context.Cars.Add(car);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var model = _context.Cars.FirstOrDefault(x => x.Id == id);
            var viewModel = new EditCarViewModel
            {
                Id = model.Id,
                Manufacturer = model.Manufacturer,
                Model = model.Model,
                Seats = model.Seats,
                Price = model.Price,
                Year = model.Year
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(EditCarViewModel viewModel)
        {
            var p = _context.Cars.FirstOrDefault(x => x.Id == viewModel.Id);

            p.Manufacturer = viewModel.Manufacturer;
            p.Model = viewModel.Model;
            p.Price = viewModel.Price;
            p.Seats = viewModel.Seats;
            p.Year = viewModel.Year;

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}