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
    //public Party FindParty(string party)
    //{
    //  return this.FirstOrDefault(c => c.PartyName == party);
    //}

    //public Contest FindContest(string party, string contest)
    //{
    //  Contest ret = null;
    //  foreach (Party p in this.Where(p => p.PartyName == party))
    //  {
    //    foreach (Contest c in p.Contests.Where(c => c.Name == contest))
    //    {
    //      ret = c;
    //      break;
    //    }
    //  }
    //  return ret;
    //}
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

    //public Party(DataRow row)
    //{
    //  _contests = new ContestList();
    //  _name = row["Party"].ToString();
    //  _contests.Add(new Contest(row));
    //}

    /// <summary>
    /// Can be any party name or empty if there is no party affiliation for the contests
    /// </summary>
    public String PartyName { get; set; }

    /// <summary>
    /// A List of contests for the party affiliation
    /// </summary>
    /// <see cref="ContestList"/>
    public ContestList Contests { get; set; }

    //public void AddContest(DataRow row)
    //{
    //  Contests.Add(new Contest(row));
    //}
  }
}