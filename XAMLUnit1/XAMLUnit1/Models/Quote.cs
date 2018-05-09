using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XAMLUnit1.Models
{
  public  class Quote
    {
        public String QuoteText { get; set; }
        public Quote PreviousQuote { get; set; }
        public Quote NextQuote { get; set; }

        public Quote(String Text)
        {
            QuoteText = Text;
        }
    }
}
