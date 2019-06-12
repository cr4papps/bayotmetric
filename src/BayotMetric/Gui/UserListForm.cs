using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BayotMetric.Models;

namespace BayotMetric.Gui
{
	public partial class UserListForm : Form
	{
		IList<User> users;
		
		public IList<User> Users {
			get { return users; }
			set {
				users = value;
				listView1.Items.Clear();
				foreach (var u in users) {
					ListViewItem li = listView1.Items.Add(u.Id.ToString());
					li.SubItems.Add(u.Name);
				}
			}
		}
		
		public UserListForm()
		{
			InitializeComponent();
		}
		
		void ButtonAddUserClick(object sender, EventArgs e)
		{
			using (var f = new UserForm()) {
				if (f.ShowDialog() == DialogResult.OK) {
					users.Add(f.User);
				}
			}
		}
		
		public User SelectedUser {
			get {
				if (listView1.SelectedItems.Count > 0) {
					return users[listView1.SelectedItems[0].Index];
				}
				return null;
			}
		}
		
		void ButtonEditUserClick(object sender, EventArgs e)
		{
			if (SelectedUser != null) {
				using (var f = new UserForm("Edit User")) {
					if (f.ShowDialog() == DialogResult.OK) {
						
					}
				}
			}
		}
	}
}
