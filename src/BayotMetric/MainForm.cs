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
			
			// Menu
			exitToolStripMenuItem.Click += delegate { Close(); };
			
			usersListToolStripMenuItem.Click += delegate { AddChild(new UserListForm()); };
			addUserToolStripMenuItem.Click += delegate { AddChild(new UserForm()); };
			
			aboutToolStripMenuItem.Click += delegate { AddDialog(new AboutForm()); };
			
			// Toolbar
			toolStripButtonUsers.Click += delegate { AddChild(new UserListForm()); };
			toolStripButtonAddUser.Click += delegate { AddChild(new UserForm()); };
			
			toolStripButtonClose.Click += delegate { Close(); };
			
			var v = new Version(Application.ProductVersion);
			Text = Text += string.Format(" {0}.{1}", v.Major, v.Minor);
		}
		
		public void AddChild(Form f)
		{
			f.MdiParent = this;
			f.Show();
		}
		
		public DialogResult AddDialog(Form f)
		{
			f.MinimizeBox = f.MaximizeBox = f.ShowInTaskbar = false;
			f.StartPosition = FormStartPosition.CenterParent;
			return f.ShowDialog();
		}
	}
}
