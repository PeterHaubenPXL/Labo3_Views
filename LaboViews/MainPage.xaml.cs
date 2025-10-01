using Microsoft.Maui.Controls;

namespace LaboViews
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTapGestureRecognizerTapped(object sender, TappedEventArgs e)
        {
            if (sender is Border border)
            {
                if (border.BackgroundColor == Colors.Black)
                {
                    border.BackgroundColor = Colors.DarkSlateGray;
                }
                else
                {
                    border.BackgroundColor = Colors.Black;
                }
            }
        }

        private async void OnTapGestureRecognizerTapped_AnimateY(object sender, TappedEventArgs e)
        {
            if (sender is Border border)
            {
                await border.RotateYTo(360, 2000);
                
                border.RotationY = 0; // Terug op 0 zetten,
                                        // anders blijt y op 360° staan
                                        // en de rotatie wordt niet meer uitgevoerd
            }
        }

        private async void OnTapGestureRecognizerTapped_AnimateX(object sender, TappedEventArgs e)
        {
            if (sender is Border border)
            {
                await border.RotateXTo(360, 1000);
                border.RotationX = 0; // Terug op 0 zetten,
                                      // anders blijt y op 360° staan
                                      // en de rotatie wordt niet meer uitgevoerd
            }
        }

    }

}
