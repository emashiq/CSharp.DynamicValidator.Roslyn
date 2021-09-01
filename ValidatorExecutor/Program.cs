using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorExecutor
{
    class Program
    {
        static void Main(string[] args)
        {
            var ValidationTest = new ValidationTest();
            ValidationTest.Execute();



        }

        
    }

    public class ValidationTest
    {
        public BusinessModel model { get; set; }
        public ValitorResultGenerator ValitorResultGenerator { get; set; } = new ValitorResultGenerator();

        public void Execute()
        {
            var _model = new BusinessModel()
            {
                Id = 1,
                LoanName = "Personal Loan",
                Age = 15,
                LoanAmount = 50000
            };
            model = _model;

            var sampleValidatorExecutor = new Validator();
            ValidationMessage message = new ValidationMessage();
            ScriptOptions.Default.WithImports("ValidatorExecutor");
            foreach (var item in sampleValidatorExecutor.Rules)
            {
                message = CSharpScript.EvaluateAsync<ValidationMessage>(item, null,this, typeof(ValidationTest)).Result;
                if (message.MessageType == MessageType.Error)
                {
                    break;
                }
            }

            if (string.IsNullOrEmpty(message.Message))
            {
                Console.WriteLine("Operation Successful");
            }
            else
            {
                Console.WriteLine($"{message.MessageType.ToString()} : {message.Message}");
            }

            Console.ReadKey();
        }
    }
}
