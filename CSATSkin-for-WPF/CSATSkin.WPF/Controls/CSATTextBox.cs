﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CSATSkin.WPF.Controls
{
    public class CSATTextBox : TextBox
    {
        public string Hint
        {
            get { return (string)GetValue(HintProperty); }
            set { SetValue(HintProperty, value); }
        }
        public static readonly DependencyProperty HintProperty =
            DependencyProperty.Register("Hint", typeof(string), typeof(CSATTextBox), new PropertyMetadata(""));
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(CSATTextBox), new PropertyMetadata(new CornerRadius(2)));
        public Geometry Icon
        {
            get { return (Geometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(Geometry), typeof(CSATTextBox), new PropertyMetadata(null));
        public bool ShowIcon
        {
            get { return (bool)GetValue(ShowIconProperty); }
            set { SetValue(ShowIconProperty, value); }
        }
        public static readonly DependencyProperty ShowIconProperty =
            DependencyProperty.Register("ShowIcon", typeof(bool), typeof(CSATTextBox), new PropertyMetadata(false));


        /// <summary>
        /// 图标宽度
        /// </summary>
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(CSATTextBox), new PropertyMetadata(15.0));



        /// <summary>
        /// 图标高度
        /// </summary>
        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(CSATTextBox), new PropertyMetadata(15.0));


        //public double ShadowBlurRadius
        //{
        //    get { return (double)GetValue(ShadowBlurRadiusProperty); }
        //    set { SetValue(ShadowBlurRadiusProperty, value); }
        //}
        //public static readonly DependencyProperty ShadowBlurRadiusProperty =
        //    DependencyProperty.Register("ShadowBlurRadius", typeof(double), typeof(CSATTextBox), new PropertyMetadata(0.0));
        ///// <summary>
        ///// 是否显示阴影
        ///// </summary>
        //public bool ShowShadow
        //{
        //    get { return (bool)GetValue(ShowShadowProperty); }
        //    set { SetValue(ShowShadowProperty, value); }
        //}
        //public static readonly DependencyProperty ShowShadowProperty =
        //    DependencyProperty.Register("ShowShadow", typeof(bool), typeof(CSATTextBox), new PropertyMetadata(false));

        public SolidColorBrush SelectedColor
        {
            get { return (SolidColorBrush)GetValue(SelectedColorProperty); }
            set { SetValue(SelectedColorProperty, value); }
        }
        public static readonly DependencyProperty SelectedColorProperty =
            DependencyProperty.Register("SelectedColor", typeof(SolidColorBrush), typeof(CSATTextBox), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 124, 125, 133))));



    }
}
