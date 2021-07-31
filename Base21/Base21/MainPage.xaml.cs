using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Base21
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<FileImageSource> imageSources = new ObservableCollection<FileImageSource>();   
        
        public MainPage()
        {
            InitializeComponent();
            imageSources.Add("img1.png");
            imageSources.Add("img2.png");
            imageSources.Add("img3.png");
            imageSources.Add("img4.png");

            imgSlider.Images = imageSources;

            
            btncSamsung.Clicked += BtncSamsung_Clicked;
            btncCaterpillar.Clicked += BtncCaterpillar_Clicked;
            btncTablets.Clicked += BtncTablets_Clicked;
            
        }

        private void BtncTablets_Clicked(object sender, EventArgs e)
        {
            avisoAsync();
        }

        private void BtncCaterpillar_Clicked(object sender, EventArgs e)
        {
            avisoAsync();
        }

        public async Task avisoAsync() {
            await DisplayAlert("Alert", "You have been alerted", "OK");
        }

        private void BtncSamsung_Clicked(object sender, EventArgs e)
        {
            avisoAsync();
        }
    }
}
