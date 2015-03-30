using System;
using System.Runtime.Serialization;

namespace CC.MT.Public.Election.Classes
{
  /// <summary>
  /// Election Information
  /// </summary>
  public class ElectionInfo
  {
    //private string _electionDate;
    //private DateTime _realElectionDate;
    //private string _electionName;
    //private string _electionTypeName;
    //private string _error;

    /// <summary>
    /// Default Constructor
    /// </summary>
    public ElectionInfo() : this(String.Empty) { }

    /// <summary>
    /// Error Constructor
    /// </summary>
    /// <param name="error"></param>
    public ElectionInfo(string error)
    {
      ElectionID = String.Empty;
      ElectionDate = String.Empty;
      ElectionName = String.Empty;
      ElectionTypeName = String.Empty;
      Error = error;
    }

    //public ElectionInfo(DataRow row)
    //{
    //  ElectionID = CCData.ToString(row["ElectionID"]);
    //  _electionDate = CCData.ToString(row["ElectionDate"]);
    //  _electionName = CCData.ToString(row["ElectionName"]);
    //  _electionTypeName = CCData.ToString(row["ElectionTypeName"]);
    //  _realElectionDate = CCData.ToDateTime(row["ElectionDate"]);
    //  _error = String.Empty;
    //}

    /// <summary>
    /// Election ID, now visible
    /// </summary>
    [IgnoreDataMember]
    public string ElectionID { get; set; }

    /// <summary>
    /// The Date of the Election
    /// </summary>
    public String ElectionDate { get; set; }

    /// <summary>
    /// The number of days until the election. Can also be "Tomorrow" or "Today"
    /// </summary>
    public String ElectionCountdown { get; set; }

    /// <summary>
    /// The Name of the election
    /// </summary>
    public String ElectionName { get; set; }

    /// <summary>
    /// The Type of Election
    /// </summary>
    public String ElectionTypeName { get; set; }

    /// <summary>
    /// If set then there was an error in processing the request for data
    /// </summary>
    public String Error { get; set; }

    //private String UserFriendlyCount(DateTime date)
    //{
    //  string ret = "";
    //  DateTime now = DateTime.Now.Date;
    //  //now = DateTime.Parse("3/9/2015");
    //  TimeSpan ts = date.Date - now;

    //  switch (Math.Abs(ts.Days))
    //  {
    //    case 0: ret = "Today"; break;
    //    case 1: ret = "Tomorrow"; break;
    //    default:
    //      ret = Math.Abs(ts.TotalDays).ToString();
    //      break;
    //  }

    //  return ret;
    //}
  }
}