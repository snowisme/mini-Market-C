using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniMarket.GUI
{
    public partial class NotifyForm : Form
    {
        public NotifyForm()
        {
            InitializeComponent();
        }

        Timer timer1 = new Timer();
        public enum AlertAction
        {
            Wait,
            Start,
            Close
        }

        public enum AlertType
        {
            Success,
            Warning,
            Error,
            Information
        }

        private AlertAction action;
        private int x;
        private int y;

        public void SetAlertFor(string msg)
        {
            lblAlertFor.Text = msg;
        }

        public void ShowAlert(string msg)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fName;

            for (int i = 1; i < 10; i ++)
            {
                fName = "alert" + i.ToString();

                NotifyForm frm = (NotifyForm) Application.OpenForms[fName];

                if (frm == null)
                {
                    this.Name = fName;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            this.lblMsg.Text = msg;
            this.Show();
            this.action = AlertAction.Start;
            this.timer1.Interval = 1;
            timer1.Start();
        }

        private void NotifyForm_Load(object sender, EventArgs e)
        {
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case AlertAction.Wait:
                    timer1.Interval = 5000;
                    action = AlertAction.Close;
                    break;
                case AlertAction.Start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = AlertAction.Wait;
                        }
                    }
                    break;
                case AlertAction.Close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0)
                    {
                        base.Close();
                    }
                    break;
            }
        }
    }
}
