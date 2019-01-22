using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Media;
using System.Diagnostics;

namespace budzik
{
    public partial class Form1 : Form
    {

        DateTime aktualny_czas;

        DateTime alarm_czas;

        DateTime koniec_alarmu;

        DateTime wylacz_czas;

        bool alarm;

        private TimeSpan czastrwania;

        private SoundPlayer dzwonek = new SoundPlayer("Windows Ringin.wav");
        
        public Form1()
        {
            InitializeComponent();

            aktualny_czas = new DateTime();
            alarm_czas = new DateTime();
            koniec_alarmu = new DateTime();

            wylacz_czas = new DateTime();

            czastrwania = new TimeSpan(0, 1, 0);

            alarm = false;
            timer.Start();
            

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            aktualny_czas = DateTime.Now;
            lblAktualnyCzas.Text = aktualny_czas.ToString("T");
//alarm
            if (alarm && aktualny_czas.Hour == alarm_czas.Hour && 
                alarm_czas.Minute == aktualny_czas.Minute && 
                aktualny_czas.Second == alarm_czas.Second)
            {
                btnAlarm.Text = "STOP";
                koniec_alarmu = DateTime.Now.Add(czastrwania);
                dzwonek.PlayLooping();
            }


            if (koniec_alarmu.Hour == aktualny_czas.Hour &&
                   koniec_alarmu.Minute == aktualny_czas.Minute &&
                   koniec_alarmu.Second == aktualny_czas.Second)
            {
                btnAlarm.Text = "UstawAlarm";
                dzwonek.Stop();
            }


            //wylaczanie
            if ( aktualny_czas.Hour == wylacz_czas.Hour &&
                wylacz_czas.Minute == aktualny_czas.Minute &&
                aktualny_czas.Second == wylacz_czas.Second)
            {
                btnAlarm.Text = "BYE BYE";

                Process.Start("shutdown.exe", "-s -t 00");
            }


        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
          //  Form1.ActiveForm.Visible = false;
            if (btnAlarm.Text == "UstawAlarm")
            {
                txtAlarm.Visible = true;
                txtAlarm.Enabled = true;
                txtAlarm.Text = aktualny_czas.ToString("T");
                txtAlarm.Focus();
                btnAlarm.Text = "OK";
            }

            else if (btnAlarm.Text == "OK")
            {
                DateTime tmpAlarm = new DateTime();

                try
                {
                    tmpAlarm = DateTime.Parse(txtAlarm.Text);
                }
                catch (Exception ex)
                {
                    btnAlarm.Text = "UstawAlarm";
                    txtAlarm.Visible = false;
                    MessageBox.Show(ex.Message);
                    return;
                }

                alarm_czas = tmpAlarm;
                btnAlarm.Text = "UstawAlarm";
                txtAlarm.Enabled = false;
                alarm = true;
            }

            else if (btnAlarm.Text == "STOP") //gdy alarm gra
            {
                dzwonek.Stop();
                btnAlarm.Text = "UstawAlarm";
                txtAlarm.Visible = false;
            }
        }

        private void wyswietlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordForm password = new PasswordForm();

            password.ShowDialog();

            if (password.passwdOK == true)
            {
               // password.Close();
                this.Visible = true;
                this.WindowState = FormWindowState.Normal;
            }
           
        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();  //ukrywa w menadzerze urzadzen
               // this.Visible = false;

            }
        }

        private void btnWylacz_Click(object sender, EventArgs e)
        {

            if (btnWylacz.Text == "UstawWylacz")
            {
                txtWylacz.Visible = true;
                txtWylacz.Enabled = true;
                txtWylacz.Text = aktualny_czas.ToString("T");
                txtWylacz.Focus();
                btnWylacz.Text = "OK";
            }

            else if (btnWylacz.Text == "OK")
            {
                DateTime tmpAlarm = new DateTime();

                try
                {
                    tmpAlarm = DateTime.Parse(txtWylacz.Text);
                }
                catch (Exception ex)
                {
                    btnWylacz.Text = "UstawWylacz";
                    txtWylacz.Visible = false;
                    MessageBox.Show(ex.Message);
                    return;
                }

                wylacz_czas = tmpAlarm;
                btnWylacz.Text = "UstawWylacz";
                txtWylacz.Enabled = false;
              //  alarm = true;
            }

        }
    }
}
