int age;
char lifeStage = ' ' ;

Console.WriteLine("Kindly input your age");
age = Convert.ToInt32(Console.ReadLine());

if (age < 2)
{
    Console.WriteLine("You are a baby");
    lifeStage = 'B';
}
else if (age >= 2 && age <= 4)
{
    Console.WriteLine("You are a toddler");
    lifeStage = 'O';
}
else if (age >= 5 && age <= 12)
{
    Console.WriteLine("You are a child");
    lifeStage = 'C';
}
else if (age >= 13 && age <= 19)
{
    Console.WriteLine("You are a teenager");
    lifeStage = 'T';
}
else if (age > 19)
{
    Console.WriteLine("You are an adult");
    lifeStage = 'A';
}
else
{
    Console.WriteLine("Error in the age inputted.Kindly retry!!");
    return;
}


switch(lifeStage)
{
    case 'B':
    Console.WriteLine("You are to register in the creche/daycare");
    break;

    case 'O':
    Console.WriteLine("You are to register in the Nursery");
    break;

    case 'C':
    Console.WriteLine("Please go to the children's section for your bus tickets");
    break;

    case 'T':
    Console.WriteLine("Please go to the teenagers class  for training");
    break;

    case 'A':
    Console.WriteLine("Please go to the Adult class for training");
    break;

}