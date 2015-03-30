using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CC.MT.Public.Election.Classes
{
  /// <summary>
  /// A list of Result Detail
  /// </summary>
  /// <see cref="ResultDetail"/>
  public class ResultDetailList : List<ResultDetail> { }

  /// <summary>
  /// A Line item per choice
  /// </summary>
  public class ResultDetail
  {
    /// <summary>
    /// Default Constructor
    /// </summary>
    public ResultDetail() : this(String.Empty) { }

    /// <summary>
    /// Error Handler constructor
    /// </summary>
    /// <param name="error">The error as to why we could not proceed</param>
    public ResultDetail(string error)
    {
      //_resultDetailId = String.Empty;
      ElectionID = String.Empty;
      Party = String.Empty;
      Contest = String.Empty;
      Choice = String.Empty;
      Votecount = String.Empty;
      Percentage = String.Empty;
      Error = error;
    }

    /// <summary>
    /// You Can't see me
    /// </summary>
    [IgnoreDataMember]
    public String ElectionID { get; set; }

    /// <summary>
    /// Can be any party name or empty if there is no party affiliation for the contests
    /// </summary>
    public String Party { get; set; }

    /// <summary>
    /// The Name of the contest as it appears on the ballot
    /// </summary>
    public String Contest { get; set; }

    /// <summary>
    /// The Choice Name as it is on the ballot
    /// </summary>
    public String Choice { get; set; }

    /// <summary>
    /// The current vote count for the choice. It will be blank before ballots are counted
    /// </summary>
    public String Votecount { get; set; }

    /// <summary>
    /// The calculated percentage of vote counts between choices. It will be blank before ballots are counted
    /// </summary>
    public String Percentage { get; set; }

    /// <summary>
    /// If set then there was an error in processing the request for data
    /// </summary>
    public String Error { get; set; }
  }
}