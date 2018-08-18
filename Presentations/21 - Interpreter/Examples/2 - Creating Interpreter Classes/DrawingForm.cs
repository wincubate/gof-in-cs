using System;
using System.Windows.Forms;

namespace Wincubate.InterpreterExamples
{
    public partial class DrawingForm : Form
    {
        public DrawingForm()
        {
            InitializeComponent();
        }

        protected override void OnResize( EventArgs e )
        {
            base.OnResize(e);

            Invalidate(this.Region);
        }

        protected override void OnPaint( PaintEventArgs e )
        {
            base.OnPaint(e);
        }
    }
}
