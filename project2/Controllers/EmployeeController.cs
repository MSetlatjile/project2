using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using project2.Interfaces;
using project2.Models;

namespace project2.Controllers
{
    public class EmployeeController : Controller
    {
        private IGenericRepository<Employee> _context;

        public EmployeeController(IGenericRepository<Employee> context)
        {
            _context = context;
        }

        // GET: Employee
        public IActionResult Index()
        {
            return View(_context.GetAll());
        }

        // GET: Employee/Details/5
        [Route("Employee/Details/{EmployeeNumber}")]
        public IActionResult Details(int EmployeeNumber)
        {
            if (!EmployeeExists(EmployeeNumber))
            {
                return NotFound();
            }

            Employee employee = _context.GetByEmployeeNumber(EmployeeNumber);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("EmployeeNumber,Age,Gender,Over18,MaritalStatus,EmployeeCount,Attrition,WorkLifeBalance,RelationshipSatisfaction,PerformanceRating,DistanceFromHome,BusinessTravel")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Insert(employee);
                _context.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employee/Edit/5
        [Route("Employee/Edit/{EmployeeNumber}")]
        public IActionResult Edit(int EmployeeNumber)
        {

            Employee employee =  _context.GetByEmployeeNumber(EmployeeNumber);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int EmployeeNumber, [Bind("EmployeeNumber,Age,Gender,Over18,MaritalStatus,EmployeeCount,Attrition,WorkLifeBalance,RelationshipSatisfaction,PerformanceRating,DistanceFromHome,BusinessTravel")] Employee employee)
        {
            if (EmployeeNumber != employee.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    _context.Save();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeNumber))
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
            return View(employee);
        }

        // GET: Employee/Delete/5
        [Route("Employee/Delete/{EmployeeNumber}")]
        public IActionResult Delete(int EmployeeNumber)
        {

            var employee = _context.GetByEmployeeNumber(EmployeeNumber);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int EmployeeNumber)
        {
            _context.Delete(EmployeeNumber);
            _context.Save();
            return RedirectToAction(nameof(EmployeeNumber));
        }

        private bool EmployeeExists(int EmployeeNumber)
        {
            return _context.Exists(EmployeeNumber);
        }
    }
}
