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
    public partial class MovingRectangleForm : Form
    {

        private RectangleF movingRectangle;
    private SizeF direction;
    Timer timer = new Timer();

    public MovingRectangleForm()
    {
            InitializeComponent();
        this.DoubleBuffered = true;

        // Initialize the rectangle and direction
        this.movingRectangle = new RectangleF(100, 100, 50, 50);
        this.direction = new SizeF((float)1.5, 0);

        // Initialize the timer
        this.timer.Interval = 1; // Move every 100 ms
        this.timer.Tick += Timer_Tick;
        this.timer.Start();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
        // Move the rectangle
        this.movingRectangle.Location = PointF.Add(this.movingRectangle.Location, this.direction);

        // Redraw the form
        this.Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Draw the rectangle
        e.Graphics.FillRectangle(Brushes.Black, this.movingRectangle);
    }
    }
}
