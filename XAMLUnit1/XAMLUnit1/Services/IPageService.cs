using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAMLUnit1.Services
{
    public interface IPageService
    {
        Task PushAsync(Page page);
    }
}
