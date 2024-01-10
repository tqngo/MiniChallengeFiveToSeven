using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven.Services.ReversedNumber;

namespace MiniChallengeFiveToSeven.Controllers;

[ApiController]
[Route("[controller]")]
public class ReversedNumberController : ControllerBase
{
    private readonly IReversedNumberService _reversedNumberService;

    public ReversedNumberController(IReversedNumberService reversedNumberService)
    {
        _reversedNumberService = reversedNumberService;
    }

    [HttpGet]
    [Route("Numbahs/{numbahs}")]

    public string Reversal(string numbahs)
    {
        return _reversedNumberService.Reversal(numbahs);
    }
}
