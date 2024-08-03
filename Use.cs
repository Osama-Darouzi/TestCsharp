using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_C_
{
    public partial class Use : Control
    {
        public Use()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;

            g.FillEllipse(Brushes.Aquamarine, 0, 0, 0, 0);
            base.OnPaint(pe);
        }
    }
}
