using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pr333
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //
        double cost;
        //double chlCost;

        private void Operations()
        {
            //FlightCh();
            CarloadChek();
            //ChilCh();
            //BagCh();
            //CheckingData();
        }

        private void BtnFinalBill_Click(object sender, EventArgs e)
        {
            // запуск методов
            Operations();
        }

        private void textFlight_SelectedIndexChanged(object sender, EventArgs e)
        { //подсчёт суммы от выбора рейса
            if (textFlight.Text == "Moscow - Ekaterinburg")
            {
                cost += 2000;
            }

            else if (textFlight.Text == "Moscow - Saint - Petersburg")
            {
                cost += 3000;
            }

            else if (textFlight.Text == "Moscow - Magadan")
            {
                cost += 2500;
            }

            else
            {
                cost += 3000;
            }
        }

        private void ThereBack_CheckedChanged(object sender, EventArgs e)
        {
            if (ThereBack.Checked == false)
            {
                DataBack.Enabled = false;
            }
            else
            {
                DataBack.Enabled = true;
            }
        }

        private void BaggageCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (BaggageCheck.Checked)
            {
                cost *= 1.02;
            }
        }

        private void CarloadChek()
        {
            if (Carload.Text == "Купе")
            {
                cost *= 1.2;
            }
            else if (Carload.Text == "СВ")
            {
                cost *= 1.4;
            }
            else if (Carload.Text == "Плацкарт")
            {
                cost *= 1.6;
            }
            else if (Carload.Text == "Для инвалидов")
            {
                cost *= 1.7;
            }
        }
    }
}