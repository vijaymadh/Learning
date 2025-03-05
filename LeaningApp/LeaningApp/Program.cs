// See https://aka.ms/new-console-template for more information
using LeaningApp;
using LeaningApp.LINQ;
using System.Text;


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

Console.WriteLine(options.ToString());
var option=Console.ReadLine();

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
    default:
        break;
}

