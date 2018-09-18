using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;

namespace CSATSkin.WPF
{
    public partial class ShadowWindow : Window, INotifyPropertyChanged
    {
        #region UI更新接口
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        private int _CSATWindowShadowSize = 10;
        [Description("窗体阴影大小"), Category("CSATSkin")]
        public int CSATWindowShadowSize
        {
            get
            {
                return _CSATWindowShadowSize;
            }

            set
            {
                _CSATWindowShadowSize = value;
                OnPropertyChanged("CSATWindowShadowSize");
            }
        }

        private Color _CSATWindowShadowColor = Color.FromArgb(255, 200, 200, 200);
        [Description("窗体阴影颜色"), Category("CSATSkin")]
        public Color CSATWindowShadowColor
        {
            get
            {
                return _CSATWindowShadowColor;
            }

            set
            {
                _CSATWindowShadowColor = value;
                OnPropertyChanged("CSATWindowShadowColor");
            }
        }


        private Brush _CSATWindowShadowBackColor = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        [Description("窗体阴影背景颜色"), Category("CSATSkin")]
        public Brush CSATWindowShadowBackColor
        {
            get
            {
                return _CSATWindowShadowBackColor;
            }

            set
            {
                _CSATWindowShadowBackColor = value;
                OnPropertyChanged("CSATWindowShadowBackColor");
            }
        }

        public ShadowWindow()
        {
            InitializeComponent();
            DataContext = this;
            SourceInitialized += MainWindow_SourceInitialized;
        }

        private void MainWindow_SourceInitialized(object sender, EventArgs e)
        {
            IntPtr Handle = new WindowInteropHelper(this).Handle;
            int exStyle = (int)NativeMethods.GetWindowLong(Handle, -20);
            exStyle = NativeConstants.WS_EX_TOOLWINDOW;
            NativeMethods.SetWindowLong(Handle, -20, (IntPtr)exStyle);
        }
    }
}
