using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Newtonsoft.Json.Linq;
namespace SearchFlights.Tests
{
  public class QueriesTests
  {
    [Fact]
    public void ProcessResults_FlightsAreAvailable_ReturnsTrueAndListWithCountGreaterThanZero() {
      // We're going to test the Queries.ProcessResults function to make sure it returns a tuple<bool, List<Itenerary>> where the list count
      // should be greater than zero

      // Arrange
      /* Make up test input that corresponds to the query from flight_query_multiple_results.txt 
       * Departure Date: (2019-09-01) 
       * STN to DUB
       * Adults: 1
       */
      SearchFlights.UserInput testInput;
      testInput.departureDate = new DateTime(2019, 9, 1);
      testInput.destination = "DUB";
      testInput.origin = "STN";
      testInput.numberAdults = 1;

      // First we make our JOBject from JSON data to pass into the function
      string JSONData = JSONLoader.Load("Flight_Query_Mutliple_Results.txt");
      JObject flightJSONResponse = JObject.Parse(JSONData);

      // Act
      Tuple<bool, List<Itinerary>> result = SearchFlights.Queries.ProcessResults(flightJSONResponse, testInput);

      // Assert
      Assert.True(result.Item1 == true && result.Item2.Count > 0);
    }
    [Fact]
    public void ProcessResults_NoFlightsAvailable_ReturnsFalseAndNull() {
      // Arrange
      /* Make up test input that corresponds to the query from flight_query_multiple_results.txt 
       * Departure Date: (2019-11-04) 
       * BUD to LIS
       * Adults: 1
       */
      SearchFlights.UserInput testInput;
      testInput.departureDate = new DateTime(2019, 11, 4);
      testInput.destination = "DUB";
      testInput.origin = "LIS";
      testInput.numberAdults = 1;

      // First we make our JOBject from JSON data to pass into the function
      string JSONData = JSONLoader.Load("Flight_Query_No_Results.txt");
      JObject flightJSONResponse = JObject.Parse(JSONData);
      // Act
      Tuple<bool, List<Itinerary>> result = SearchFlights.Queries.ProcessResults(flightJSONResponse, testInput);

      // Assert
      Assert.True(result.Item1 == false && result.Item2 == null);
    }
  }
}
