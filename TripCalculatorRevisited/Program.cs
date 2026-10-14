/*
 * Name: Dallas Sutton
 * Course: CSCI 1250, Section 001
 * Assignment: Lab 2, Trip Calculator
 * Date: September 23, 2026
 * Description: Calculates information about trip costs.
 */

double roundTripMiles; 
double milesPerGallon;
decimal pricePerGallon;
double gallonsNeeded;
decimal fuelCost;

System.Console.Write("Round miles? ");
roundTripMiles = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("");

System.Console.Write("Miles per gallon? ");
milesPerGallon = Convert.ToDouble(System.Console.ReadLine());

System.Console.WriteLine("");

System.Console.Write("Price per gallon? ");
pricePerGallon = Convert.ToDecimal(System.Console.ReadLine());

gallonsNeeded = roundTripMiles / milesPerGallon;
fuelCost = Convert.ToDecimal(gallonsNeeded) * pricePerGallon;

System.Console.WriteLine("");
System.Console.WriteLine($"Gallons needed: {gallonsNeeded.ToString("F2")}");
System.Console.WriteLine($"Fuel Cost: {fuelCost.ToString("C")}");

int peopleAttending;
int pizzasNeeded;
decimal pricePerPizza;
int totalSLices;
double slicePerPerson;
decimal totalPizzaCost;
const int SLICES_PER_PIZZA = 8;

System.Console.Write("How many people are attending? ");
peopleAttending = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("");

System.Console.Write("How many pizzas are being purchased? ");
pizzasNeeded = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("");

System.Console.Write("Price per pizza? ");
pricePerPizza = Convert.ToDecimal(System.Console.ReadLine());

totalSLices = pizzasNeeded * SLICES_PER_PIZZA;
slicePerPerson = totalSLices / peopleAttending;
totalPizzaCost = pizzasNeeded * pricePerPizza;

System.Console.WriteLine("");
System.Console.WriteLine($"Total slices: {totalSLices.ToString("")}");
System.Console.WriteLine($"Slices per person: {slicePerPerson.ToString("F2")}");
System.Console.WriteLine($"Pizza Cost: {totalPizzaCost.ToString("C")}");

int hoursWorkedThisWeek;
decimal hourlyWage; 
const decimal TAX_RATE = 0.18M;
decimal grossPay;
decimal taxWithHeld;
decimal moneyRecievedInPaycheck;

System.Console.Write("How many hours did you work this week? ");
hoursWorkedThisWeek = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("What is your hourly pay? ");
hourlyWage = Convert.ToDecimal(System.Console.ReadLine());

grossPay = hourlyWage * hoursWorkedThisWeek;
taxWithHeld = grossPay * TAX_RATE;
moneyRecievedInPaycheck = grossPay - taxWithHeld;

System.Console.WriteLine("");
System.Console.WriteLine($"Gross pay: {grossPay.ToString("C")}");
System.Console.WriteLine($"Tax withheld: {taxWithHeld.ToString("C")}");
System.Console.WriteLine($"Take home pay: {moneyRecievedInPaycheck.ToString("C")}");

decimal tripTotalCost;
decimal CostPerPerson;
decimal moneyRecievedInPaycheckPerHour;
double hoursNeededToWorkToPayYourPart;

tripTotalCost = fuelCost + totalPizzaCost;
CostPerPerson = tripTotalCost / peopleAttending;
moneyRecievedInPaycheckPerHour = moneyRecievedInPaycheck / hoursWorkedThisWeek;
hoursNeededToWorkToPayYourPart = Convert.ToDouble(CostPerPerson / moneyRecievedInPaycheckPerHour);

System.Console.WriteLine($"Trip total: {tripTotalCost.ToString("C")}");
System.Console.WriteLine($"Cost per person: {CostPerPerson.ToString("C")}");
System.Console.WriteLine($"Take home pay per hour: {moneyRecievedInPaycheckPerHour.ToString("C")}");
System.Console.WriteLine($"Hours you must work to pay for your portion: {hoursNeededToWorkToPayYourPart.ToString("F2")}");