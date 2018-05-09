using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XAMLUnit1.Services;

namespace XAMLUnit1.ServiceImpl
{
    class PageServiceImp : IPageService
    {
        public async Task PushAsync(Page page)
        {

             await Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
