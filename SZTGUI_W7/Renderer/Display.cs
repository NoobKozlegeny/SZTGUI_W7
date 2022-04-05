using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using SZTGUI_W7.Logic;

namespace SZTGUI_W7.Renderer
{
    public class Display : FrameworkElement
    {
        IGameModel model;
        double areaWidth;
        double areaHeight;
        public void SetupModel(IGameModel model)
        {
            this.model = model;
            model.Position=areaWidth / 2;
        }
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (model != null && areaWidth > 50 && areaHeight > 50)
            {
                if (model.Position>0 && (model.Position + areaWidth / 7)<areaWidth)
                {
                    drawingContext.DrawRectangle(Brushes.Red, null, new Rect(model.Position, areaHeight - areaHeight / 20, areaWidth / 7, areaHeight / 20));
                }
                else if (model.Position <= 0)
                {
                    drawingContext.DrawRectangle(Brushes.Red, null, new Rect(0, areaHeight - areaHeight / 20, areaWidth / 7, areaHeight / 20));
                }else if(model.Position + areaWidth / 7 >= areaWidth)
                {
                    drawingContext.DrawRectangle(Brushes.Red, null, new Rect(areaWidth-areaWidth/7, areaHeight - areaHeight / 20, areaWidth / 7, areaHeight / 20));
                }
                
            }
        }
        public void Resize(double width, double height)
        {
            this.areaWidth = width;
            this.areaHeight = height;
            this.InvalidateVisual();
        }
    }
}
