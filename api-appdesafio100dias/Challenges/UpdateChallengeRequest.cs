namespace api_appdesafio100dias.Challenges
{
    public record UpdateChallengeRequest(string Title, string Description, DateTime StartDate, bool Completed);
   
}
