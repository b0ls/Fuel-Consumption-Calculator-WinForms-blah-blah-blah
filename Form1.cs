using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            output.Text = $"Travel Cost: {(int.Parse(distanceInput.Text) / 100) * int.Parse(fuelConsumptionInput.Text) * int.Parse(fuelCostInput.Text)}$ | Required " +
                $"Amount of Fuel: {(int.Parse(distanceInput.Text) / 100) * int.Parse(fuelConsumptionInput.Text)} Liters";
        }
    }
}
