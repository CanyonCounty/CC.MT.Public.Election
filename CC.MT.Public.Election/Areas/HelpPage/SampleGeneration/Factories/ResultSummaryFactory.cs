using CC.MT.Public.Election.Classes;

namespace CC.MT.Public.Election.Areas.HelpPage.SampleGeneration.Factories
{
  /// <summary>
  /// This creates the sample data for documentation
  /// </summary>
  public static class ResultSummaryFactory
  {
    /// <summary>
    /// This just returns some dummy data for the help pages
    /// </summary>
    /// <returns>Dummy ResultSummary data</returns>
    public static ResultSummary GetResultSummarySample()
    {
      ResultSummary sum = new ResultSummary()
      {
        LastUpdated = "2/18/2015 9:29:00 AM",
        TotalVoters = "29,766",
        BallotsCounted = "0",
        VoterTurnout = "",
        PrecinctsComplete = "0 out of 34",
        ElectionName = "2015 March Consolidated Election",
        ElectionDate = "03/10/2015",
        ResultTime = "03/10/2015  9:00 PM"
      };

      return sum;
    }
  }
}