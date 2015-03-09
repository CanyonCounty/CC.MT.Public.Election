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
  public static class PrecinctCompleteListFactory
  {
    /// <summary>
    /// This just returns some dummy data for the help pages
    /// </summary>
    /// <returns>Dummy PrecinctCompleteList data</returns>
    public static PrecinctCompleteList GetPrecinctCompleteListSample()
    {
      PrecinctComplete p7 = new PrecinctComplete {Precinct = "07", Completed = true};

      PrecinctComplete p42 = new PrecinctComplete {Precinct = "42", Completed = false};

      PrecinctCompleteList list = new PrecinctCompleteList {p7, p42};

      return list;
    }
  }
}