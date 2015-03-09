using System;
using System.Collections.Generic;

namespace CC.MT.Public.Election.Classes
{
  /// <summary>
  /// A List of <see cref="ElectionDistrictPrecincts"/>
  /// </summary>
  public class ElectionDistrictPrecinctsList : List<ElectionDistrictPrecincts> { }

  /// <summary>
  /// Containing ElectionDistrictPrecincts Class
  /// </summary>
  public class ElectionDistrictPrecincts
  {
    /// <summary>
    /// Default Construtor
    /// </summary>
    public ElectionDistrictPrecincts() : this(String.Empty) { }

    /// <summary>
    /// Constructor that takes an error
    /// </summary>
    /// <param name="error">The error as to why we could not proceed</param>
    public ElectionDistrictPrecincts(string error)
    {
      Name = String.Empty;
      Precinct = String.Empty;
      Error = error;
    }

    /// <summary>
    /// The name of the district
    /// </summary>
    /// <see cref="DistrictNames"/>
    public string Name { get; set; }

    /// <summary>
    /// The short precinct name separated by a comma
    /// </summary>
    public string Precinct { get; set; }

    /// <summary>
    /// If set then there was an error in processing the request for data
    /// </summary>
    public string Error { get; set; }
  }
}