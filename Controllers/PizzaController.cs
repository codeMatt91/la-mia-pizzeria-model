using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            Pizza Margherita = new Pizza("Margherita","Ingredienti: Mozzarella, Pomodoro e Basilico",6.50,"img/margherita.jpg");
            Pizza Boscaiola = new Pizza("Boscaiola", "Ingredienti: Mozzarella, Salsiccia e Funghi", 7.50, "img/boscaiola.jpg");
            Pizza Bufala = new Pizza("Bufala", "Ingredienti: Mozzarella di bufala, Pomodoro e Basilico", 7.50, "img/bufala.jpg");
            Pizza Formaggi = new Pizza("Formaggi", "Ingredienti: Mozzarella, Gorgonzola, Fontina e Taleggio", 9.00, "img/formaggi.webp");
            Pizza Salame = new Pizza("Salame", "Ingredienti: Mozzarella, pomodoro e Salame piccante", 8.50, "img/salame.jpg");
            Pizza Funghi = new Pizza("Funghi", "Ingredienti: Mozzarella, pomodoro e Funghi", 7.00, "img/funghi.jpg");

            listaPizze pizze = new listaPizze();
            pizze.pizze.Add(Margherita);
            pizze.pizze.Add(Boscaiola);
            pizze.pizze.Add(Bufala);
            pizze.pizze.Add(Formaggi);
            pizze.pizze.Add(Salame);
            pizze.pizze.Add(Funghi);

            return View(pizze);
        }
    }
}
