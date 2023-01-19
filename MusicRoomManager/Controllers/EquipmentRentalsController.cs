using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicRoomManager.Data;
using MusicRoomManager.Models;

namespace MusicRoomManager.Controllers
{
    [Authorize]
    public class EquipmentRentalsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EquipmentRentalsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: EquipmentRentals
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.EquipmentRentals.Include(e => e.Customer).Include(e => e.Equipment).Include(e => e.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: EquipmentRentals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EquipmentRentals == null)
            {
                return NotFound();
            }

            var equipmentRental = await _context.EquipmentRentals
                .Include(e => e.Customer)
                        .ThenInclude(e => e.State)
                .Include(e => e.Equipment)
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipmentRental == null)
            {
                return NotFound();
            }

            return View(equipmentRental);
        }

        private async Task UpdateStateAndResetModelState(EquipmentRental er)
        {
            ModelState.Clear();
            var customer = _context.Customers.SingleOrDefault(x => x.Id == er.CustomerId);
            var equipment = _context.Equipment.SingleOrDefault(x => x.Id == er.EquipmentId);
            var state = _context.States.SingleOrDefault(x => x.Id == customer.StateId);
            var user = _context.Users.SingleOrDefault(x => x.Id == er.UserId);
            customer.State = state;

            er.Customer = customer;
            er.Equipment = equipment;
            er.User = user;
            TryValidateModel(er);
        }

        // GET: EquipmentRentals/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FriendlyName");
            ViewData["EquipmentId"] = new SelectList(_context.Equipment.Where(x => x.IsAvailable), "Id", "FriendlyName");
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "FriendlyName");
            return View();
        }

        // POST: EquipmentRentals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RentalDate,UserId,Equipment, EquipmentId,Customer, CustomerId")] EquipmentRental equipmentRental)
        {
            UpdateStateAndResetModelState(equipmentRental);
            if (ModelState.IsValid)
            {
                _context.Add(equipmentRental);

                // change equipment availability to false
                var eq = _context.Equipment.SingleOrDefault(x => x.Id == equipmentRental.EquipmentId);
                eq.IsAvailable = false;
                await _context.SaveChangesAsync();
                TempData["success"] = "Equipment rented successfully!";

                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FriendlyName", equipmentRental.CustomerId);
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "Id", "FriendlyName", equipmentRental.EquipmentId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "FriendlyName", equipmentRental.UserId);
            return View(equipmentRental);
        }

        // GET: EquipmentRentals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EquipmentRentals == null)
            {
                return NotFound();
            }

            var equipmentRental = await _context.EquipmentRentals.FindAsync(id);
            if (equipmentRental == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FriendlyName", equipmentRental.CustomerId);
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "Id", "FriendlyName", equipmentRental.EquipmentId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "FriendlyName", equipmentRental.UserId);
            return View(equipmentRental);
        }

        // POST: EquipmentRentals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RentalDate,UserId,EquipmentId,CustomerId")] EquipmentRental equipmentRental)
        {
            if (id != equipmentRental.Id)
            {
                return NotFound();
            }

            UpdateStateAndResetModelState(equipmentRental);
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipmentRental);
                    TempData["success"] = "Rental modified successfully!";
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipmentRentalExists(equipmentRental.Id))
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
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "FriendlyName", equipmentRental.CustomerId);
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "Id", "FriendlyName", equipmentRental.EquipmentId);
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "FriendlyName", equipmentRental.UserId);
            return View(equipmentRental);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Return(int id, EquipmentRental equipmentRental)
        {
            equipmentRental = await _context.EquipmentRentals.FindAsync(id);

            equipmentRental.CheckedInDate = DateTime.Now;

            var equipment = await _context.Equipment.SingleOrDefaultAsync(x => x.Id == equipmentRental.EquipmentId);
            equipment.IsAvailable = true;

            await _context.SaveChangesAsync();
            TempData["success"] = "Rental returned successfully!";
            return RedirectToAction(nameof(Index));
        }

        // GET: EquipmentRentals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EquipmentRentals == null)
            {
                return NotFound();
            }

            var equipmentRental = await _context.EquipmentRentals
                .Include(e => e.Customer)
                .Include(e => e.Equipment)
                .Include(e => e.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipmentRental == null)
            {
                return NotFound();
            }

            return View(equipmentRental);
        }

        // POST: EquipmentRentals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EquipmentRentals == null)
            {
                return Problem("Entity set 'ApplicationDbContext.EquipmentRentals'  is null.");
            }
            var equipmentRental = await _context.EquipmentRentals.FindAsync(id);
            if (equipmentRental != null)
            {
                _context.EquipmentRentals.Remove(equipmentRental);
            }

            await _context.SaveChangesAsync();
            TempData["success"] = "Rental deleted successfully!";
            return RedirectToAction(nameof(Index));
        }

        private bool EquipmentRentalExists(int id)
        {
            return _context.EquipmentRentals.Any(e => e.Id == id);
        }
    }
}
