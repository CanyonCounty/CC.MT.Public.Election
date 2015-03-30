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
    //public Contest FindContest(string contest)
    //{
    //  return this.FirstOrDefault(c => c.Name == contest);
    //}
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

    //public Contest(DataRow row)
    //{
    //  _choices = new ChoiceList();
    //  _name = row["Contest"].ToString();
    //  _choices.Add(new Choice(row));
    //}

    /// <summary>
    /// The Name of the contest as it appears on the ballot
    /// </summary>
    public String Name { get; set; }

    /// <summary>
    /// A list of choices that appear on the ballot
    /// </summary>
    /// <see cref="ChoiceList"/>
    public ChoiceList Choices { get; set; }

    //public void AddChoice(DataRow row)
    //{
    //  Choices.Add(new Choice(row));
    //}

    /// <summary>
    /// Just a prettier string than default
    /// </summary>
    /// <returns>Contest Name + Choices Count</returns>
    //public override String ToString()
    //{
    //  return Name + " - " + Choices.Count.ToString();
    //}
  }
}