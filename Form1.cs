using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyUC.Forms;

namespace Test_C_
{
    public partial class Form1 : frmScreen
    {
        SqlConnection conn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
            
        }
        Random rnd = new Random();

        GraphicsPath graphics;

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Tag = label1;
            graphics = new GraphicsPath();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.ShowBalloonTip(10000, "HI", "hi", ToolTipIcon.Info);
        }
    }
}
