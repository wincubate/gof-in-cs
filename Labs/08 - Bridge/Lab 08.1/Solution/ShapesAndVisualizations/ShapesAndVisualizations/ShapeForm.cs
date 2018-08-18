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

            //IShapeVisualizer visualizer = new SolidColorVisualizer(Color.Red);
            //IShapeVisualizer visualizer = new HatchedVisualizer(Color.Red);
            //_shape = new Circle( visualizer, 100 );

            //IShapeVisualizer visualizer = new SolidColorVisualizer(Color.Blue);
            //IShapeVisualizer visualizer = new HatchedVisualizer(Color.Blue);
            //_shape = new Rectangle( visualizer, 100, 200 );

            //IShapeVisualizer visualizer = new SolidColorVisualizer(Color.Green);
            //IShapeVisualizer visualizer = new HatchedVisualizer(Color.Green);
            //IShapeVisualizer visualizer = new GradientVisualizer(Color.Green);
            //_shape = new Square(visualizer, 200);
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
