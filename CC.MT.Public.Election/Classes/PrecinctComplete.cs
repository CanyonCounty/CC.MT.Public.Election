using System;
using System.Collections.Generic;

namespace CC.MT.Public.Election.Classes
{
  /// <summary>
  /// A List of PrecinctComplete
  /// </summary>
  /// <see cref="PrecinctComplete"/>
  public class PrecinctCompleteList : List<PrecinctComplete> { }

  /// <summary>
  /// Information regarding if a precinct has been counted yet
  /// </summary>
  public class PrecinctComplete
  {
    /// <summary>
    /// Default Constructor
    /// </summary>
    public PrecinctComplete() : this(String.Empty) { }

    /// <summary>
    /// Error handler constructor
    /// </summary>
    /// <param name="error">The error that occurred</param>
    public PrecinctComplete(string error)
    {
      Precinct = String.Empty;
      Completed = false;
      Error = error;
    }

    /// <summary>
    /// The precinct number in simple form (without the district)
    /// </summary>
    public string Precinct { get; set; }

    /// <summary>
    /// Either true if complete or false if incomplete
    /// </summary>
    public bool Completed { get; set; }

    /// <summary>
    /// If set then there was an error in processing the request for data
    /// </summary>
    public String Error { get; set; }
  }
}