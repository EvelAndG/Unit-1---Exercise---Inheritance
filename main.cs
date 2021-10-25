// from https://www.w3schools.com/cs/cs_inheritance.php
using System;
using System.Collections.Generic;

////////////////////////////////////////////////////////////////////////////////////////////
class PowerPlant  // base class (parent) 
{
  public string Name {get; set;}
  public void TurnOn()             // Vehicle method 
  {                    
    Console.WriteLine($"{Name} is going Zap Zap Zap!");
  }
}
////////////////////////////////////////////////////////////////////////////////////////////
class NuclearPlant : PowerPlant  // derived class (child)
{
  public int RadiationLevel {get; set;}
}
////////////////////////////////////////////////////////////////////////////////////////////
//add two more classes that inherit from PowerPlant, give them at least one unique property.
////////////////////////////////////////////////////////////////////////////////////////////

class WindFarm : PowerPlant
{
	public int WindForce {get; set;}
}


class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Under Construction...");
    // Create a NuclearPlant object
    NuclearPlant plant = new NuclearPlant();
    plant.Name = "bob";
    // Call the TurnOn() method (From the PowerPlant class) using the object
    plant.TurnOn();

    //create an object for each other class, change the name property, and use the TurnOn() Method
  }
}

