﻿using Avalonia.Media;

namespace Paint2.Models {
    internal interface ISafe {
        public bool Valid { get; }
        public void Set(string str);
        public string Value { get; set; }
        public IBrush Color { get; }
    }
}
