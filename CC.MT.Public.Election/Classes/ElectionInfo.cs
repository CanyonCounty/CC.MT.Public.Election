using System;
using System.Runtime.Serialization;

namespace CC.MT.Public.Election.Classes
{
  /// <summary>
  /// Election Information
  /// </summary>
  public class ElectionInfo
  {
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
  }
}