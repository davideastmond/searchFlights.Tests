using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Newtonsoft.Json.Linq;
namespace SearchFlights.Tests
{
  public class Validations
  {
    [Fact]
    public void CheckParsingForTrips_TripKeyPresentInParsedJSONObject_ReturnsTrue() 
    {
      // This test ensures that a trip key is present
      // Arrange
      string JSONData = JSONLoader.Load("valid_JSON.txt");
      JObject parsedObject = JObject.Parse(JSONData);
      // Act
      bool result = SearchFlights.Validations.CheckParsingForTrips(parsedObject);
      // Assert
      Assert.True(result);
    }

    [Fact]
    public void CheckParsingForTrips_TripKeyNotPresentInParsedJSONObject_ReturnsFalse() {
      // If the trips key is not present in the JSON data, the method should return false

      // Arrange
      string JSONData = JSONLoader.Load("invalid_JSON.txt");
     
      JObject parsedObject = JObject.Parse(JSONData);

      // Act
      bool result = SearchFlights.Validations.CheckParsingForTrips(parsedObject);

      // Assert
      Assert.False(result);
    }
  }

}
