using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Elevator_Tycoon.Custom
{
    public sealed partial class PositionAdornment : UserControl
    {
        public PositionAdornment()
        {
            this.InitializeComponent();
        }

        public void UpdateLabelsAndReposition(double x, double y, double z)
        {
            lblX.Text = x.ToString();
            lblY.Text = y.ToString();
            lblZ.Text = z.ToString();

            this.Margin = new Thickness((x + 50), (y - 50), 0, 0);
        }
    }

    
}
