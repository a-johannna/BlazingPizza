namespace BlazingPizza.Server;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var toppings = new Topping[]
        {
            new Topping()
            {
                    Name = "Chocolate líquido",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Caramelo derretido",
                    Price = 0.90m,
            },
            new Topping()
            {
                    Name = "Galletas de Oreo trituradas",
                    Price = 1.10m,
            },
            new Topping()
            {
                    Name = "Trozos de brownie",
                    Price = 2.60m,
            },
            new Topping()
            {
                    Name = "M&M's",
                    Price = 1.25m,
            },
            new Topping()
            {
                    Name = "Malvaviscos pequeños",
                    Price = 4.50m,
            },
            new Topping()
            {
                    Name = "Mango en cubitos",
                    Price = 1.10m,
            },
            new Topping()
            {
                    Name = "Piña picada",
                    Price = 0.99m,
            },
            new Topping()
            {
                    Name = "Pistachos picados",
                    Price = 1.15m,
            },
            new Topping()
            {
                    Name = "Chispas de menta",
                    Price = 0.75m,
            },
            new Topping()
            {
                    Name = "Ron con pasas",
                    Price = 1.95m,
            },
            new Topping()
            {
                    Name = "Licor de café",
                    Price = 2.50m,
            },
          
        };

        var specials = new PizzaSpecial[]
            {   
            new PizzaSpecial()
            {
                    Name = "Tres Mosqueteros Helados",
                    Description = "Se perdieron por el horizonte y volvieron HELADOS",
                    BasePrice = 3.75m,
                    ImageUrl = "img/pizzas/cheese.jpg",
            },
                   new PizzaSpecial()
            {
                    Id = 2,
                    Name = "Más de uno son multitud",
                    Description = "Siempre en COMPAÑIA nunca solo",
                    BasePrice = 7.35m,
                    ImageUrl = "img/pizzas/bacon.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 3,
                    Name = "Helado solitario Constructivista",
                    Description = "Solo hay uno, pero sin uno",
                    BasePrice = 2.60m,
                    ImageUrl = "img/pizzas/pepperoni.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 4,
                    Name = "Un par y otro par más",
                    Description = "Por falta de una, dos",
                    BasePrice = 4.50m,
                    ImageUrl = "img/pizzas/meaty.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 5,
                    Name = "Amantes de lo seguro",
                    Description = "Sino quieres en cono te lo damos en tarrina",
                    BasePrice = 2.50m,
                    ImageUrl = "img/pizzas/mushroom.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 6,
                    Name = "Cuatrillizos",
                    Description = "Ideal para hermanos",
                    BasePrice = 4.90m,
                    ImageUrl = "img/pizzas/brit.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 7,
                    Name = "Grupos grandes, grandes soluciones",
                    Description = "Te ofrecemos un DESCUENTO sin son más de 5",
                    BasePrice = 13.25m,
                    ImageUrl = "img/pizzas/salad.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 8,
                    Name = "Sabores que enamoran",
                    Description = "Nustros helados TRADICIONALES en varios sabores",
                    BasePrice = 4.75m,
                    ImageUrl = "img/pizzas/margherita.jpg",
            },
        };

        db.Toppings.AddRange(toppings);
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}