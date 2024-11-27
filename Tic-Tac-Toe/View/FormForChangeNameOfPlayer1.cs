using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Tic_Tac_Toe.View
{
    public partial class FormForChangeNameOfPlayer1 : Form
    {
        private int previousTextLength = 0;

        public FormForChangeNameOfPlayer1()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;

            Type formType = form1.GetType();
            FieldInfo labelField = formType.GetField("Player1", BindingFlags.NonPublic | BindingFlags.Instance);

            Label label = (Label)labelField.GetValue(form1);
            label.Text = textBox1.Text;

            ActiveForm.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > previousTextLength && textBox1.Text.Length > 10)
            {
                textBox1.Text = textBox1.Text.Substring(0, 10);
                textBox1.SelectionStart = textBox1.Text.Length;
            }

            previousTextLength = textBox1.Text.Length;
        }
    }
}
