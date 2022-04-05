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
using SZTGUI_W7.Controller;
using SZTGUI_W7.Logic;

namespace SZTGUI_W7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameController controller;
        PongLogic pongLogic;
        public MainWindow()
        {
            InitializeComponent();
            pongLogic = new PongLogic();
            //display.SetupModel(pongLogic);
            controller = new GameController(pongLogic);
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            display.Resize(grid.ActualWidth, grid.ActualHeight);
            display.InvalidateVisual();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            controller.KeyPressed(e.Key);
            display.InvalidateVisual();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            display.Resize(grid.ActualWidth, grid.ActualHeight);
            display.SetupModel(pongLogic);
            display.InvalidateVisual();
        }
    }
}
