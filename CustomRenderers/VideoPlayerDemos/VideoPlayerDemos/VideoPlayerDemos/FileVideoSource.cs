﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsVideoLibrary
{
    public class FileVideoSource : VideoSource
    {
        public static readonly BindableProperty FileProperty =
                  BindableProperty.Create("File", typeof(string), typeof(FileVideoSource));

        public string File
        {
            set { SetValue(FileProperty, value); }
            get { return (string)GetValue(FileProperty); }
        }
    }
}
