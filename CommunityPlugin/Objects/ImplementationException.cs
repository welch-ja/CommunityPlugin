using System;

namespace CommunityPlugin.Objects
{
    public class ImplementationException: Exception
    {
        public ImplementationException(string EventType, string EventName, string Interface)
        : base($"{EventType} Must Implment {EventName} for {Interface}")
        { }
    }
}
