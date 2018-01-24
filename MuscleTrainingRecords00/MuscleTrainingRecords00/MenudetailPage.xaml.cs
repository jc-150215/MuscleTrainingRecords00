using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MuscleTrainingRecords00
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenudetaliPage : ContentPage
    {
        string n;
        public MenudetaliPage(String m, String d,String i)//String m
        {
            InitializeComponent();


            Transition.Text = m.Trim();

            Description.Text = d;

            //image.Source = new Uri(i);


            n = m;
        }

        private void addItemButton_Clicked(object sender, EventArgs e)
        {
            RecordsModel.InsertRe(n);
            Navigation.PushAsync(new RecordListPage()); //n

        }

        /*public MenudetaliPage(String l)
        {
        this.l = l;
        }*/
    }
}