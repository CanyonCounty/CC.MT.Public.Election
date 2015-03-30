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
    // You need a default / empty constrictor - ERRGH!
    //public Choice()
    //{
    //  _name = String.Empty;
    //  _votecount = String.Empty;
    //  _percentage = String.Empty;
    //}

    //public Choice(DataRow row)
    //{
    //  _name = CCData.ToString(row["Choice"]);
    //  _votecount = CCData.ToString(row["VoteCount"]);
    //  _percentage = CCData.ToString(row["Percentage"]);

    //  //if (_votecount == String.Empty) _votecount = "0";
    //  //if (_percentage == String.Empty) _percentage = "0.00";
    //}

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

    /// <summary>
    /// Just a prettier string than default
    /// </summary>
    /// <returns>Choice Name + " - " + VoteCount + " - " + Percentage</returns>
    //public override String ToString()
    //{
    //  return Name + " - " + VoteCount + " - " + Percentage;
    //}
  }
}