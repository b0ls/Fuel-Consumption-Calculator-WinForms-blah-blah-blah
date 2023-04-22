using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.ClientSize = new Size(500, 400);
            this.Name = "Fuel Calculator";
            this.BackColor = Color.RosyBrown;

            instructions = new Label();
            instructions.Text = "Enter KM Distance, Average Fuel Consumption and Fuel Liter Cost";
            instructions.Size = new Size(320, 15);
            instructions.Location = new Point(85, 85);
            this.Controls.Add(instructions);

            output = new Label();
            output.Text = "";
            output.Size = new Size(400, 200);
            output.Location = new Point(120, 250);
            this.Controls.Add(output);

            distanceInput = new TextBox();
            distanceInput.KeyPress += textBox_KeyPress;
            distanceInput.Size = new Size(80, 20);
            distanceInput.Location = new Point(110, 150);
            distanceInput.ShortcutsEnabled = false;
            distanceInput.MaxLength = 5;
            this.Controls.Add(distanceInput);

            fuelConsumptionInput = new TextBox();
            fuelConsumptionInput.KeyPress += textBox_KeyPress;
            fuelConsumptionInput.Size = new Size(80, 20);
            fuelConsumptionInput.Location = new Point(195, 150);
            fuelConsumptionInput.ShortcutsEnabled = false;
            fuelConsumptionInput.MaxLength = 5;
            this.Controls.Add(fuelConsumptionInput);

            fuelCostInput = new TextBox();
            fuelCostInput.KeyPress += textBox_KeyPress;
            fuelCostInput.Size = new Size(80, 20);
            fuelCostInput.Location = new Point(280, 150);
            fuelCostInput.ShortcutsEnabled = false;
            fuelCostInput.MaxLength = 5; 
            this.Controls.Add(fuelCostInput);

            calculate = new Button();
            calculate.Click += button_Click;
            calculate.Size = new Size(80, 20);
            calculate.Text = "Calculate";
            calculate.Location = new Point(195, 175);
            this.Controls.Add(calculate);
        }

        TextBox distanceInput;
        TextBox fuelConsumptionInput;
        TextBox fuelCostInput;
        Button calculate;
        Label instructions;
        Label output;
        #endregion
    }
}

