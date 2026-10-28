using FirstResponsiveWebAppMead.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppMead.Controllers
{
    public class TicketsController : Controller
    {
        private static List<Ticket> tickets = new();
        private static int nextId = 1;

        public IActionResult Index()
        {
            return View(tickets);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                ticket.Id = nextId++;
                tickets.Add(ticket);
                return RedirectToAction("Index");
            }

            return View(ticket);
        }

        public IActionResult Edit(int id)
        {
            var ticket = tickets.FirstOrDefault(t => t.Id == id);

            if (ticket == null)
                return NotFound();

            return View(ticket);
        }

        [HttpPost]
        public IActionResult Edit(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                var existingTicket = tickets.FirstOrDefault(t => t.Id == ticket.Id);

                if (existingTicket == null)
                    return NotFound();

                existingTicket.Name = ticket.Name;
                existingTicket.Description = ticket.Description;
                existingTicket.SprintNumber = ticket.SprintNumber;
                existingTicket.PointValue = ticket.PointValue;
                existingTicket.Status = ticket.Status;

                return RedirectToAction("Index");
            }

            return View(ticket);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var ticket = tickets.FirstOrDefault(t => t.Id == id);

            if (ticket != null)
                tickets.Remove(ticket);

            return RedirectToAction("Index");
        }
    }
}
