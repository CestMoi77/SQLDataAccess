using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Person> people = new List<Person>();

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }
        private void UpdateBinding()
        {
            PeopleFoundListbox.DataSource = people;
            PeopleFoundListbox.DisplayMember = "FullInfo";
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(LastNameText.Text);

            UpdateBinding();
        }

        private void PeopleFoundListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LastNameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
