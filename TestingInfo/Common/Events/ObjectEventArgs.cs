using System;

namespace Common.Events
{
    public class ObjectEventArgs : EventArgs
    {
        public readonly object Instance;

        public ObjectEventArgs( object instance)
        {
            Instance = instance;
        }
    }
}
