using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BayotMetric.Gui;

namespace BayotMetric
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
			exitToolStripMenuItem.Click += delegate { Close(); };
			
			usersListToolStripMenuItem.Click += delegate { AddChild(new UserListForm()); };
			addUserToolStripMenuItem.Click += delegate { AddChild(new UserForm()); };
			
			aboutToolStripMenuItem.Click += delegate { new AboutForm().ShowDialog(); };
		}
		
		public void AddChild(Form f)
		{
			f.MdiParent = this;
			f.Show();
		}
	}
}
