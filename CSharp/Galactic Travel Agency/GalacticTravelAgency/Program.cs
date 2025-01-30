using System;

public class GalacticTravelAgency { 
  public static void Main(string[] args) {
    // Your code goes here
    string passengerName = "Zara";
    int passengerAge = 28;
    string ticketType = "First Class";
    string preferredPlanet = "Mars";

    // task 9 to increment the passengerAge by 1
    passengerAge++;

    // Explicit Conversion
    double passengerAgeDouble = (double)passengerAge;
    
    //Implicit Conversion
    double passengerAgeDouble2 = passengerAge;

    // Converting passengerAge to string
    string passengerAgeString = Convert.ToString(passengerAge);

    // Printing and Basic Operations
    Console.WriteLine($"Name: {passengerName}");
    Console.WriteLine($"Age: {passengerAge}");
    
    // Printing PassengerAgeDouble (Explicit Conversion)
    Console.WriteLine($"Age (Explicit Conversion): {passengerAgeDouble}");
    
    // Printing PassengerAgeDouble2 (Implicit Conversion)
    Console.WriteLine($"Age (Implicit Conversion): {passengerAgeDouble2}");

    // Printing PassengerAgeAString (String Conversion)
    Console.WriteLine($"Age (String Conversion): {passengerAgeString}");

    Console.WriteLine($"Ticket Type: {ticketType}");
    Console.WriteLine($"Planet: {preferredPlanet}");
  }
}