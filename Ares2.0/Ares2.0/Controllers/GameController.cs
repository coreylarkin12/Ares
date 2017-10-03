using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ares.Controllers
{
    public class GameController : Controller
    {
        private const int DefaultGridSize = 10;

        // GET: Game/Index?gridSize={int}
        public IActionResult Game(int? gridSize)
        {
            // If the user didn't provide a gridSize (? makes it nullable)
            // or they gave a value greater than 50 then just set it to 10
            // by default.
            if (!gridSize.HasValue || gridSize.Value > 50)
            {
                gridSize = DefaultGridSize;
            }

            return View(gridSize.Value);
        }
    }
}