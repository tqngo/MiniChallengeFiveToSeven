using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven.Services.ReverseAlphanumeric;

namespace MiniChallengeFiveToSeven.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReverseAlphanumericController : ControllerBase
{
    private readonly IReverseAlphanumericService _reverseAlphanumericService;

    public ReverseAlphanumericController(IReverseAlphanumericService reverseAlphanumericService)
    {
        _reverseAlphanumericService = reverseAlphanumericService;
    }

    [HttpGet]
    [Route("backwards/{backwards}")]

    public string ReversedWord(string backwards)
    {
        return _reverseAlphanumericService.ReversedWord(backwards);
    }

}
