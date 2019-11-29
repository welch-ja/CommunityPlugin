using System.Drawing;
using System.Windows.Forms;

namespace CommunityPlugin.Objects.Interface
{
    public interface IMenuItemBase
    {
        ToolStripItem CreateToolStripMenu(Image image, string Name);
    }
}
