using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using System.Collections.ObjectModel;

namespace Tarea2._2

{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {

            var drawingView = new DrawingView
            {
                Lines = new ObservableCollection<IDrawingLine>(),
                LineColor = Colors.Red,
                LineWidth = 5
            };


        }
    }
}
