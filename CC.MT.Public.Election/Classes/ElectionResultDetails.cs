using System;

namespace CC.MT.Public.Election.Classes
{
  /// <summary>
  /// Returns the collection of ElectionResultDetails
  /// </summary>
  /// <see cref="ElectionResultDetails"/>
  public class ElectionResultDetails
  {
    /// <summary>
    /// Constructor used by documentation example
    /// </summary>
    public ElectionResultDetails()
    {
      Results = new PartyList();
      Error = String.Empty;
    }

    /// <summary>
    /// Error handler constructor
    /// </summary>
    /// <param name="error">The error that occurred in processing the request</param>
    public ElectionResultDetails(string error)
    {
      Results = new PartyList();
      Error = error;
    }

    /// <summary>
    /// Default Constructor
    /// </summary>
    /// <param name="party">The list of Parties</param>
    /// <param name="error">An Error, if any</param>
    public ElectionResultDetails(PartyList party, string error)
    {
      Results = party;
      Error = error;
    }

    /// <summary>
    /// A PartyList of Results
    /// </summary>
    /// <see cref="PartyList"/>
    /// <seealso cref="PartyList"/>
    public PartyList Results { get; set; }

    /// <summary>
    /// If set then there was an error in processing the request for data
    /// </summary>
    public String Error { get; set; }
  }
}