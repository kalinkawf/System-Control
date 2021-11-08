using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMM_GUI1
{
    public partial class Form1 : Form
    {
        SortedSet<int> tabIdx;
        int globalTabIdx;
        public Form1()
        {
            tabIdx = new SortedSet<int>();
            globalTabIdx = 1;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTab(tabControl1);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            var tc = (TabControl)sender;
            if (tc.SelectedIndex == tc.TabCount - 1)
            {
                CreateTab(tc);
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                for (int i = 0; i < tabControl1.TabPages.Count-1; i++)
                {
                    if (tabControl1.GetTabRect(i).Contains(e.Location) && tabControl1.TabPages.Count > 2)
                    {
                        tabIdx.Remove((int)(tabControl1.TabPages[i].Tag));
                        tabControl1.TabPages.RemoveAt(i);
                    }
                }
            }
        }

        private void CreateTab(TabControl tc)
        {
            int idx = GetNextAvailableIdx();
            idx = GetNextGlobalIdx();
            var tmp = new TabPage("Page " + idx.ToString());
            tabIdx.Add(idx);
            tmp.Tag = idx;
            ScControl sc = new ScControl();
            sc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sc.Top = tmp.Top;
            sc.Left = tmp.Left;
            sc.Width = tmp.Width;
            sc.Height = tmp.Height;
            tmp.Controls.Add(sc);
            tmp.BackColor = Color.White;
            tc.TabPages.Insert(tc.TabCount - 1, tmp);
            tc.SelectedIndex = tc.TabCount - 2;
        }


        private int GetNextAvailableIdx()
        {
            int previousIdx = 0;
            foreach (int idx in tabIdx)
            {
                if (idx > previousIdx + 1)
                {
                    return previousIdx + 1;
                }
                previousIdx = idx;
            }
            return previousIdx + 1;
        }

        private int GetNextGlobalIdx()
        {
            return globalTabIdx++;
        }
    }
}
