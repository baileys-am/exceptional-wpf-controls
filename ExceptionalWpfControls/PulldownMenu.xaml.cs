using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExceptionalWpfControls
{
    /// <summary>
    /// Interaction logic for PulldownMenu.xaml
    /// </summary>
    public partial class PulldownMenu : ComboBox
    {
        public PulldownMenu()
        {
            InitializeComponent();

            this.MouseMove += PulldownMenu_MouseMove;
            this.MouseUp += PulldownMenu_MouseUp;
            this.MouseLeave += PulldownMenu_MouseLeave;
        }

        ~PulldownMenu()
        {
            this.MouseMove -= PulldownMenu_MouseMove;
            this.MouseUp -= PulldownMenu_MouseUp;
            this.MouseLeave -= PulldownMenu_MouseLeave;
        }

        protected override void OnDropDownOpened(EventArgs e)
        {
            base.OnDropDownOpened(e);
        }

        private void PulldownMenu_MouseMove(object sender, MouseEventArgs e)
        {
            double yDiff = e.GetPosition(this).Y - this.Height;
            this.MaxDropDownHeight = Math.Max(0.0, yDiff);
        }

        private void PulldownMenu_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.IsDropDownOpen = false;
        }

        private void PulldownMenu_MouseLeave(object sender, MouseEventArgs e)
        {
            this.IsDropDownOpen = false;
        }
    }
}
