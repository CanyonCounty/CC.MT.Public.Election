using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CC.MT.Public.Election.Classes
{
  /// <summary>
  /// A List of <see cref="Party">Party</see> objects
  /// </summary>
  /// <see cref="Party"/>
  public class PartyList : List<Party>
  {
  }

  /// <summary>
  /// The Party object
  /// </summary>
  public class Party
  {
    /// <summary>
    /// Another Constructor
    /// </summary>
    public Party()
    {
      PartyName = String.Empty;
      Contests = new ContestList();
    }

    /// <summary>
    /// Can be any party name or empty if there is no party affiliation for the contests
    /// </summary>
    public String PartyName { get; set; }

    /// <summary>
    /// A List of contests for the party affiliation
    /// </summary>
    /// <see cref="ContestList"/>
    public ContestList Contests { get; set; }

  }
}