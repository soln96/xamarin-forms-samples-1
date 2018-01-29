﻿using System;
using Xamarin.Forms;

namespace FormsVideoLibrary
{
    public class VideoSourceConverter : TypeConverter
    {
        public override object ConvertFromInvariantString(string value)
        {
            System.Diagnostics.Debug.WriteLine("String equals " + value);

            if (!String.IsNullOrWhiteSpace(value))
            {
                Uri uri;
                return Uri.TryCreate(value, UriKind.Absolute, out uri) && uri.Scheme != "file" ? 
                                VideoSource.FromUri(value) : VideoSource.FromResource(value);
            }

            throw new InvalidOperationException(String.Format("Cannot convert null or whitespace to ImageSource"));
        }
    }
}
