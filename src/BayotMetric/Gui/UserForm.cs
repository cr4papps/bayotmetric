using System;
using System.Drawing;
using System.Windows.Forms;
using BayotMetric.Helpers;
using BayotMetric.Models;

namespace BayotMetric.Gui
{
	public partial class UserForm : Form
	{
		User user;
		
		public User User {
			get {
				user.Id = ConvertHelper.ToInt32(textBoxID.Text);
				user.Name = textBoxName.Text;
				return user;
			}
			set {
				user = value;
				textBoxID.Text = user.Id.ToString();
				textBoxName.Text = user.Name;
			}
		}
		
		public UserForm() : this("New User")
		{
		}
		
		public UserForm(string text)
		{
			InitializeComponent();
			this.Text = text;
		}
		
		void ButtonOKClick(object sender, EventArgs e)
		{
			User = new User {
				Id = ConvertHelper.ToInt32(textBoxID.Text),
				Name = textBoxName.Text,
			};
			Close();
		}
		
		void ButtonCancelClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
