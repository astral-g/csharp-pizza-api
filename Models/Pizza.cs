namespace GfPizza.Models;

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }
}

public class CustomPizza : Pizza
{
    public int CustomId { get; set; }
    public string? Toppings { get; set; }
    public string? Base { get; set; }
    public string? Sauce { get; set; }
}