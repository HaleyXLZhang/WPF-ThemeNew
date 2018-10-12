using CSATSkin.WPF.API;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Input;
using System.Windows.Media;

namespace CSATSkin.WPF.Demos.ViewModels
{
    public class StartWindowViewModel:ViewModelBase
    {
        public ICommand ComplexWindowCommand
        {
            get
            {
                return new DelegateCommand(obj =>
                {
                    //UI线程执行
                    Execute.OnUIThread(() =>
                    {
                        new ComplexWindow().Show();
                    });
                });
            }
        }

        public ICommand SimpleWindowCommand
        {
            get
            {
                return new DelegateCommand(obj =>
                {
                    new SimpleWindow().Show();
                });
            }
        }



        private Color _CSATWindowShadowColor;

        /// <summary>
        /// 窗体阴影颜色
        /// </summary>
        public Color CSATWindowShadowColor
        {
            get { return _CSATWindowShadowColor; }
            set
            {
                _CSATWindowShadowColor = value;
                OnPropertyChanged("CSATWindowShadowColor");
            }
        }

        public ICommand ChangeWindowCommand
        {
            get
            {
                return new DelegateCommand(obj =>
                {
                    CSATWindowShadowColor = (Color)ColorConverter.ConvertFromString(obj.ToString());
                });
            }
        }



        public ICommand OpenLinkCommand
        {
            get
            {
                return new DelegateCommand(obj =>
                {
                    if (obj is string url)
                    {
                 //  string ss=     System.Web.HttpUtility.UrlDecode(url, System.Text.Encoding.GetEncoding("UTF-8"));


                        Process.Start("iexplore.exe", url);
                       

                       
                    }
                });
            }
        }

    }
}
