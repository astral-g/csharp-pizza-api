using GfPizza.Models;
using GfPizza.Services;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System;

namespace GfPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    public OrderController() {

    }

    [HttpPost]
    public IActionResult Order([Optional]Pizza pizza, [Optional]CustomPizza customPizza) 
    {
        if(customPizza is not null) {
            PizzaService.Order(true, customPizza);
            return CreatedAtAction(nameof(Order), new { customId = customPizza.CustomId }, customPizza);
        }

        PizzaService.Order(false, pizza);
        return CreatedAtAction(nameof(Order), new { id = pizza.Id }, pizza);
    }
}