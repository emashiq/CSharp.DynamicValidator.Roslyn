using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidatorExecutor
{
    public class BusinessModel
    {
        public int Id { get; set; }
        public string LoanName { get; set; }
        public UInt16 Age { get; set; }
        public decimal LoanAmount { get; set; }
    }
}
