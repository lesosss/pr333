using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        double ChildrenCost;
        double RetiredPeopleCost;
        double PasashirCost;
        double End;

        private void Operations()
        {
            RetiredPeopleChek();//пенсионеры
            ChildChek();//чек дети
            PasashirChek(); //чек пасажиры
            CarloadChek();//чек по выбору вагона
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
                PasashirCost += 2000;
            }

            else if (textFlight.Text == "Moscow - Saint - Petersburg")
            {
                PasashirCost += 3000;
            }

            else if (textFlight.Text == "Moscow - Magadan")
            {
                PasashirCost += 2500;
            }

            else
            {
                PasashirCost += 3000;
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
                PasashirCost *= 2;
                ChildrenCost *= 2;
                RetiredPeopleCost *= 2;
            }
        }
        // 1% от стоимости билета 
        private void BaggageCheck()
        {
            if (Baggage.Checked)
            {
                PasashirCost *= 1.01;
                ChildrenCost *= 1.01;
                RetiredPeopleCost *= 1.01;
            }
        }
        //исходя из выбора типа места в поезде выбыриается оплата
        private void CarloadChek()
        {
            if (Carload.Text == "Купе")
            {
                PasashirCost *= 1.2;
                ChildrenCost *= 1.2;
                RetiredPeopleCost *= 1.2;
            }
            else if (Carload.Text == "СВ")
            {
                PasashirCost *= 1.4;
                ChildrenCost *= 1.4;
                RetiredPeopleCost *= 1.4;
            }
            else if (Carload.Text == "Плацкарт")
            {
                PasashirCost *= 1.6;
                ChildrenCost *= 1.6;
                RetiredPeopleCost *= 1.6;
            }
            else if (Carload.Text == "Для инвалидов")
            {
                PasashirCost *= 1.4;
                ChildrenCost *= 1.4;
                RetiredPeopleCost *= 1.4;
            }
        }
        // метод подсчёта билетов за детей. 5%скидка
        private void ChildChek()
        {
            if (Child.Checked)
            {
                double.TryParse(ChildQuantity.Text, out double z);
                ChildrenCost = (PasashirCost * 0.95) * z;
            }
        }
        //метод подсчёиа билетов за пенсионеров. 5%скидка
        private void RetiredPeopleChek()
        {
            if (RetiredPeople.Checked)
            {
                double.TryParse(RetiredPeopleQuantity.Text, out double x);
                RetiredPeopleCost = (PasashirCost * 0.95) * x;
            }
        }
        private void PasashirChek()
        {
            if (Pasashir.Checked)
            {
                double.TryParse(PasashirQuantity.Text, out double x);
                PasashirCost = (PasashirCost) * x;
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
        // вкл/выкл PasashirQuantity где вписывается количество пасажиров

        private void Pasashir_CheckedChanged(object sender, EventArgs e)
        {
            if (Pasashir.Checked == false)
            {
                PasashirQuantity.Enabled = false;
                PasashirQuantity.Text = "";
            }
            else
            {
                PasashirQuantity.Enabled = true;
            }
        }
        // вкл/выкл RetiredPeopleQuantity где вписывается количество пенсионеров
        private void RetiredPeople_CheckedChanged(object sender, EventArgs e)
        {
            if (RetiredPeople.Checked == false)
            {
                RetiredPeopleQuantity.Enabled = false;
                RetiredPeopleQuantity.Text = "";
            }
            else
            {
                RetiredPeopleQuantity.Enabled = true;
            }
        }



        //закрытие формы
        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Result()
        {
            double allCost =  ChildrenCost+ RetiredPeopleCost+ PasashirCost;
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
            
            // проверка того что данные о рейсе  введены
            else if (string.IsNullOrWhiteSpace(textFlight.Text))
            {
                MessageBox.Show("Введите все данные о рейсе", "Error");
                return;
            }
            
            // проверка того что  данные о типе вагона введены
            else if (string.IsNullOrWhiteSpace(Carload.Text))
            {
                MessageBox.Show("Введите все данные о рейсе", "Error");
                return;
            }
            
            // проверка того что  данные количество детей введены
            else if (Child.Checked && string.IsNullOrWhiteSpace(ChildQuantity.Text))
            {
                MessageBox.Show("Введите количество детских билетов", "Error");
                return;
            }

            // проверка того что  данные количество взрослых введены
            else if (Pasashir.Checked && string.IsNullOrWhiteSpace(PasashirQuantity.Text))
            {
                MessageBox.Show("Введите количество взрослых билетов", "Error");
                return;
            }

            // проверка того что  данные количество пенсионеров введены
            else if (RetiredPeople.Checked && string.IsNullOrWhiteSpace(RetiredPeopleQuantity.Text))
            {
                MessageBox.Show("Введите количество билетов для пенсионеров", "Error");
                return;
            }

            // просьба пользователя убедиться в правильности введённых им данных
            else
            {
                MessageBox.Show($"Стоимость билета на взрослого = {PasashirCost}, " +
                    $"Стоимость детских билетов = {ChildrenCost}, " +
                    $"Стоимость билетов для пенсионеров = {RetiredPeopleCost}, " +
                    $"Общая стоимость = {allCost},                                  "
                    + "         Перейти к оформлению?", "Check", MessageBoxButtons.YesNo);

                return;
            }
        }

        private bool Check(string t)
        {
            return t.All(c => char.IsLetter(c));
        }

        //настройка даты 
        private void DataThere_ValueChanged(object sender, EventArgs e)
        {
            if (DataThere.Value < DateTime.Today)
            {
                DataThere.Value = DateTime.Today;
            }

            if (DataBack.Value < DateTime.Today)
            {
                DataBack.Value = DateTime.Today;
            }
        }

    }//готово
}
