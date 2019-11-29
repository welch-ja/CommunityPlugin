using CommunityPlugin.Objects.Interface;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CommunityPlugin.Non_Native_Modifications.TopMenu
{
    public abstract class MenuItemBase : IMenuItemBase
    {
        internal ToolStripMenuItem menuItem;
        public abstract bool CanRun();

        public ToolStripItem CreateToolStripMenu(Image image, string Name)
        {
            menuItem = new ToolStripMenuItem(Name);
            menuItem.Image = image;
            menuItem.Click += new EventHandler(menuItem_Click);
            return (ToolStripItem)menuItem;
        }
        protected abstract void menuItem_Click(object sender, EventArgs e);
    }
}