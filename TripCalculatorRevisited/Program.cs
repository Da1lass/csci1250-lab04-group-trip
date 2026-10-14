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
double slicePerPerson;
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

static double TakeHomePay(double hours, double hourlyRate, double taxRate) {
    
}

static double HoursToCover(double amountOwed, double takeHomePerHour)
{
    
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

totalSLices = pizzasNeeded * SLICES_PER_PIZZA;
//slicePerPerson = totalSLices / peopleAttending;
totalPizzaCost = pizzasNeeded * pricePerPizza;

System.Console.WriteLine("");
System.Console.WriteLine($"Total slices: {totalSLices.ToString("")}");
//System.Console.WriteLine($"Slices per person: {slicePerPerson.ToString("F2")}");
System.Console.WriteLine($"Pizza Cost: {totalPizzaCost.ToString("C")}");

grossPay = hourlyWage * hoursWorkedThisWeek;
taxWithHeld = grossPay * TAX_RATE;
moneyRecievedInPaycheck = grossPay - taxWithHeld;

System.Console.WriteLine("");
//System.Console.WriteLine($"Gross pay: {grossPay.ToString("C")}");
//System.Console.WriteLine($"Tax withheld: {taxWithHeld.ToString("C")}");
//System.Console.WriteLine($"Take home pay: {moneyRecievedInPaycheck.ToString("C")}");

tripTotalCost = fuelCost + totalPizzaCost;
//CostPerPerson = tripTotalCost / peopleAttending;
//moneyRecievedInPaycheckPerHour = moneyRecievedInPaycheck / hoursWorkedThisWeek;
//hoursNeededToWorkToPayYourPart = Convert.ToDouble(CostPerPerson / moneyRecievedInPaycheckPerHour);

System.Console.WriteLine($"Trip total: {tripTotalCost.ToString("C")}");
//System.Console.WriteLine($"Cost per person: {CostPerPerson.ToString("C")}");
//System.Console.WriteLine($"Take home pay per hour: {moneyRecievedInPaycheckPerHour.ToString("C")}");
//System.Console.WriteLine($"Hours you must work to pay for your portion: {hoursNeededToWorkToPayYourPart.ToString("F2")}");