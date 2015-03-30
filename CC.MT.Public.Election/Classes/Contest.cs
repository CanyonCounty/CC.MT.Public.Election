using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CC.MT.Public.Election.Classes
{
  /// <summary>
  /// A List of Contests
  /// </summary>
  /// <see cref="Contest"/>
  public class ContestList : List<Contest>
  {
  }

  /// <summary>
  /// A Contest
  /// </summary>
  /// <see cref="ChoiceList"/>
  public class Contest
  {
    /// <summary>
    /// Another Constructor
    /// </summary>
    public Contest()
    {
      Name = String.Empty;
      Choices = new ChoiceList();
    }

    /// <summary>
    /// The Name of the contest as it appears on the ballot
    /// </summary>
    public String Name { get; set; }

    /// <summary>
    /// A list of choices that appear on the ballot
    /// </summary>
    /// <see cref="ChoiceList"/>
    public ChoiceList Choices { get; set; }

  }
}