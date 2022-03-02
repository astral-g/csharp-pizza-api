using GfPizza.Models;
using System.Runtime.InteropServices;

namespace GfPizza.Services;

public static class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static List <CustomPizza> CustomPizzas { get; set; }
    static List <Pizza> OrderQueue { get; set; }
    static int nextId = 3;
    static int nextCustomId = 1;
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Vegan", IsGlutenFree = true }
        };

        CustomPizzas = new List<CustomPizza> {};

        OrderQueue = new List<Pizza> {
            new CustomPizza {}
        };
    }

    public static List<Pizza> GetAll() => Pizzas;

    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    public static void Add(Pizza pizza)
        {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }

        public static void Delete(int id)
        {
            var pizza = Get(id);
            if(pizza is null)
                return;

            Pizzas.Remove(pizza);
        }

        public static void Update(Pizza pizza)
        {
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
            if(index == -1)
                return;

            Pizzas[index] = pizza;
        }

    public static void Order(bool isCustom, [Optional]Pizza pizza, [Optional]CustomPizza customPizza)
    {
        if(isCustom is true) {
            OrderQueue.Add(customPizza);
        }

        OrderQueue.Add(pizza);
    }
}