using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ValidatorExecutor
{
    public class Validator
    {
        public List<string> Rules { get; set; } = new List<string>();
        public Validator()
        {
            Rules.Add(@"
                    if(model.Age < 18)
                    {
                        return ValitorResultGenerator.Error(""Under 18 age is not allowed for loan"");
                    }
                ");
            Rules.Add(@"
                    if(model.Age < 18)
                    {
                        return ValitorResultGenerator.Error(""Under 18 age is not allowed for loan"");
                    }
                    if(model.Age > 40 && model.LoanAmount > 30000)
                    {
                        return ValitorResultGenerator.Error(""40 years aged person is not eligble for ""+model.LoanAmount+"" Loan"");
                    }
                ");
        }
    }
}
