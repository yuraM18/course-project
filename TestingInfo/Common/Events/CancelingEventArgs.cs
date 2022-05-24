using System;

namespace Common.Events
{
    public class CancelingEventArgs : EventArgs
    {
        public bool Cancel { get; set; }
        public string Message { get; set; }
    }
}
