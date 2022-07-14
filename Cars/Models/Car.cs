// //using the system namespace in C#
// using System;
// //here we are reaching the generic object nested in system
// using System.Collections.Generic;

// // The Car class is our "Business Logic"---------------------------

// //Declaring a class called "Car"
// public class Car
// {
//   //These are the fields aka variables inside of our Car class
//   public string MakeModel;
//   public int Price;
//   public int Miles;

//   public Car(string MakeModel, int price, int miles)
//   {
//     MakeModel = makeModel;
//     Price = price;
//     Miles = miles;
//   }

//   //If Price is less than / equal to maxPrice, the expression returns true (because the method will only return a boolean value)
//   public bool WorthBuying(int maxPrice)
//   {
//     return (Price <= maxPrice);
//   }
// }

// //The Program class is our "UI logic"------------------------------
// public class Program
// {
//   public static void Main()
//   {
//     //OLD CODE BEFORE CREATING A CAR CONSTRUCTOR vvv (THESE USED CLASS CAR)
    
//     // Car volkswagen = new Car();
//     // volkswagen.MakeModel = "1974 Volkswagen Thing";
//     // volkswagen.Price = 1100;
//     // volkswagen.Miles = 368792;

//     // Car yugo = new Car();
//     // yugo.MakeModel = "1980 Yugo Koral";
//     // yugo.Price = 700;
//     // yugo.Miles = 56000;

//     // Car ford = new Car();
//     // ford.MakeModel = "1988 Ford Country Squire";
//     // ford.Price = 1400;
//     // ford.Miles = 239001;

//     // Car amc = new Car();
//     // amc.MakeModel = "1976 AMC Pacer";
//     // amc.Price = 400;
//     // amc.Miles = 198000;

//     //Inside the parans is what's using the constructor
//     //all elements (volkswagen, yugo, ford, amc) are instances of the Car class 
//     Car volkswagen = new Car("1974 Volkswagen Thing", 1100 , 368792) ;
//     Car yugo = new Car("1980 Yugo Koral", 700, 56000);
//     Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
//     Car amc = new Car("1976 AMC Pacer", 400, 198000);

//     //List "Cars" is holding volkswagen, yugo, ford, & amc objects
//     List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };
    
//     //This will display the text below in the console
//     Console.WriteLine("Enter maximum price: ");
//     //we create a string that will take in the user input (it will be stored in stringMaxPrice)
//     string stringMaxPrice = Console.ReadLine();
//     //We convert stringMaxPrice into an integer and store that value in maxPrice
//     int maxPrice = int.Parse(stringMaxPrice);
    
//     //Instantiate a new list called CarsMatchingSearch - the list begins at the first element (kinda like at the first index) which is defined by (0);  
//     List<Car> CarsMatchingSearch = new List<Car>(0);

//     // If a user's inputted max price includes a car's (element's) Price, that car (element) will be returned in a list called CarsMatchingSearch
//     foreach (Car element in Cars)
//     {
//       if (element.WorthBuying(maxPrice))
//       {
//         CarsMatchingSearch.Add(element);
//       }
//     }
    
//     //For each of the elements inside of the Cars List (volkswagen, yugo, ford, & amc objects), we will print the MakeModel for each 
//     foreach(Car element in CarsMatchingSearch)
//     {
//       Console.WriteLine(element.MakeModel);
//     }
//   }
// }