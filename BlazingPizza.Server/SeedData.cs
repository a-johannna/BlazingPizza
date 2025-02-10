namespace BlazingPizza.Server;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var toppings = new Topping[]
        {
            new Topping()
            {
                    Name = "Extra cheese",
                    Price = 2.50m,
            },
            new Topping()
            {
                    Name = "American bacon",
                    Price = 2.99m,
            },
            new Topping()
            {
                    Name = "British bacon",
                    Price = 2.99m,
            },
            new Topping()
            {
                    Name = "Canadian bacon",
                    Price = 2.99m,
            },
            new Topping()
            {
                    Name = "Tea and crumpets",
                    Price = 5.00m
            },
            new Topping()
            {
                    Name = "Fresh-baked scones",
                    Price = 4.50m,
            },
            new Topping()
            {
                    Name = "Bell peppers",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Onions",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Mushrooms",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Pepperoni",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Duck sausage",
                    Price = 3.20m,
            },
            new Topping()
            {
                    Name = "Venison meatballs",
                    Price = 2.50m,
            },
            new Topping()
            {
                    Name = "Served on a silver platter",
                    Price = 250.99m,
            },
            new Topping()
            {
                    Name = "Lobster on top",
                    Price = 64.50m,
            },
            new Topping()
            {
                    Name = "Sturgeon caviar",
                    Price = 101.75m,
            },
            new Topping()
            {
                    Name = "Artichoke hearts",
                    Price = 3.40m,
            },
            new Topping()
            {
                    Name = "Fresh tomatoes",
                    Price = 1.50m,
            },
            new Topping()
            {
                    Name = "Basil",
                    Price = 1.50m,
            },
            new Topping()
            {
                    Name = "Steak (medium-rare)",
                    Price = 8.50m,
            },
            new Topping()
            {
                    Name = "Blazing hot peppers",
                    Price = 4.20m,
            },
            new Topping()
            {
                    Name = "Buffalo chicken",
                    Price = 5.00m,
            },
            new Topping()
            {
                    Name = "Blue cheese",
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