using FirstMVPApp.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstMVPApp
{
    public partial class FirstMVPAppView : Form
    {
        public FirstMVPAppPresenter Presenter { get; set; }

        public FirstMVPAppView()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Presenter.OnAddClicked();
        }

        public void UpdateView(double operand1, double operand2, double result)
        {
            textBoxOperand1.Text = operand1.ToString();
            textBoxOperand2.Text = operand2.ToString();
            textBoxResult.Text = result.ToString();

        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            Presenter.OnSubtractClicked();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Presenter.OnMultiplyClicked();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Presenter.OnDivideClicked();
        }

        private void textBoxOperand1_Leave(object sender, EventArgs e)
        {
            try
            {
                Presenter.OnOperand1Changed(Convert.ToDouble(textBoxOperand1.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Data error", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOperand1.Text = "0";
            }
        }

        private void textBoxOperand2_Leave(object sender, EventArgs e)
        {
            try
            {
                Presenter.OnOperand2Changed(Convert.ToDouble(textBoxOperand2.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Data error", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxOperand2.Text = "0";
            }
        }
    }
}
