using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CSATSkin.WPF.Controls
{
    public class CSATSystemButton : Button
    {
        public CSATSystemButton()
        {
        }

        [Description("窗体系统按钮大小"), Category("CSATSkin")]
        public int CSATSystemButtonSize
        {
            get { return (int)GetValue(CSATSystemButtonSizeProperty); }
            set { SetValue(CSATSystemButtonSizeProperty, value); }
        }
        public static readonly DependencyProperty CSATSystemButtonSizeProperty =
            DependencyProperty.Register("CSATSystemButtonSize", typeof(int), typeof(CSATSystemButton), new PropertyMetadata(30));

        [Description("窗体系统按钮鼠标悬浮背景颜色"), Category("CSATSkin")]
        public SolidColorBrush CSATSystemButtonHoverColor
        {
            get { return (SolidColorBrush)GetValue(CSATSystemButtonHoverColorProperty); }
            set { SetValue(CSATSystemButtonHoverColorProperty, value); }
        }
        public static readonly DependencyProperty CSATSystemButtonHoverColorProperty =
            DependencyProperty.Register("CSATSystemButtonHoverColor", typeof(SolidColorBrush), typeof(CSATSystemButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(50, 50, 50, 50))));



        [Description("窗体系统按钮颜色"), Category("CSATSkin")]
        public SolidColorBrush CSATSystemButtonForeground
        {
            get { return (SolidColorBrush)GetValue(CSATSystemButtonForegroundProperty); }
            set { SetValue(CSATSystemButtonForegroundProperty, value); }
        }
        public static readonly DependencyProperty CSATSystemButtonForegroundProperty =
            DependencyProperty.Register("CSATSystemButtonForeground", typeof(SolidColorBrush), typeof(CSATSystemButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 255, 255, 255))));



        [Description("窗体系统按钮鼠标悬按钮颜色"), Category("CSATSkin")]
        public SolidColorBrush CSATSystemButtonHoverForeground
        {
            get { return (SolidColorBrush)GetValue(CSATSystemButtonHoverForegroundProperty); }
            set { SetValue(CSATSystemButtonHoverForegroundProperty, value); }
        }
        public static readonly DependencyProperty CSATSystemButtonHoverForegroundProperty =
            DependencyProperty.Register("CSATSystemButtonHoverForeground", typeof(SolidColorBrush), typeof(CSATSystemButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 255, 255, 255))));


        /// <summary>
        /// 图标
        /// </summary>
        [Description("图标"), Category("CSATSkin")]
        public Geometry Icon
        {
            get { return (Geometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(Geometry), typeof(CSATSystemButton), new PropertyMetadata(null));




        /// <summary>
        /// 图标宽度
        /// </summary>
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(CSATSystemButton), new PropertyMetadata(15.0));



        /// <summary>
        /// 图标高度
        /// </summary>
        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(CSATSystemButton), new PropertyMetadata(15.0));



    }
}
