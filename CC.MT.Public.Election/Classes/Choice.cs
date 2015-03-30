using System;
using System.Collections.Generic;
using System.Data;

namespace CC.MT.Public.Election.Classes
{
  /// <summary>
  /// A List of Choices
  /// </summary>
  public class ChoiceList : List<Choice> { }

  /// <summary>
  /// A Single Choice
  /// </summary>
  public class Choice
  {
    /// <summary>
    /// The Choice Name as it is on the ballot
    /// </summary>
    public String Name { get; set; }

    /// <summary>
    /// The current vote count for the choice. It will be blank before ballots are counted
    /// </summary>
    public String VoteCount { get; set; }

    /// <summary>
    /// The calculated percentage of vote counts between choices. It will be blank before ballots are counted
    /// </summary>
    public String Percentage { get; set; }
  }
}