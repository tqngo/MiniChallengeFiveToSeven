using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven.Services.OddOrEven;

namespace MiniChallengeFiveToSeven.Controllers;

[ApiController]
[Route("[controller]")]

public class OddOrEvenController : ControllerBase
{
    private readonly IOddOrEvenService _oddOrEvenService;

    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }

    [HttpGet]
    [Route("num/{num}")]
    public string Numerals(string num)
    {
        return _oddOrEvenService.Numerals(num);
    }
}
