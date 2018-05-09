using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMLUnit1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoGalleryApp : ContentPage
    {
        private int Current = 1;
        private String Url = "http://lorempixel.com/1920/1080/city/";

        public PhotoGalleryApp()
        {
            InitializeComponent();

            imageBack.Source = new UriImageSource()
            {
                Uri = new Uri(Url + Current),
                CachingEnabled = false,
                CacheValidity = TimeSpan.FromHours(1)
            };

        }

        private void Previous_Button(object sender, EventArgs e)
        {
            if(Current==1)
            {
                Current = 10;
            }
            else
            {
                Current-=1;
            }


            imageBack.Source = new UriImageSource()
            {
                Uri = new Uri(Url + Current),
                CachingEnabled = false,
                CacheValidity = TimeSpan.FromHours(1)
            };
        }

        private void Next_Button(object sender, EventArgs e)
        {
            if (Current == 10)
            {
                Current = 1;
            }
            else
            {
                Current += 1;
            }


            imageBack.Source = new UriImageSource()
            {
                Uri = new Uri(Url + Current),
                CachingEnabled = false,
                CacheValidity = TimeSpan.FromHours(1)
            };
        }

    }
}