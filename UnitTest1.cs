using System;
using Xunit;
using System.Threading.Tasks;

namespace SearchFlights.Tests
{
  public class Queries
  {
    
  // Flight API end points : one that has many flights, one that has no available flights
    public static string API_DUB_TO_STN_MANY_FLIGHTS = "https://desktopapps.ryanair.com/v4/en-gb/availability?ADT=1&CHD=0&DateOut=2019-07-26&Destination=STN&FlexDaysOut=4&INF=0&IncludeConnectingFlights=true&Origin=DUB&RoundTrip=false&TEEN=0&ToUs=AGREED&exists=false";
    public static string API_TUN_TO_MLA_NO_FLIGHTS = "https://desktopapps.ryanair.com/v4/en-gb/availability?ADT=1&CHD=0&DateOut=2019-07-19&Destination=VGO&FlexDaysOut=4&INF=0&IncludeConnectingFlights=true&Origin=DUB&RoundTrip=false&TEEN=0&ToUs=AGREED&exists=false";
    
    // Airport URI - valid and invalid
    public static string API_VALID_AIRPORT_URI = "https://desktopapps.ryanair.com/en-gb/res/stations";
    public static string API_INVALID_AIRPORT_URI = "https://desktopapps.ryanair.com/en-gb/res/stationx";

    
  }
}
