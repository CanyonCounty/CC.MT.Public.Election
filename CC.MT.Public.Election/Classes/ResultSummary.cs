using System;
using System.Runtime.Serialization;

namespace CC.MT.Public.Election.Classes
{
  /// <summary>
  /// The Election Summary
  /// </summary>
  public class ResultSummary
  {
    /// <summary>
    /// Default Constructor
    /// </summary>
    public ResultSummary() : this(String.Empty) { }

    /// <summary>
    /// Error Handler constructor
    /// </summary>
    /// <param name="error">The error as to why we could not proceed</param>
    public ResultSummary(string error)
    {
      ResultSummaryID = 0;
      ElectionID = 0;
      LastUpdated = String.Empty;
      TotalVoters = String.Empty;
      BallotsCounted = String.Empty;
      VoterTurnout = String.Empty;
      PrecinctsComplete = String.Empty;
      ElectionDate = String.Empty;
      ElectionName = String.Empty;
      Error = error;
    }

    //public ResultSummary(DataRow row)
    //{
    //  ResultSummaryID = CCData.ToInteger(row["ResultSummaryID"]);
    //  ElectionID = CCData.ToInteger(row["ElectionID"]);
    //  LastUpdated = row["LastUpdated"].ToString();
    //  TotalVoters = row["TotalVoters"].ToString();
    //  BallotsCounted = row["BallotsCounted"].ToString();
    //  VoterTurnout = row["VoterTurnout"].ToString();
    //  PrecinctsComplete = row["PrecinctsComplete"].ToString();
    //  _electionDate = row["ElectionDate"].ToString();
    //  ElectionName = row["ElectionName"].ToString();
    //  _error = String.Empty;
    //}

    /// <summary>
    /// You Can't see me
    /// </summary>
    [IgnoreDataMember]
    public int ResultSummaryID { get; set; }
    
    /// <summary>
    /// You Can't see me
    /// </summary>
    [IgnoreDataMember]
    public int ElectionID { get; set; }

    /// <summary>
    /// The Date and Time the Summary was last updated. It could be blank.
    /// </summary>
    public String LastUpdated { get; set; }

    /// <summary>
    /// The total number of voters that can vote in this election. It could be blank, unknown at the current time.
    /// </summary>
    public String TotalVoters { get; set; }

    /// <summary>
    /// The total number of ballots that have been counted.
    /// </summary>
    public String BallotsCounted { get; set; }

    /// <summary>
    /// The voter turnout percentage. It could be blank.
    /// </summary>
    public String VoterTurnout { get; set; }

    /// <summary>
    /// The number of precincts that have been counted, in the format (0 out of 64)
    /// </summary>
    public String PrecinctsComplete { get; set; }

    /// <summary>
    /// The current election name
    /// </summary>
    public String ElectionName { get; set; }

    /// <summary>
    /// The current election date
    /// </summary>
    public String ElectionDate {get; set; }

    /// <summary>
    /// The Date Time the results should start being visible
    /// </summary>
    public String ResultTime { get; set; }

    /// <summary>
    /// If set then there was an error in processing the request for data
    /// </summary>
    public String Error { get; set; }
  }
}