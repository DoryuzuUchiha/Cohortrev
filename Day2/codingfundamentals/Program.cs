
Console.WriteLine("Welcome to day 2. Where we are going to learn about all the coding fundamentals you need to know. Please read comments in code for detailed info.");
#region 1. Data Types, Variables, Operators
//Console.WriteLine("1. Data types");
/*
Numeric Data 
    int - numbers without decimals. - consumes 4 bytes of your ram
    doubles - for very big numbers - also for decimals
Alphabets
    string - name, Address, email address, designation, etc ...
    also supports alphanumeric values

    string can store very big values - even a book

    Alphanumeric Values - 
 */
 /*int num1 = 10;
 int num2 = 20;

 int addidtion = num1 + num2;
 int multiplication = num1 * num2;
 int subtraction =  num1 - num2;
 int division = num1 / num2;
 Console.WriteLine("Here are two different numbers. Num1: " +  num1 +  " num2: " + num2);
 Console.WriteLine();
 Console.WriteLine("num1 + num2 is equal to: " + addidtion);
 Console.WriteLine("num1 * num2 is equal to: " + multiplication);
 Console.WriteLine("num1 - num2 is equal to: " + subtraction);
 Console.WriteLine("num1 / num2 is equal to: " + division);
 Console.WriteLine("");
 Console.WriteLine("");
 Console.WriteLine("Here lets try to have you input some numbers instead of it being statically 10 and 20");
 Console.WriteLine("Please enter a number.");
 num1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Please enter another number.");
 num2 = Convert.ToInt32(Console.ReadLine());
 
 addidtion = num1 + num2;
 multiplication = num1 * num2;
 subtraction =  num1 - num2;
 division = num1 / num2;
 Console.WriteLine("Here are your two different numbers. Num1: " +  num1 +  " num2: " + num2);
 Console.WriteLine();
 Console.WriteLine("num1 + num2 is equal to: " + addidtion);
 Console.WriteLine("num1 * num2 is equal to: " + multiplication);
 Console.WriteLine("num1 - num2 is equal to: " + subtraction);
 Console.WriteLine("num1 / num2 is equal to: " + division);
 Console.WriteLine("");
 Console.WriteLine("");

 Console.WriteLine("Now lets look at some Strings.");
 Console.WriteLine("Please enter Your Frst Name.");
 string FirstName = Console.ReadLine();
 Console.WriteLine("");
 Console.WriteLine("Please now Enter Your Last Name.");
 string LastName = Console.ReadLine();
 Console.WriteLine("");
 Console.WriteLine("Here is your Full Name:" + FirstName + "" + LastName);
 Console.WriteLine("");
 Console.WriteLine("");
 */
#endregion
#region Conditional Statements
//Console.WriteLine("4. Conditional Statements");
    /*
    Conditions - they play a huge role in any programming language
    if...else
    if...else if...else
    switch statements
     */
 /*Console.WriteLine("Please Enter a number.");
 int nums = Convert.ToInt32(Console.ReadLine());

 if (nums > 0)
 {
    Console.WriteLine("This number is Psotitive");
 }
 else
 {
    Console.WriteLine("This number is negative");
    
 }
 Console.WriteLine("Lets look at bigger conditionals. Please Enter another Number.");
 nums = Convert.ToInt32(Console.ReadLine());

if (nums > 0 && nums < 10)
{
 Console.WriteLine("Its in the single digits");
}
else if (nums >= 10 && nums < 20)
{
 Console.WriteLine("Its in the tens.");
}
else if (nums >= 20 && nums <30)
{
 Console.WriteLine("Its in the twenty's");
}
else if (nums >= 30 && nums <40)
{
 Console.WriteLine("Its in the thirty's");
}
else if (nums >= 40 && nums <50)
{
 Console.WriteLine("It's in the Forty's");
}
else if (nums >= 50 && nums <60)
{
 Console.WriteLine("It's in the Fifty's");
}
else
{
 Console.WriteLine("The number is not a positive number or is to high.");
}
*/
//switch Statement
int choice = 0;
int total = 50;
string fname = "";
string lname = "";
string email = "";
string pnumber = "";
string banknumber = "";
while (choice != 6)
{
 Console.WriteLine("Thank you for choosing diego Banks.");
 Console.WriteLine("Type 1 to create an account");
 Console.WriteLine("Type 2 to deposit.");
 Console.WriteLine("Type 3 to withdraw.");
 Console.WriteLine("Type 4 to change name");
 Console.WriteLine("Type 5 to show account info");
 Console.WriteLine("type 6 to exit.");
 Console.WriteLine("");
 choice = Convert.ToInt32(Console.ReadLine());

    switch(choice)
    {
        case 1:
            Console.WriteLine("Please enter Your first name");
            fname = Console.ReadLine();
            Console.WriteLine("Please enter your Last Name.");
            lname = Console.ReadLine();
            Console.WriteLine("Please enter your email.");
            email = Console.ReadLine();
            Console.WriteLine("Please enter your phone number.");
            pnumber = Console.ReadLine();
            Console.WriteLine("Please enter your bank number.");
            banknumber = Console.ReadLine();
            Console.WriteLine("50 dollars are now in the account");
            

            break;
        case 2:
            Console.WriteLine("How much would you like to deposit.");
            int sum = Convert.ToInt32(Console.ReadLine());
            total = sum + total;
            Console.WriteLine("Inserted the money.");
            break;
        case 3:
            Console.WriteLine("How much would you like to Withdraw.");
            int neg = Convert.ToInt32(Console.ReadLine());
            total = total - neg;
            Console.WriteLine("Took out the money.");
            break;
        case 4: 
            Console.WriteLine("What would you like to change your name too.");
            Console.WriteLine("What is the first name now.");
            fname = Console.ReadLine();
            Console.WriteLine("what is your new last name.");
            lname = Console.ReadLine();
            break;
        case 5:
            Console.WriteLine("Here is your name: " + fname + " " + lname);
            Console.WriteLine("Here is your email: " + email);
            Console.WriteLine("Here is your phone number: " + pnumber);
            Console.WriteLine("Here is your bank number: " + banknumber);
            Console.WriteLine("Here is your current total: " + total);
            break;
        default:
            Console.WriteLine("The number is not one of the options.");
            choice = 6;
            break;
    }
}
#endregion
#region Loops
//Console.WriteLine("5. Looping");
    /*
        loops - iteration. This is when you wnat to do the same thing over and over again.
        Types of loops:
            1. For loop - a loop that goes a specific amount of times
            2. While loop - Goes until a condition is met
    */
 /*
 Console.WriteLine("Enter a number please.");
 int loopnumber = Convert.ToInt32(Console.ReadLine());
 
 int negativecount = 0;
 int positivecount = 0;
 int evencount = 0;
 int oddcount = 0;
 int count = 0;
 int over50count = 0;
 int over100count = 0;
 

 while (loopnumber != 10)
 {
    if(loopnumber %2 == 0)
    {
        evencount ++;
    }
    if(loopnumber > 0)
    {
        positivecount ++;
    }
    if(loopnumber < 0)
    {
        negativecount ++;
    }
    if(loopnumber > 100)
    {
        over100count ++;
    }
    if(loopnumber > 50 && loopnumber <= 100)
    {
        over50count ++;
    }
    if(loopnumber %2 != 0)
    {
        oddcount ++;
    }

    Console.WriteLine("Enter a number please.");
    loopnumber = Convert.ToInt32(Console.ReadLine());
    count ++;
 }

 Console.Clear();
 Console.WriteLine("Her is total numbers you put in: " + count);
 Console.WriteLine("Here are all the positive numbers: " + positivecount);
 Console.WriteLine("Here are all the negative numbers: " + negativecount);
 Console.WriteLine("Here are all the even numbers: " + evencount);
 Console.WriteLine("Here are all the odd numbers: " + oddcount);
 Console.WriteLine("Here are all the numbers between 50 and 100: " + over50count);
 Console.WriteLine("here are all the numbers over 100: " + over100count);
 
 */
 #endregion 