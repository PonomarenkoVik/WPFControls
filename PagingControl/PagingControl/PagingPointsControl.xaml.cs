using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PagingControl
{
    /// <summary>
    /// Interaction logic for PagingPointsControl.xaml
    /// </summary>
    public partial class PagingPointsControl : UserControl
    {
        public PagingPointsControl()
        {
            InitializeComponent();
        }

        public double PointDiameter { get; set; } = 6;
        public double MinPointDiameter { get; set; } = 3;

        private int _currentPoint;
        private int _from;
        public void SetPointsNumber(int currentPoint, int from)
        {
            _currentPoint = currentPoint;
            _from = from;
            DrawPoints();
        }



        private void DrawPoints()
        {
            double d;
            if (_from * (PointDiameter + 0.5 * PointDiameter) > this.Width)
	        {
                d = (this.Width/_from)/1.5;
                d = d < MinPointDiameter ? MinPointDiameter : d;
            }
            else
                d = PointDiameter;

            double x = (this.Width - (_from * d * 1.5) - 2.2 * d)/2;
            //Canv.Children.Clear();
            for (int i = 0; i < _from; i++)
            {
                x += d * 1.5;
                Ellipse ell = new Ellipse() { Width = d, Height = d, Stroke = Foreground, StrokeThickness = 1};
                if (i + 1 == _currentPoint)
                    ell.Fill = Foreground;

                ell.SetValue(Canvas.LeftProperty, x);
                ell.SetValue(Canvas.TopProperty, Height / 2 - d / 2);
                //Canv.Children.Add(ell);
            }

        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
        }

    }
}
