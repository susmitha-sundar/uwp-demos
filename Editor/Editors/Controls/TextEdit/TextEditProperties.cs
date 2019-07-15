#region Copyright Syncfusion Inc. 2001-2019.
// Copyright Syncfusion Inc. 2001-2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Common;
using Syncfusion.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editors
{
    public class TextBoxExtProperties : NotificationObject
    {
        private string watermark = "Type here";

        public string Watermark
        {
            get { return watermark; }
            set { watermark = value; RaisePropertyChanged("Watermark"); }
        }

    }
}
