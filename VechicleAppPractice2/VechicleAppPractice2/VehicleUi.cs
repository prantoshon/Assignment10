using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        public VehicleUi()
        {
            InitializeComponent();
        }

        VehiclesClass vehicles = new VehiclesClass();
        private void CreateButton_Click(object sender, EventArgs e)
        {
            vehicles.name = vehicleNameTextBox.Text;
            vehicles.reg = regNoTextBox.Text;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            vehicles.speed.Add(Convert.ToDouble(speedTextBox.Text));
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(vehicleNameTextBox.Text))
            {
                MessageBox.Show("Name is Empty");
                return;
            }
            if (String.IsNullOrEmpty(regNoTextBox.Text))
            {
                MessageBox.Show("Reg  is Empty");
                return;
            }


            maxSpeedTextBox.Text = vehicles.MaxCalculate().ToString();
            minSpeedTextBox.Text = vehicles.MinCalculate().ToString();
            averageSpeedTextBox.Text = vehicles.AvgCalculate().ToString();
        }
    }
}
