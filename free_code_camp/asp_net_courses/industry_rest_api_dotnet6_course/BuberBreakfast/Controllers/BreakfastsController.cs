using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BuberBreakfast.Contracts.Breakfast;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BuberBreakfast.Controllers;

[ApiController]
public class BreakfastsController : Controller
{
    [HttpPost("/breakfasts")]
    public IActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpGet("/breakfasts/{id:guid}")]
    public IActionResult GetBreakfast(Guid id)
    {
        return Ok(id);
    }

    [HttpPut("/breakfasts/{id:guid}")]
    public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
    {
        return Ok(request);
    }

    [HttpDelete("/breakfasts/{id:guid}")]
    public IActionResult DeleteBreakfast(Guid id)
    {
        return Ok(id);
    }
}
