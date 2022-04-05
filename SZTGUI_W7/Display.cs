using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace SZTGUI_W7
{
    public class Display : FrameworkElement
    {
        double areaWidth;
        double areaHeight;
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            drawingContext.DrawRectangle(Brushes.Red, null, new Rect(areaWidth / 2, areaHeight - areaHeight/20, areaWidth / 7, areaHeight /20 ));
        }
        public void Resize(double width, double height)
        {
            this.areaWidth = width;
            this.areaHeight = height;
            this.InvalidateVisual();
        }
    }
}
