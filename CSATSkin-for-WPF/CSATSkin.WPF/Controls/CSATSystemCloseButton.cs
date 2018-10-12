using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CSATSkin.WPF.Controls
{
    public class CSATSystemCloseButton : CSATSystemButton
    {
        Window targetWindow;
        public CSATSystemCloseButton()
        {
            CSATSystemButtonHoverColor = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));

            Click += delegate{
                if (targetWindow==null)
                {
                    targetWindow = Window.GetWindow(this);
                }
                targetWindow.Close();
            };
        }
    }
}
