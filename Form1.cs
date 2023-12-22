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
        double ChildrenCost;
        double RetiredPeopleCost;

        private void Operations()
        {
            RetiredPeopleChek();//пенсионеры
            CarloadChek();//чек по выбору вагона
            ChildChek();//чек дети
            BaggageCheck();//багаж
            Result();
        }

        private void BtnFinalBill_Click(object sender, EventArgs e)
        {
            // запуск методов
            Operations();

        }
        //подсчёт суммы от выбора рейса
        private void textFlight_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        //туда обратно true or false выбор даты полёта назад
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
        // 1% от багажа 
        private void BaggageCheck()
        {
            if (Baggage.Checked)
            {
                cost *= 1.01;
            }
        }
        //исходя из выбора типа места в поезде выбыриается оплата
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
        // метод подсчёта билетов за детей. 5%скидка
        private void ChildChek()
        {
            if (Child.Checked)
            {
                double.TryParse(ChildQuantity.Text, out double z);
                ChildrenCost = (cost * 0.95) * z;
            }
        }
        //метод подсчёиа билетов за пенсионеров. 5%скидка
        private void RetiredPeopleChek()
        {
            if (RetiredPeople.Checked)
            {
                double.TryParse(RetiredPeopleQuantity.Text, out double x);
                RetiredPeopleCost = (cost * 0.95) * x;
            }
        }
        // вкл/выкл ChildQuantity где вписывается количество детей
        private void Child_CheckedChanged(object sender, EventArgs e)
        {
            if (Child.Checked == false)
            {
                ChildQuantity.Enabled = false;
                ChildQuantity.Text = "";
            }
            else
            {
                ChildQuantity.Enabled = true;
            }
        }


        //закрытие формы
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Result()
        {
            double allCost = cost + ChildrenCost;
            // проверка того что все данные о покупателе введены
            if (string.IsNullOrWhiteSpace(textSurname.Text) || string.IsNullOrWhiteSpace(textName.Text) || string.IsNullOrWhiteSpace(textPatronymic.Text))
            {
                MessageBox.Show("Введите все данные о покупателе ", "Error");
                return;
            }
            // проверка на наличие цифер в полях имя, фамилия, отчество
            else if (!Check(textSurname.Text) || !Check(textName.Text) || !Check(textPatronymic.Text))
            {
                MessageBox.Show("Вводите только буквы в поля Фамилия, Имя и Отчество", "Error");
                return;
            }
            // проверка того что все данные о рейсе введены
            else if (string.IsNullOrWhiteSpace(textFlight.Text) || string.IsNullOrWhiteSpace(Carload.Text) || (Child.Checked && string.IsNullOrWhiteSpace(ChildQuantity.Text)))
            {
                MessageBox.Show("Введите все данные о рейсе", "Error");
                return;
            }
            // просьба пользователя убедиться в правильности введённых им данных
            else
            {
                MessageBox.Show($"Стоимость билета на взрослого = {cost}, " +
                    $"Стоимость детских билетов = {ChildrenCost}, " +
                    $"Общая стоимость = {allCost},                                 "
                    + "         Перейти к оформлению?", "Check", MessageBoxButtons.YesNo);

                return;
            }
        }

        private bool Check(string t)
        {
            return t.All(c => char.IsLetter(c));
        }
    }
}
