using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPazigFramework.Model
{
    class Expense
    {   
        public int ExpenseId { get; set; }
        public int PersonId { get; set; }
        public int GroupId { get; set; }
        public int Amount { get; set; }
    }
}
