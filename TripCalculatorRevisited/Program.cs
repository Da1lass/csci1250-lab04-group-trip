/*
 * Name: Dallas Sutton
 * Course: CSCI 1250, Section 001
 * Assignment: Lab 2, Trip Calculator
 * Date: September 23, 2026
 * Description: Calculates information about trip costs.
 */

//arrays given by Desjarsin
string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

// fuel cost vars
double roundTripMiles;
double milesPerGallon;
decimal pricePerGallon;
decimal fuelCost;

//pizza party vars
int pizzasNeeded;
decimal pricePerPizza;
decimal totalPizzaCost;
double slicesPerPerson;
const int SLICES_PER_PIZZA = 8;

//wage vars
const decimal TAX_RATE = 0.18M;
decimal grossPay;
decimal taxWithHeld;
decimal moneyRecievedInPaycheck;

//cost vars
decimal tripTotalCost;
decimal CostPerPerson;
decimal moneyRecievedInPaycheckPerHour;
double hoursNeededToWorkToPayYourPart;

//other vars (will prob be moved into another var catagory)
int peopleAttending = names.Length;


static decimal FuelCost(double roundTripMiles, double milesPerGallon, decimal pricePerGallon) {
    double gallonsNeeded = roundTripMiles / milesPerGallon;
    decimal fuelCost = Convert.ToDecimal(gallonsNeeded) * pricePerGallon;
    return fuelCost; }

static decimal TakeHomePay(double hoursWorkedThisWeek, decimal hourlyWage, double taxRate) {
    decimal grossPay = hourlyWage * (decimal)hoursWorkedThisWeek;
    decimal taxWithHeld = grossPay * TAX_RATE;
    decimal moneyRecievedInPaycheck = grossPay - taxWithHeld;
    return moneyRecievedInPaycheck;
}

//static double HoursToCover(double amountOwed, double takeHomePerHour) {
    
//}

static decimal PizzaCost(int pizzasNeeded, decimal pricePerPizza) {
    
    decimal totalPizzaCost = pizzasNeeded * pricePerPizza;
    return totalPizzaCost;
}
static double PizzaSlices(int pizzasNeeded, int peopleAttending) {
    int totalSLices = pizzasNeeded * SLICES_PER_PIZZA;
    double slicesPerPerson = totalSLices / peopleAttending;
    return slicesPerPerson;
}
//begin fuel var assignment
System.Console.Write("Round miles? ");
roundTripMiles = Convert.ToDouble(System.Console.ReadLine());

System.Console.Write("Miles per gallon? ");
milesPerGallon = Convert.ToDouble(System.Console.ReadLine());

System.Console.Write("Price per gallon? ");
pricePerGallon = Convert.ToDecimal(System.Console.ReadLine());
//end fuel var assignment

//begin pizza var assignment
System.Console.Write("How many pizzas are being purchased? ");
pizzasNeeded = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Price per pizza? ");
pricePerPizza = Convert.ToDecimal(System.Console.ReadLine());
//end pizza var assignment

//printing out part1 values
System.Console.WriteLine("=== Part 1: The Trip ===");
fuelCost = FuelCost(roundTripMiles, milesPerGallon, pricePerGallon); System.Console.WriteLine($"Fuel Cost: {fuelCost.ToString("C")}");
totalPizzaCost = PizzaCost(pizzasNeeded, pricePerPizza); System.Console.WriteLine($"Pizza Cost: {totalPizzaCost.ToString("C")}");
tripTotalCost = fuelCost + totalPizzaCost; System.Console.WriteLine($"Trip Total: {tripTotalCost.ToString("C")}");

System.Console.WriteLine("=== Part 2: The Group ===");
System.Console.WriteLine($"People going: {names.Length}");
slicesPerPerson = PizzaSlices(pizzasNeeded, peopleAttending); System.Console.WriteLine($"Slices each: {slicesPerPerson}");
System.Console.WriteLine($"Cost per Person {totalPizzaCost / peopleAttending}");