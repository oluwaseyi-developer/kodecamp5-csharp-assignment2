// SOLUTION TO QUESTION 1

string word1 = "Hello";
string word2 = "World";

object statement = word1 + " " + word2;
Console.WriteLine(statement);


// SOLUTION TO QUESTION 2A
bool isLoggedIn = true;
bool isAdmin = false;

bool result1 = isLoggedIn && isAdmin;
Console.WriteLine($"result of logical AND = {result1}");


// SOLUTION TO QUESTION 2B
bool result2 = isLoggedIn || isAdmin;
Console.WriteLine($"result of logical OR = {result2}");

// SOLUTION TO QUESTION 2C
bool result3 = !isAdmin;
Console.WriteLine($"result of logical NOT = {result3}");


// SOLUTION TO QUESTION 3
int num = 10;

if(num % 2 == 0)
{
    Console.WriteLine($"{num} is an even number");
}
else {
    Console.WriteLine($"{num} is an odd number");
}


// SOLUTION TO QUESTION 4A
int hour = 19;

if(hour >= 0 && hour < 12)
{
    Console.WriteLine($"it's {hour}am");
}
else if(hour >= 12 && hour < 18)
{
    Console.WriteLine($"it's {hour}pm");
}
else if(hour >= 18 && hour < 24)
{
    Console.WriteLine($"it's {hour}pm");
}
else
{
    Console.WriteLine("Invalid hour");
}


// SOLUTION TO QUESTION 4B, 4C, 4D
switch(hour)
{
    case < 12:
        Console.WriteLine("Good Morning");
        break;
    case < 18:
        Console.WriteLine("Good Afternoon");
        break;
    case < 24:
        Console.WriteLine("Good Evening");
        break;
    default:
        Console.WriteLine("Invalid hour");
        break;
}



// SOLUTION TO QUESTION 5
Console.Write("What is your birth year? : ");
int birthYear = int.Parse(Console.ReadLine());

Console.Write("What is the current year? : ");
int currentYear = int.Parse(Console.ReadLine());

int age = currentYear - birthYear;

Console.WriteLine($"Age = {age}");



// SOLUTION TO QUESTION 6
Console.Write("What's your age? : ");
int userAge = int.Parse(Console.ReadLine());

if (userAge >= 18)
{
    Console.WriteLine("You are eligible to vote.");
}
else
{
    Console.WriteLine("You are not eligible to vote.");
}



// SOLUTION TO QUESTION 7
int num1 = 9;
int num2 = 3;

int answer = num1 + num2;

Console.Write($"What is {num1} + {num2} ? : ");
int userAnswer = int.Parse(Console.ReadLine());

if (userAnswer == answer)
{
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine($"Incorrect! The correct answer was {answer}.");
}



// SOLUTION TO QUESTION 8
Console.Write("Provide your first number: ");
double userFirstNumber = double.Parse(Console.ReadLine());

Console.Write("Provide your second number: ");
double userSecondNumber = double.Parse(Console.ReadLine());

Console.Write("Provide an operator (+, -, *, /): ");
string userOperator = Console.ReadLine();

double result = 0;

switch (userOperator)
{
    case "+":
        result = userFirstNumber + userSecondNumber;
        Console.WriteLine($"{userFirstNumber} + {userSecondNumber} = {result}");
        break;
    case "-":
        result = userFirstNumber - userSecondNumber;
        Console.WriteLine($"{userFirstNumber} - {userSecondNumber} = {result}");
        break;
    case "*":
        result = userFirstNumber * userSecondNumber;
        Console.WriteLine($"{userFirstNumber} * {userSecondNumber} = {result}");
        break;
    case "/":
        if (userSecondNumber != 0)
        {
            result = userFirstNumber / userSecondNumber;
            Console.WriteLine($"{userFirstNumber} / {userSecondNumber} = {result}");
        }
        else
        {
            Console.WriteLine("Error! Cannot divide by zero.");
            
        }
        break;
    default:
        Console.WriteLine("Invalid operator.");
        return; // Exit the program for invalid operator
}



// SOLUTION TO QUESTION 9
Console.Write("Enter your score here: ");
int userScore = int.Parse(Console.ReadLine());

if (userScore >= 90 && userScore <= 100)
{
    Console.WriteLine("You got an A!");
}
else if (userScore >= 80 && userScore < 90)
{
    Console.WriteLine("You got a B!");
}
else if (userScore >= 70 && userScore < 80)
{
    Console.WriteLine("You got a C!");
}
else if (userScore >= 60 && userScore < 70)
{
    Console.WriteLine("You got a D!");
}
else if (userScore >= 0 && userScore < 60)
{
    Console.WriteLine("You got an F!");
}
else
{
    Console.WriteLine("Invalid score entered.");
}



// SOLUTION TO QUESTION 10
Console.Write("Enter a number: ");
int userNumber1 = int.Parse(Console.ReadLine());

Console.Write("Enter another number: ");
int userNumber2 = int.Parse(Console.ReadLine());

Console.Write("Enter another number: ");
int userNumber3 = int.Parse(Console.ReadLine());

int sum = userNumber1 + userNumber2 + userNumber3;

Console.WriteLine($"{userNumber1} + {userNumber2} + {userNumber3} = {sum}");




// SOLUTION TO QUESTION 11
Console.Write("Enter Company Name: ");
string companyName = Console.ReadLine();

Console.Write("Enter Company Address: ");
string companyAddress = Console.ReadLine();

Console.Write("Enter Company Phone Number: ");
string companyPhoneNumber = Console.ReadLine();

Console.Write("Enter Company Fax Number: ");
int companyFaxNumber = int.Parse(Console.ReadLine());

Console.Write("Enter Company Website: ");
string companyWebsite = Console.ReadLine();

Console.Write("Enter Company Manager Name: ");
string companyManagerName = Console.ReadLine();

Console.Write("Enter Company Manager Surname: ");
string companyManagerSurname = Console.ReadLine();

Console.Write("Enter Company Manager Phone Number: ");
string companyManagerPhoneNumber = Console.ReadLine();


Console.WriteLine("\n--- Company and Manager Information ---");
Console.WriteLine($"Company Name: {companyName}");
Console.WriteLine($"Address: {companyAddress}");
Console.WriteLine($"Phone Number: {companyPhoneNumber}");
Console.WriteLine($"Fax Number: {companyFaxNumber}");
Console.WriteLine($"Website: {companyWebsite}");
Console.WriteLine($"Manager: {companyManagerName} {companyManagerSurname}");
Console.WriteLine($"Manager Phone: {companyManagerPhoneNumber}");



// SOLUTION TO QUESTION 12
Console.Write("Enter A Number: ");
int userInputNumber = int.Parse(Console.ReadLine());

Console.Write("Enter Another Number: ");
int userInputNumber2 = int.Parse(Console.ReadLine());

if (userInputNumber > userInputNumber2)
{
    Console.WriteLine($"{userInputNumber} is greater");
}
else
{
    Console.WriteLine($"{userInputNumber2} is greater");
}



// SOLUTION TO QUESTION 13

int sumNumber = 0;
int count = 0;

Console.WriteLine("Enter Five Integer Numbers: ");

while(count < 5)
{
    Console.Write($"Enter Number {count + 1}: ");
    string userPreferedNum = Console.ReadLine();

    if(int.TryParse(userPreferedNum, out int userNum))
    {
        sumNumber += userNum;
        count++;
    }
    else
    {
        Console.WriteLine("Error! Enter A Valid Number");
    }
}

Console.WriteLine($"The sum of the five integers = {sumNumber}");