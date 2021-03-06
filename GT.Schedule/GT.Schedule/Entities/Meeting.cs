﻿using System;
using Xamarin.Forms;

namespace GT.Schedule.Entities
{
    /// <summary>   
    /// Represents custom data properties.   
    /// </summary>   
    public class Meeting
    {
        public string EventName { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Color Color { get; set; }
    }
}