using NewEraDepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewEra.DepoSimu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            //this.Text = DM.ProjectName + "-RAFLAR";
            this.CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }


        private void RafClick(object sender ,EventArgs e)
        {
            Button btn = (Button)sender;
            FormRafDetay frd = new FormRafDetay();
            frd.ShowDialog();
            switch (btn.Name)
            {
                case "btnRafA":
                   // frd.Init("A RAFI",7,50);
                    break;
                case "btnRafB":
                    frd.Init( "B RAFI",6,20);
                    break;
                default:
                    break;
            }

           
        }

     

       
    }
}
