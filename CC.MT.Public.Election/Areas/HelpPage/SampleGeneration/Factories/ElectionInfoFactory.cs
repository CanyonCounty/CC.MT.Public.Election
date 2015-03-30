using CC.MT.Public.Election.Classes;

namespace CC.MT.Public.Election.Areas.HelpPage.SampleGeneration.Factories
{
  /// <summary>
  /// This creates the sample data for documentation
  /// </summary>
  public static class ElectionInfoFactory
  {
    /// <summary>
    /// This just returns some dummy data for the help pages
    /// </summary>
    /// <returns>Dummy ElectionInfo data</returns>
    public static ElectionInfo GetElectionInfoSample()
    {
      ElectionInfo info = new ElectionInfo
      {
        ElectionCountdown = "Tomorrow",
        ElectionDate = "03/10/2015",
        ElectionName = "2015 March Consolidated Election",
        ElectionTypeName = "Consolidated (March)",
      };
      return info;
    }
  }
}