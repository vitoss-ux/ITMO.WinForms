using System;
using System.Windows.Forms;

namespace MDIApplication
{
    public partial class ParentForm : Form
    {
        private int openDocuments = 0;

        public ParentForm()
        {
            InitializeComponent();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WindowCascadeMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void WindowTileMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm newChild = new ChildForm();
            newChild.Text = newChild.Text + " " + ++openDocuments;
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Tag.ToString())
            {
                case "New Doc":
                    ChildForm newChild = new ChildForm();
                    newChild.MdiParent = this;
                    newChild.Show();
                    newChild.Text = newChild.Text + " " + ++openDocuments;
                    break;
                case "Cascade":
                    LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
                    break;
                case "Title":
                    LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
                    break;
            }
        }
    }
}