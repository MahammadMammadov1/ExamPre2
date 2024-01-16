using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPre2.Business.CustomExceptions
{
    public class FeaturesNullException : Exception
    {
        public string Prop { get; set; }
        public FeaturesNullException()
        {
        }

        public FeaturesNullException(string ex,string? message) : base(message)
        {
            ex = Prop;
        }
    }
}
