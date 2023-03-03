using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace дз10
{
    public partial class Form1 : Form
    {
        //Два перші завдання вже були у попередніх дз, тому я вже не копіювала код
        List<TreeNode> checkedNode = new List<TreeNode>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TopLevelMenu.Text == String.Empty)
            {
                MessageBox.Show("Wrote menu");
                return;
            }
            treeView1.Nodes.Add(TopLevelMenu.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SubItem.Text == String.Empty)
            {
                MessageBox.Show("Wrote submenu");
                return;
            }
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("select the menu");
                return;
            }
            treeView1.Nodes[treeView1.SelectedNode.Index].Nodes.Add(SubItem.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveNOde(treeView1.Nodes);
        }
        public void RemoveNOde(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Checked)
                {
                    checkedNode.Add(node);
                }
                else
                {
                    RemoveNOde(node.Nodes);
                }
            }
            foreach(TreeNode checknod in checkedNode)
            {
                nodes.Remove(checknod);
            }
        }
      
    }
}
