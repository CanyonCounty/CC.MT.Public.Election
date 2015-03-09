using System;
using System.Collections.Generic;

namespace CC.MT.Public.Election.Classes
{
  /// <summary>
  /// A List of <see cref="DistrictNames"/>
  /// </summary>
  public class DistrictNamesList : List<DistrictNames> { }

  /// <summary>
  /// Containing DistrictNames Class
  /// </summary>
  public class DistrictNames
  {
    /// <summary>
    /// Default Construtor
    /// </summary>
    public DistrictNames() : this(String.Empty) { }

    /// <summary>
    /// Constructor that takes an error
    /// </summary>
    /// <param name="error">The error as to why we could not proceed</param>
    public DistrictNames(string error)
    {
      DistrictNo = String.Empty;
      DistrictCode = String.Empty;
      DistrictName = String.Empty;
      DistrictTypeName = String.Empty;
      Error = error;
    }

    /// <summary>
    /// The District Number
    /// </summary>
    public String DistrictNo { get; set; }

    /// <summary>
    /// The District Code (used for ballot type)
    /// </summary>
    public String DistrictCode { get; set; }

    /// <summary>
    /// The name of the district
    /// </summary>
    public String DistrictName { get; set; }

    /// <summary>
    /// The type of the district
    /// </summary>
    public String DistrictTypeName { get; set; }

    /// <summary>
    /// If set then there was an error in processing the request for data
    /// </summary>
    public String Error { get; set; }
  }
}