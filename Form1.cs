using NuGet.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServisTime
{
    
    public partial class Form1 : Form
    {
        private Bl servis;

        public Form1()
        {
            InitializeComponent();
            //  this.Text += " " + Properties.Resources.String1; //  Settings.Default.Version; //Добавляем в название программы, версию.
            textBoxNunMinutes.Text = Properties.Resources.GetMinutsDef;
        }

        //Запуск сервиса
        private void btStartServise_Click(object sender, EventArgs e)
        {
            servis = new Bl();
            servis.StartService();
        }

        //Остановка сервиса
        private void bеStopServis_Click(object sender, EventArgs e)
        {
            servis = new Bl();
            servis.StopService();
        }

        //Перезапуск службы
        private void btRestart_Click(object sender, EventArgs e)
        {
            servis = new Bl();
            servis.RestartService();
        }

        //Выход
        private void bTCloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Событие ентера. При нажатии на ввод
        private void BTCloseApp_Enter(object sender, EventArgs e)
        {
            //int n;
            //if (int.TryParse(textBoxNunMinutes.Text, out n))
            //{
            //    MessageBox.Show("Введено число!");
            //    servis.InitMinutes(n);
            //}
                
            //else 
            //{  
            //    MessageBox.Show("Введено не число!");
            //}

            //// textBoxNunMinutes.Text = "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNunMinutes_Enter(object sender, EventArgs e)
        {
            //int n;
            //if (int.TryParse(textBoxNunMinutes.Text, out n))
            //{
            //    MessageBox.Show("Введено число!");
            //    servis.InitMinutes(n);
            //}

            //else
            //{
            //    MessageBox.Show("Введено не число!");
            //}

            //// textBoxNunMinutes.Text = "";

        }

        private void textBoxNunMinutes_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            servis = new Bl();
            int n;
            if (int.TryParse(textBoxNunMinutes.Text, out n))
            {
                MessageBox.Show("Введено число!");
                servis.InitMinutes(n);
               // Properties.Resources.GetMinutsDef  = "100";
              //  Properties.Resources.Culture = "1";
            }

            else
            {
                MessageBox.Show("Введено не число!");
            }

           
        }
    }
}
