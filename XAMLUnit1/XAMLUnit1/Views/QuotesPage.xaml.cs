using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XAMLUnit1.Models;

namespace XAMLUnit1
{
    public partial class QuotesPage : ContentPage
    {
        Quote[] ListQuotes = new Quote[5];
        int Count;

        public QuotesPage()
        {
            InitializeComponent();
            ListQuotes[0]= new Quote("With genetic engineering, we will be able to increase the complexity of our DNA, and improve the human race. But it will be a slow process, because one will have to wait about 18 years to see the effect of changes to the genetic code.") ;
            ListQuotes[1] = new Quote("Life would be tragic if it weren't funny.");
            ListQuotes[2] = new Quote("No one undertakes research in physics with the intention of winning a prize. It is the joy of discovering something no one knew before.");
            ListQuotes[3] = new Quote("We are just an advanced breed of monkeys on a minor planet of a very average star. But we can understand the Universe. That makes us something very special.") ;
            ListQuotes[4] = new Quote("I was never top of the class at school, but my classmates must have seen potential in me, because my nickname was 'Einstein.'") ;
            Count = ListQuotes.Length;
        }
        

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Count <= 0)
            {
                Count = ListQuotes.Length;
            }

            lblQuoate.Text = ListQuotes[ListQuotes.Length - Count].QuoteText;

            if (Count > 0)
            {
                Count--;
            }

        }
    }
}
