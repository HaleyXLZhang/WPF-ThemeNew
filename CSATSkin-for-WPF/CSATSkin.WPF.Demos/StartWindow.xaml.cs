using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace CSATSkin.WPF.Demos
{
    public partial class StartWindow
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void WPFConvertList_Loaded(object sender, RoutedEventArgs e)
        {
            List<MessageModel> models = new List<MessageModel>();
            for (int i = 0; i < 30; i++)
            {
                MessageModel model = new MessageModel();
                //model.CallBackTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //model.CallNature = "Call Nature";
                model.Index = i + 1;
                model.CompanyRole = "EE";
                model.DateTime = "2018-10-21 13:23:1" + i.ToString();
                model.ERID = i.ToString();
                //model.FirstCallDateTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //model.FirstCallResult = "OK";
                //model.FirstCSO = "Clerk";
                model.Function = "Funct";
                model.HKID_Membership = "HKID";
                model.Language = "C";
                model.Name = "Haley";
                //model.Operator = "Haley";
                //model.SecondCallDateTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //model.SecondCallResult = "OK";
                //model.SecondCSO = "Clerk";
                model.SpecialReturnCallTime = true;
                //model.Status = "Yes";
                //model.TargetFollowUpFrequency = "TargetFollowUpFrequency";
                model.Tel = "15991655524";
                //model.ThirdCallDateTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                //model.ThirdCallResult = "ok";
                //model.ThirdCSO = "Haley" + i;
                model.Title = "Manager";
                model.Urgent = "Urgent";

                models.Add(model);

            }

            this.WPFConvertList.ItemsSource = models;
            this.WPFConvertList.ColumnFromDisplayIndex(0).Header = "";

            


        }
        public List<T> GetVisualChild<T>(DependencyObject parent, Func<T, bool> predicate) where T : Visual
        {
            List<T> items = new List<T>();
            int numVisuals = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < numVisuals; i++)
            {
                DependencyObject v = (DependencyObject)VisualTreeHelper.GetChild(parent, i);
                T child = v as T;
                if (child == null)
                {
                    List<T> temp = new List<T>();

                    temp = GetVisualChild<T>(v, predicate);

                    if (temp != null) items.AddRange(temp);
                }
                else
                {
                    if (predicate(child)) items.Add(child);
                }
            }
            return items;
        }
        private void cbbSelALL_Click(object sender, RoutedEventArgs e)
        {
            List<CheckBox> chbs = GetVisualChild<CheckBox>(WPFConvertList, v => v.Name == "cbsel");
            CheckBox mainChb = (CheckBox)sender;
            if (null != mainChb)
            {
                if (Convert.ToBoolean(mainChb.IsChecked))
                {
                    mainChb.IsChecked = true;

                    if (null != chbs)
                    {
                        foreach (CheckBox chb in chbs)
                        {
                            chb.IsChecked = true;
                        }
                    }
                }
                if (!Convert.ToBoolean(mainChb.IsChecked))
                {
                    mainChb.IsChecked = false;

                    if (null != chbs)
                    {
                        foreach (CheckBox chb in chbs)
                        {
                            chb.IsChecked = false;
                        }

                    }
                }
            }
        }

      
    }

    public class MessageModel
    {
        public int Index { get; set; }
        public string DateTime { get; set; }
        public string Function { get; set; }
        public string CompanyRole { get; set; }
        public string Language { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string ERID { get; set; }
        public string HKID_Membership { get; set; }
        public string Tel { get; set; }
        public string Urgent { get; set; }
        public bool SpecialReturnCallTime { get; set; }
        //public string CallBackTime { get; set; }
        //public string CallNature { get; set; }
        //public string Operator { get; set; }
        //public string FirstCallDateTime { get; set; }
        //public string FirstCallResult { get; set; }
        //public string FirstCSO { get; set; }
        //public string SecondCallDateTime { get; set; }
        //public string SecondCallResult { get; set; }
        //public string SecondCSO { get; set; }
        //public string ThirdCallDateTime { get; set; }
        //public string ThirdCallResult { get; set; }
        //public string ThirdCSO { get; set; }
        //public string TargetFollowUpFrequency { get; set; }
        //public string Status { get; set; }
    }
}
