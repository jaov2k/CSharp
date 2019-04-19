using System;
using System.Windows.Forms;

namespace minMaxApp
{
    public partial class MinMaxApp : Form
    {
        public MinMaxApp()
        {
            InitializeComponent();
            UpdateLabels();
        }

            private void WidthBox_Enter(object sender, EventArgs e)
        {
            WidthBox.Select(0,WidthBox.Text.Length);
        }

        private void WidthBox_ValueChanged(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void HeightBox_Enter(object sender, EventArgs e)
        {
            HeightBox.Select(0,HeightBox.Text.Length);
        }

        private void HeightBox_ValueChanged(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            RatioLabel.Text = $"Ratio: {(Calcs.CalcRatio(WidthBox.Value, HeightBox.Value)):0.00}";
            AreaLabel.Text = $"Area: {(Calcs.CalcArea(WidthBox.Value, HeightBox.Value)):0.00}";
            GroupLabel.Text = $"Group: {Calcs.CalcGroup(WidthBox.Value, HeightBox.Value)}";
        }
    }    
}
