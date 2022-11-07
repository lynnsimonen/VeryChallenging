using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VeryChallenging.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BMICalculator : ContentPage
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        void Btn_BMIClicked(object sender, System.EventArgs e)
        {
            int weight = Int32.Parse(Inp_weightEditor.Text);
            int height = Int32.Parse(Inp_heightEditor.Text);
            int bmi = (weight * 703) / Convert.ToInt32(Math.Pow(height, 2));
            Lbl_BMIlabel.Text = $"Your BMI is {bmi}.";
        }
    }
}