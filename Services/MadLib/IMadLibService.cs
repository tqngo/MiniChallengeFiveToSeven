namespace MiniChallengeFiveToSeven.Services;

public interface IMadLibService
    {
        string StoryBuilder(string location, string adjective_1, string actionVerb, string verb, string bodyPart, string object_1, string celebrity, string adVerb, string adjective_2, string celebrity_2);
    }
