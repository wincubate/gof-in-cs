using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShapesAndVisualizations
{
    public partial class ShapeForm : Form
    {
        private Shape _shape;

        public ShapeForm()
        {
            InitializeComponent();

            // TODO: Try different versions to see result

            //_shape = new SolidColorCircle( Color.Red, 100 );
            //_shape = new HatchedCircle( Color.Red, 200 );
            //_shape = new SolidColorRectangle( Color.Blue, 100, 200 );
            //_shape = new HatchedRectangle(Color.Blue, 100, 200);
        }

        protected override void OnResize( EventArgs e )
        {
            base.OnResize(e);

            Invalidate(this.Region);
        }

        protected override void OnPaint( PaintEventArgs e )
        {
            base.OnPaint(e);

            _shape?.Visualize(e.Graphics);
        }
    }
}
