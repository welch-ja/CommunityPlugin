using System.Collections.Generic;

namespace CommunityPlugin.Objects.Interface
{
    public interface IFactory
    {
        List<ITask> GetTriggers();
    }
}
