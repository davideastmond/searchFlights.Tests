using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;

namespace SearchFlights.Tests
{
  public static class JSONLoader
  {
    /* Helper function to load sample JSON data*/
    public static string Load(string JSONFile) {
      string filePath = @"SampleJSON\" + JSONFile;
      try {
        using (FileStream fStream = new FileStream(filePath, FileMode.Open, FileAccess.Read)) {
          using (StreamReader reader = new StreamReader(fStream)) {
            return reader.ReadToEnd();
          }
        }
      } catch (Exception ex) {
        Console.WriteLine(ex.Message);
        return null;
      }
    }
  }
}
