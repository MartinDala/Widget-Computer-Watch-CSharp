using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
namespace Widget
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Para o programa iniciar com o Windows
            //try
            //{
            string local= "HKLM\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
                RegistryKey key = Registry.OpenSubKey(local, true);
                //C: \Users\Martin Dala\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup
                //HKCU.
                key.SetValue("Kabayte Widget", @"bin\Widget.exe");
            //}
            //catch (Exception x)
            //{
                //MessageBox.Show(x.Message);
            //}
           
            //Para pegar o nome do Pc e  mostrar em uma label
            lbNomePc.Text = System.Windows.Forms.SystemInformation.ComputerName;


        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //Para desligar o pc
            Process.Start("shutdown /p");

        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Para Reiniciar o pc
            Process.Start("shutdown r");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Mostrar as datas,horas apartir do pc
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblData.Text = DateTime.Now.ToShortDateString();

            //Traduzir o DayOfWeek
            CultureInfo myCI = new CultureInfo("pt-BR");
            //MessageBox.Show(myCI.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek));
            lblSemana.Text = myCI.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }
    }
}
