// See https://aka.ms/new-console-template for more information
using LeaningApp;
using LeaningApp.LINQ;
using System.Text;
using System.Threading.Tasks.Dataflow;


var options = new StringBuilder();
options.AppendLine("Select you option?");
options.AppendLine("1 - Test Dynamic type.");
options.AppendLine("2 - Linq Test");
options.AppendLine("3 - Entity Frameowork DB update test");
options.AppendLine("4 - Test Yield");
options.AppendLine("5 - Test Tuple");
options.AppendLine("6 - Test Extension method");
options.AppendLine("7 - Test Array");
options.AppendLine("8 - Test Delegate");
options.AppendLine("9 - Binary Search");
options.AppendLine("10 - Bubble Sort");
options.AppendLine("11 - Factorial");

Console.WriteLine(options.ToString());
var option=Console.ReadLine();

var inputVal = string.Empty;
switch (option)
{
    case "1":
        DynamicExample.GetInstance().VerifyDynamicTypeInRuntime();
        break;
    case "2":
        LinqQuryExamples.GetInstance().PrintEvennumbers();
        LinqQuryExamples.GetInstance().PrintJoin2Sequences();
        LinqQuryExamples.GetInstance().LinqLet();
        break;
    case "3":
        break;
    case "4":
        break;
    case "5":
        break;
    case "6":
        break;
    case "7":
        break;
    case "8":
        break;
    case "9":
        Console.WriteLine("What to find?");
        var val = Console.ReadLine();
        BinarySearch.GetInstance().FindIndex(Int32.Parse(val));
        break;
    case "10":
        BubbleSort.GetInstance().SortArray();
        break;
    case "11":
        Console.WriteLine("Enter the Number");
        inputVal = Console.ReadLine();
        Factorial.GetInstance().PrintFactorial(Int32.Parse(inputVal));
        break;

    default:
        break;
}

