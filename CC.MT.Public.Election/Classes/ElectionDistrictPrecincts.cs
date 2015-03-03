using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CC.MT.Public.Election
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
    private string _district;
    private string _precinct;
    private string _error;

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
      _district = String.Empty;
      _precinct = String.Empty;
      _error = error;
    }

    /// <summary>
    /// The name of the district
    /// </summary>
    /// <see cref="DistrictNames"/>
    public string Name
    {
      get { return _district; }
      set { _district = value; }
    }

    /// <summary>
    /// The short precinct name separated by a comma
    /// </summary>
    public string Precinct
    {
      get { return _precinct; }
      set { _precinct = value; }
    }
    
    /// <summary>
    /// If set then there was an error in processing the request for data
    /// </summary>
    public string Error
    {
      get { return _error; }
      set { _error = value; }
    }

  }
}