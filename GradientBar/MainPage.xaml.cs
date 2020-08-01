using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GradientBar
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void XSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            MainGuage.RotationX = e.NewValue * 360;
        }

        private void YSlider_ValueChanged_1(object sender, ValueChangedEventArgs e)
        {
            MainGuage.RotationY = e.NewValue * 360;
        }

        private void StartColour_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                MainGuage.FrontColorFrom = Color.FromHex(e.NewTextValue);
            }
            catch(Exception m)
            {

            }
        }

        private void EndColour_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                MainGuage.FrontColorTo = Color.FromHex(e.NewTextValue);
            }
            catch (Exception m)
            {

            }
        }
        private void BackColour_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                MainGuage.BackColor = Color.FromHex(e.NewTextValue);
            }
            catch (Exception m)
            {

            }
        }

        private void Stroke_Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            MainGuage.StrokeWidth = (float)Convert.ToInt32(e.NewTextValue);
        }

        private void Radial_Switch_Toggled(object sender, ToggledEventArgs e)
        {
            MainGuage.IsRadial = e.Value;
        }

        private void Rouned_Switch_Toggled(object sender, ToggledEventArgs e)
        {
            MainGuage.UseRoundedBorders = e.Value;
        }

        private void StartAngle_Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            MainGuage.StartAngle = (float)e.NewValue * 360;
        }

        private void Progreess_Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            MainGuage.Progress = (float)e.NewValue;
        }

        private void Stroke_Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            MainGuage.StrokeWidth = (float)e.NewValue * 100;
        }

        private void RSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            MainGuage.Rotation = e.NewValue * 360;
        }
    }
}
