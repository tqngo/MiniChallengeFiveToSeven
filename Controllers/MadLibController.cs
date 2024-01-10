using Microsoft.AspNetCore.Mvc;
using MiniChallengeFiveToSeven.Services;

namespace MiniChallengeFiveToSeven.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    private readonly IMadLibService _madLibService;

    public MadLibController(IMadLibService madLibService)
    {
        _madLibService = madLibService;
    }

    [HttpGet]
    [Route("{location}/{adjective_1}/{actionVerb}/{verb}/{bodyPart}/{object_1}/{celebrity}/{adVerb}/{adjective_2}/{celebrity_2}")]
    public string StoryBuilder(string location, string adjective_1, string actionVerb, string verb, string bodyPart, string object_1, string celebrity, string adVerb, string adjective_2, string celebrity_2) 
    {
        return _madLibService.StoryBuilder(location, adjective_1, actionVerb, verb, bodyPart, object_1, celebrity, adVerb, adjective_2, celebrity_2);
    }
}
