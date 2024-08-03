using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyUC.Forms;

namespace Test_C_
{
    public partial class BitMap : frmScreen
    {
        public BitMap()
        {
            InitializeComponent();
            base.Refresh();
            _RefreshTime(DateTime.Now);
        }


        private void ctrlFramedTextBox1_Leave(object sender, EventArgs e)
        {
            label1.Text = ctrlFramedTextBox1.IsValid.ToString();
        }

        private void BitMap_UsernameClicked(object sender, EventArgs e)
        {
            label1.Text = "Hi nigga";
        }
    }
}
