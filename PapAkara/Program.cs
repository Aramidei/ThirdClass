decimal akaraUnitPrice = 50;
decimal papUnitPrice = 100;
int papOrder;
int akaraOrder;
int orderAmount;
int Orderlimit = 5;
decimal amount = 0m;
int totalOrder;
Console.WriteLine("Welcome to our store. What would you like to order!");
Console.WriteLine("Akara - 1");
Console.WriteLine("Pap - 2");
Console.WriteLine("Both - 3");
int order = Convert.ToInt32(Console.ReadLine());

switch (order)
{
    case 1:

        Console.WriteLine("How many akara would you like to order!");
        orderAmount = Convert.ToInt32(Console.ReadLine());
        if (orderAmount <= Orderlimit)
        {
            amount = orderAmount * akaraUnitPrice;

        }
        else
        {
            Console.WriteLine("The order limit is 5");
            return;
        }
        break;


        case 2:
        Console.WriteLine("How many pap would you like to order!");
        orderAmount = Convert.ToInt32(Console.ReadLine());
        if (orderAmount <= Orderlimit)
        {
            amount = orderAmount * papUnitPrice;
           

        }
        else
        {
            Console.WriteLine("The order limit is 5");
            return;
        }
        break;

    case 3:
        Console.WriteLine("How many akara would you like to order!");
        akaraOrder = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many pap would you like to order!");
        papOrder = Convert.ToInt32(Console.ReadLine());
       orderAmount = akaraOrder + papOrder;

        if (orderAmount <= Orderlimit)
        {
            amount = (akaraOrder * akaraUnitPrice) + (papOrder * papUnitPrice);

        }
        else
        {
            Console.WriteLine("The order limit is 5");
            return;
        }
        break;

    default:
        Console.WriteLine("Wrong order inputted. Kindly retry placing your order.");
        return;
}

Console.WriteLine($"Your bill is {amount}. Would you like to proceed to pay!");
Console.WriteLine("1 - Yes");
Console.WriteLine("2 - No");

int agree = Convert.ToInt32(Console.ReadLine());

if(agree == 1 && amount != 0)
{

    decimal atmCurrentBalance = 2000m;
    decimal userAccountBalance = 5000.0m;
    decimal charge;
    string password = string.Empty;
    string correctPassword = "TJ";
    string accountType = string.Empty;

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


    Console.WriteLine("Please input your account type");
    Console.WriteLine("Current - 1");
    Console.WriteLine("Savings - 2");
    accountType = Console.ReadLine();

    switch (accountType)
    {
        case "1":
            Console.WriteLine("Kindly make payment using another channel");
            break;

        case "2":

            Console.WriteLine($"Payment amount is {amount}");
           

            charge = (0.5m / 100) * amount;
            amount = amount + charge;


            if (amount > userAccountBalance)
            {
                Console.WriteLine("Insufficient balance!!!!");
                return;
            }

            if (amount < 50.00m)
            {
                Console.WriteLine("Please input an amount greater than 999!!");
                return;
            }


            if (atmCurrentBalance < 100.00m)
            {
                Console.WriteLine("Temporarily unable to dispense cash!!");
                return;
            }

            if (atmCurrentBalance > 100.00m && atmCurrentBalance < amount)
            {
                Console.WriteLine("Dey play! Please withdrawal a lower amount!!");
                return;
            }

            Console.WriteLine("Payment successful. Thanks for the patronage!!!");
            break;


        default:
            Console.WriteLine("Account type does not allow this payment mode. Kindly reach out to customer care.");
            break;


    }


}
else
{
    Console.WriteLine("Nice having you at our store. You can still shop our other goods.");

}







