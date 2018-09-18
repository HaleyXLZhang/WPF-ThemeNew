using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CSATSkin.WPF.Controls
{
    public class CSATSystemMinButton : CSATSystemButton
    {
        Window targetWindow;
        public CSATSystemMinButton()
        {
            Click += delegate
            {
                if (targetWindow == null)
                {
                    targetWindow = Window.GetWindow(this);
                }
                targetWindow.WindowState = WindowState.Minimized;
            };
        }
    }
}
