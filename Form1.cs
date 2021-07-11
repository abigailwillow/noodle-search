using System;
using System.Windows.Forms;

namespace Noodle_Search {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void btn_Search_Click(object sender, EventArgs e) {
			System.Diagnostics.Process.Start($"https://www.google.com/search?q={txt_Search.Text}");
		}

		private void txt_Search_KeyDown(object sender, KeyEventArgs e) {
			if (e.KeyCode == Keys.Enter) {
				btn_Search_Click(sender, e);
			}
		}
	}
}
