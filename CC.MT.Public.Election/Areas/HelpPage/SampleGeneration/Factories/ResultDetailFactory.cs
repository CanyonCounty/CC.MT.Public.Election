using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CC.MT.Public.Election.Classes;

namespace CC.MT.Public.Election.Areas.HelpPage.SampleGeneration.Factories
{
  /// <summary>
  /// This creates the sample data for documentation
  /// </summary>
  public static class ResultDetailFactory
  {
    /// <summary>
    /// This just returns some dummy data for the help pages
    /// </summary>
    /// <returns>Dummy ResultDetailList data</returns>
    public static ResultDetailList GetResultDetailSample()
    {
      ResultDetail r1 = new ResultDetail
      {
        Party = "REPUBLICAN PARTY",
        Contest = "UNITED STATES SENATOR",
        Choice = "MICKEY DUCK",
        Votecount = "3",
        Percentage = "30",
        Error = ""
      };

      ResultDetail r2 = new ResultDetail
      {
        Party = "REPUBLICAN PARTY",
        Contest = "UNITED STATES SENATOR",
        Choice = "DONALD MOUSE",
        Votecount = "7",
        Percentage = "70",
        Error = ""
      };

      ResultDetail d1 = new ResultDetail
      {
        Party = "DEMOCRATIC PARY",
        Contest = "REPRESENTATIVE IN CONGRESS DISTRICT 1",
        Choice = "BUGS DUCK",
        Votecount = "7",
        Percentage = "70",
        Error = ""
      };

      ResultDetail d2 = new ResultDetail
      {
        Party = "DEMOCRATIC PARY",
        Contest = "REPRESENTATIVE IN CONGRESS DISTRICT 1",
        Choice = "DAFFY BUNNY",
        Votecount = "3",
        Percentage = "30",
        Error = ""
      };

      ResultDetail u1 = new ResultDetail
      {
        Party = "",
        Contest = "YOUR SCHOOL BOND OR LEVEY",
        Choice = "IN FAVOR OF",
        Votecount = "",
        Percentage = "",
        Error = ""
      };

      ResultDetail u2 = new ResultDetail
      {
        Party = "",
        Contest = "YOUR SCHOOL BOND OR LEVEY",
        Choice = "AGAINST",
        Votecount = "",
        Percentage = "",
        Error = ""
      };

      return new ResultDetailList() {r1, r2, d1, d2, u1, u2};
    }
  }
}