/*
* Name: Dallas Sutton
* Course: CSCI 1250, Section 001
* Assignment: Lab 04, The Group Trip
* Date: October 7, 2026
* Description: Rebuilds the trip calculator with methods and arrays so it
* reports on a whole group instead of one person.
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
decimal moneyRecievedInPaycheck;
decimal moneyRecievedInPaycheckPerHour;
double hoursNeededToWorkToPayYourPart;

//cost vars
decimal tripTotalCost;
decimal costPerPerson;


//information and logic vars
int peopleAttending = names.Length;
int totalHours = 0;
decimal totalTakeHomePay = 0;
double longestShift = 0;

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
System.Console.WriteLine("");
System.Console.WriteLine("=== Part 1: The Trip ===");
fuelCost = FuelCost(roundTripMiles, milesPerGallon, pricePerGallon); System.Console.WriteLine($"Fuel Cost: {fuelCost.ToString("C")}");
totalPizzaCost = PizzaCost(pizzasNeeded, pricePerPizza); System.Console.WriteLine($"Pizza Cost: {totalPizzaCost.ToString("C")}");
tripTotalCost = fuelCost + totalPizzaCost; System.Console.WriteLine($"Trip Total: {tripTotalCost.ToString("C")}");

//printing out part2 values
System.Console.WriteLine("");
System.Console.WriteLine("=== Part 2: The Group ===");
System.Console.WriteLine($"People going: {names.Length}");
slicesPerPerson = PizzaSlices(pizzasNeeded, peopleAttending); System.Console.WriteLine($"Slices each: {slicesPerPerson.ToString("F2")}");
costPerPerson = tripTotalCost / peopleAttending; System.Console.WriteLine($"Cost per Person {costPerPerson.ToString("C")}");

//printing out part3 values
System.Console.WriteLine("");
System.Console.WriteLine("=== Part 3: Who Works How Long ===");

for (int i = 0; i < names.Length; i++) {
    moneyRecievedInPaycheck = TakeHomePay(hoursWorked[i], hourlyRates[i]);
    hoursNeededToWorkToPayYourPart = HoursWorkedToPay(costPerPerson, moneyRecievedInPaycheck, hoursWorked[i]);
    moneyRecievedInPaycheckPerHour = moneyRecievedInPaycheck / (decimal)hoursWorked[i];
    totalHours += (int)hoursWorked[i];
    totalTakeHomePay += moneyRecievedInPaycheck;
    longestShift = Math.Max(longestShift,hoursNeededToWorkToPayYourPart);
    System.Console.WriteLine($"{names[i]}: takes home {moneyRecievedInPaycheck.ToString("C")} for {hoursWorked[i]} hours, {moneyRecievedInPaycheckPerHour.ToString("C")} per hour, must work {hoursNeededToWorkToPayYourPart.ToString("F2")} hours."); }

//final outputs
System.Console.WriteLine("");
System.Console.WriteLine($"Total hours worked: {totalHours}");
System.Console.WriteLine($"Total take home pay: {totalTakeHomePay.ToString("C")}");
System.Console.WriteLine($"Longest anyone must work: {longestShift.ToString("F2")}");

static decimal FuelCost(double roundTripMiles, double milesPerGallon, decimal pricePerGallon) {
    double gallonsNeeded = roundTripMiles / milesPerGallon;
    decimal fuelCost = Convert.ToDecimal(gallonsNeeded) * pricePerGallon;
    return fuelCost; } //returns fuel cost for the trip

static decimal TakeHomePay(double hoursWorkedThisWeek, double hourlyWage) {
    decimal grossPay = (decimal)hourlyWage * (decimal)hoursWorkedThisWeek;
    decimal taxWithHeld = grossPay * TAX_RATE;
    decimal moneyRecievedInPaycheck = grossPay - taxWithHeld;
    return moneyRecievedInPaycheck; } //returns how much each person makes per paycheck

static double HoursWorkedToPay(decimal costPerPerson, decimal moneyRecievedInPaycheck, double hoursWorked) {
    decimal moneyRecievedInPaycheckPerHour = moneyRecievedInPaycheck / (decimal)hoursWorked;
    double hoursNeededToWorkToPayYourPart = Convert.ToDouble(costPerPerson / moneyRecievedInPaycheckPerHour);
    return hoursNeededToWorkToPayYourPart; } //returns the hours each person neededs to work to pay their portion of trip costs

static decimal PizzaCost(int pizzasNeeded, decimal pricePerPizza) {   
    decimal totalPizzaCost = pizzasNeeded * pricePerPizza;
    return totalPizzaCost; } //returns the total cost of the pizzas

static double PizzaSlices(int pizzasNeeded, int peopleAttending) {
    int totalSLices = pizzasNeeded * SLICES_PER_PIZZA;
    double slicesPerPerson = totalSLices / peopleAttending;
    return slicesPerPerson; } //returns how many pizza slices each person gets
