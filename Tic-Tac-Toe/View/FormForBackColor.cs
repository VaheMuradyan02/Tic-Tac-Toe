using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe.View
{
    public partial class FormForBackColor : Form
    {
        public FormForBackColor()
        {
            InitializeComponent();
            
            InitializeColorList();

            
        }

        private void InitializeColorList()
        {
            var list = checkedListBox1;


            /*var colorType = typeof(Color);

            PropertyInfo[] properties = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo property in properties)
            {
                list.Items.Add(property.Name);
            }*/

            //var colors = new List<Color>();
            //list.SetSelected = Enum.GetNames(typeof(KnownColor));

            foreach (var item in Enum.GetNames(typeof(KnownColor)))
            {

                list.Items.Add(item);
            }

            list.Click += (object sender1, EventArgs e1) =>
            {
                int idx = list.SelectedIndex;
                for (int i = 0; i < list.Items.Count; i++)
                {
                    if (i != idx)
                    {
                        list.SetItemChecked(i, false);
                        BackColor = Color.FromName(list.SelectedItem.ToString());
                    }
                }
            };
        }

        private void FormForBackColor_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            var list = checkedListBox1;
            var mainf = this.Owner;


            mainf.BackColor = Color.FromName(list.SelectedItem.ToString());

            ActiveForm.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
