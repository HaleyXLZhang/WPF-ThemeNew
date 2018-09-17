using Microsoft.VisualStudio.TestTools.UnitTesting;
using DMSkin.WPF.Demos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace DMSkin.WPF.Demos.Tests
{
    [TestClass()]
    public class StartWindowTests
    {
        [TestMethod()]
        public void StartWindowTest()
        {          
            Process.Start("iexplore.exe", @"https://github.com/944095635/DMSkin-for-WPF");
        }
    }
}