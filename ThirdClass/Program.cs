﻿


decimal atmCurrentBalance = 2000m;
decimal userAccountBalance = 5000.0m;
decimal charge;
decimal withdrawalAmount;
string password = string.Empty;
string correctPassword = "TJ";

Console.WriteLine("Please input Password");
password = Console.ReadLine();


int limit = 5;
int index = 1;

while (index < limit && (password != correctPassword))
{
    index += 1;

    Console.WriteLine(index);
    Console.WriteLine("Please input Password");
    password = Console.ReadLine();

    if (index == 5)
    {
        Console.WriteLine("You exceeded the limit");
        return;
    }

}


Console.WriteLine("Input desired amount!");
withdrawalAmount = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine(withdrawalAmount);

charge = (0.5m / 100) * withdrawalAmount;
withdrawalAmount = withdrawalAmount + charge;


while (withdrawalAmount > userAccountBalance)
{
  
   Console.WriteLine("Invalid amount. Kindly input an amount less than your account balance ");

    withdrawalAmount = Convert.ToDecimal(Console.ReadLine());

}

if (withdrawalAmount > userAccountBalance)
{
    Console.WriteLine("Insufficient balance!!!!");
    return;
}

if (withdrawalAmount < 1000.00m)
{
    Console.WriteLine("Please input an amount greater than 999!!");
    return;
}


if (atmCurrentBalance < 1000.00m)
{
    Console.WriteLine("Temporarily unable to dispense cash!!");
    return;
}

if (atmCurrentBalance > 1000.00m && atmCurrentBalance < withdrawalAmount)
{
    Console.WriteLine("Dey play! Please withdrawal a lower amount!!");
    return;
}

Console.WriteLine("Cash dispensed successfully!!!");
