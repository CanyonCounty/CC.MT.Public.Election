using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CC.MT.Public.Election.Classes
{
  /// <summary>
  /// A List of <see cref="ElectionDistrictZone"/>
  /// </summary>
  public class ElectionDistrictList : List<ElectionDistrictZone> { }

  /// <summary>
  /// Containing ElectionDistrictZone Class
  /// </summary>
  public class ElectionDistrictZone
  {
    /// <summary>
    /// Default Construtor
    /// </summary>
    public ElectionDistrictZone() : this(String.Empty) { }

    /// <summary>
    /// Constructor that takes an error
    /// </summary>
    /// <param name="error">The error as to why we could not proceed</param>
    public ElectionDistrictZone(string error)
    {
      Number = String.Empty;
      Code = String.Empty;
      Name = String.Empty;
      PrecinctNo = String.Empty;
      Precinct = String.Empty;
      PrecinctID = String.Empty;
      DistrictTypeName = String.Empty;
      Label = String.Empty;
      Error = error;
    }

    /// <summary>
    /// The District and/or Zone number
    /// </summary>
    public String Number { get; set; }

    /// <summary>
    /// The District and/or Zone Code (used for ballot type)
    /// </summary>
    public String Code { get; set; }

    /// <summary>
    /// The District and/or Zone name
    /// </summary>
    public String Name { get; set; }

    /// <summary>
    /// The full precinct number 'precinct-district' (ie. 69-13)
    /// </summary>
    public String PrecinctNo { get; set; }

    /// <summary>
    /// The short precinct number 'precinct' (ie. 69) zero padded
    /// </summary>
    public String Precinct { get; set; }

    /// <summary>
    /// The precinct ID
    /// </summary>
    [IgnoreDataMember]
    public String PrecinctID { get; set; }

    /// <summary>
    /// The type of the district
    /// </summary>
    public String DistrictTypeName { get; set; }

    /// <summary>
    /// Specifies District or Zone
    /// </summary>
    public String Label { get; set; }

    /// <summary>
    /// If set then there was an error in processing the request for data
    /// </summary>
    public String Error { get; set; }
  }
}