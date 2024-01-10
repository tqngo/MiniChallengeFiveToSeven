namespace MiniChallengeFiveToSeven.Services.MadLib
{
    public class MadLibService : IMadLibService
    {
        public string StoryBuilder(string location, string adjective_1, string actionVerb, string verb, string bodyPart, string object_1, string celebrity, string adVerb, string adjective_2, string celebrity_2)
        {
            return $"One day while walking down the street of {location}, you come across a(n) {adjective_1} {object_1}. All of a sudden {celebrity} rushes towards you and screams, 'Grab that, we have to go right now!' You hear a loud crash and footsteps running behind you. {adjective_2}, you follow their instructions. You're {actionVerb} while trying to catch up and make sense of whats going on. 'Hurry hurry! We have to make it there on time! Grab my {bodyPart}, we need to skiddadle!' From the corner of your eye, you see {celebrity_2} {adVerb} {verb} a chocobo in front of you. You wake up from your dream.";
        }
    }
}