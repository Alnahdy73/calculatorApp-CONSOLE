Console.WriteLine("Inter the firest number : ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Inter the Opration (+,-,*,/,%) : ");
string opration = "";

 opration = Console.ReadLine();



Console.WriteLine("Inter the Secand number : ");
double num2 = Convert.ToDouble(Console.ReadLine());

double result = 0;

switch (opration)
{

    case "+": 
        result = num1+num2; 
        break;
    case "-":
        result = num1 - num2;
        break;
    case "*":
        result = num1 * num2;
        break;
    case "/":
        result = num1 / num2;
        break;
    case "%":
        result = num1 % num2;
        break;
        default:
        Console.WriteLine("Invald Opration !!!!!!!!!!!!!!!!!! ");
        return; 
   
}

Console.WriteLine($"Result Is : {result}");



