using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace CSATSkin.WPF.Controls
{
    public class CSATLinkButton : CSATSystemButton
    {
        public bool CSATDisplayLine
        {
            get { return (bool)GetValue(CSATDisplayLineProperty); }
            set { SetValue(CSATDisplayLineProperty, value); }
        }
        public static readonly DependencyProperty CSATDisplayLineProperty =
            DependencyProperty.Register("CSATDisplayLine", typeof(bool), typeof(CSATLinkButton), new PropertyMetadata(true));
    }
}
