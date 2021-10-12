using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCoffeeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoffeeEquipmentPage : ContentPage
    {
        public CoffeeEquipmentPage()
        {
            InitializeComponent();
        }
        int count = 0;
        private void btnClick_Clicked(object sender, System.EventArgs e)
        {
            count++;
            lblEquipment.Text = $"Uou have clicked me {count} times";
;
        }
        

        
    }
}