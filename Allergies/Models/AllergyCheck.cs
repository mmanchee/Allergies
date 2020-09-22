using System;
using System.Collections.Generic;

namespace Allergies.Models
{
  public class Allergic
  {
    public string IsAllergic(int userInput)
    {
      Dictionary <int,string> allergies = new Dictionary<int, string>(){
        {128,"cats"},
        {64,"pollen"},
        {32,"chocolate"},
        {16,"tomatoes"},
        {8,"strawberries"},
        {4,"shellfish"},
        {2,"peanuts"},
        {1,"eggs"}
      };
      
      List<string> allergyList = new List<string>();
      
      foreach(var allergy in allergies)
      {
        if (allergy.Key <= userInput)
        {
          userInput = (userInput-allergy.Key);
          allergyList.Add(allergy.Value);
        }
      }
      string allergicTo = String.Join(",", allergyList);
      return allergicTo;
    }
  }
}