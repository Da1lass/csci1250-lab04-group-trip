/*
 * Name: Dallas Sutton
 * Course: CSCI 1250, Section 001
 * Assignment: Lab 2, Trip Calculator
 * Date: September 23, 2026
 * Description: Calculates information about trip costs.
 */


// fuel cost vars
double roundTripMiles;
double milesPerGallon;
decimal pricePerGallon;
decimal fuelCost;

//pizza party vars
int pizzasNeeded;
decimal pricePerPizza;
int totalSLices;
decimal totalPizzaCost;
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

//arrays given by Desjarsin
string[] names = { "Ada", "Grace", "Alan", "Katherine" };
double[] hoursWorked = { 22, 15, 30, 18 };
double[] hourlyRates = { 13.50, 16.00, 11.20, 14.80 };

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

static double HoursToCover(double amountOwed, double takeHomePerHour) {
    
}

static decimal PizzaCost(int pizzasNeeded, int slicesPerPizza, int peopleAttending, decimal pricePerPizza) {
    int totalSLices = pizzasNeeded * SLICES_PER_PIZZA;
    double slicePerPerson = totalSLices / peopleAttending;
    decimal totalPizzaCost = pizzasNeeded * pricePerPizza;
    return totalPizzaCost;
}

//begin fuel var assignment
System.Console.Write("Round miles? ");
roundTripMiles = Convert.ToDouble(System.Console.ReadLine());

System.Console.Write("Miles per gallon? ");
milesPerGallon = Convert.ToDouble(System.Console.ReadLine());

System.Console.Write("Price per gallon? ");
pricePerGallon = Convert.ToDecimal(System.Console.ReadLine());
//end fuel var assignment

fuelCost = FuelCost(roundTripMiles, milesPerGallon, pricePerGallon); System.Console.WriteLine(fuelCost.ToString("C"));

//begin pizza var assignment
System.Console.Write("How many pizzas are being purchased? ");
pizzasNeeded = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Price per pizza? ");
pricePerPizza = Convert.ToDecimal(System.Console.ReadLine());
//end pizza var assignment

totalPizzaCost = PizzaCost(pizzasNeeded, SLICES_PER_PIZZA, peopleAttending, pricePerPizza); System.Console.WriteLine(totalPizzaCost.ToString("C"));