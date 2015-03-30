using CC.MT.Public.Election.Classes;

namespace CC.MT.Public.Election.Areas.HelpPage.SampleGeneration.Factories
{
  /// <summary>
  /// This creates the sample data for documentation
  /// </summary>
  public static class PrecinctInfoListFactory
  {
    /// <summary>
    /// This just returns some dummy data for the help pages
    /// </summary>
    /// <returns>Dummy PrecinctInfoList data</returns>
    public static PrecinctInfoList GetPrecinctInfoListSample()
    {
      PrecinctInfo info32 = new PrecinctInfo
      {
        DisplayAddress =
          "VALLIVUE LIONS CLUBHOUSE 15047 RIVERSIDE RD CORNER OF RIVERSIDE RD & HOADLEY RD CALDWELL, ID 83607",
        Address = "15047 RIVERSIDE RD CALDWELL, ID 83607",
        PollingPlaceName = "VALLIVUE LIONS CLUBHOUSE",
        LocationName = "15047 RIVERSIDE RD",
        LocationDesc = "CORNER OF RIVERSIDE RD & HOADLEY RD",
        CityStateZip = "CALDWELL, ID 8360",
        PrecinctNo = "32-11",
        Latitude = 43.588787m,
        Longitude = -116.728875m
      };

      PrecinctInfo info42 = new PrecinctInfo
      {
        DisplayAddress = "LDS CHURCH 22500 LANSING LANE MIDDLETON, ID 83644",
        Address = "22500 LANSING LANE MIDDLETON, ID 83644",
        PollingPlaceName = "LDS CHURCH",
        LocationName = "22500 LANSING LANE",
        LocationDesc = "",
        CityStateZip = "MIDDLETON, ID 83644",
        PrecinctNo = "42-11",
        Latitude = 43.699215m,
        Longitude = -116.572299m
      };

      PrecinctInfo info69 = new PrecinctInfo
      {
        DisplayAddress = "ENDEAVOR ELEMENTARY SCHOOL 2824 E VICTORY RD NAMPA, ID 83687",
        Address = "2824 E VICTORY RD NAMPA, ID 83687",
        PollingPlaceName = "ENDEAVOR ELEMENTARY SCHOOL",
        LocationName = "2824 E VICTORY RD",
        LocationDesc = "",
        CityStateZip = "NAMPA, ID 83687",
        PrecinctNo = "69-13",
        Latitude = 43.576767m,
        Longitude = -116.535189m
      };

      return new PrecinctInfoList() { info32, info42, info69 };
    }
  }
}