using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region ***** Methods *****

        private void ChosePicture()
        {
            if (lblVendor.Text == "American Express")
            {
                object logo = Properties.Resources.ResourceManager.GetObject("AmericanExpress");
                pbVendor.Image = (Image)logo;
            }

            else if (lblVendor.Text == "JCB")
            {
                object logo = Properties.Resources.ResourceManager.GetObject("JCB");
                pbVendor.Image = (Image)logo;
            }

            else if (lblVendor.Text == "Maestro")
            {
                object logo = Properties.Resources.ResourceManager.GetObject("Maestro");
                pbVendor.Image = (Image)logo;
            }

            else if (lblVendor.Text == "MasterCard")
            {
                object logo = Properties.Resources.ResourceManager.GetObject("MasterCard");
                pbVendor.Image = (Image)logo;
            }

            else if (lblVendor.Text == "VISA")
            {
                object logo = Properties.Resources.ResourceManager.GetObject("Visa");
                pbVendor.Image = (Image)logo;
            }

            else
            {
                object logo = Properties.Resources.ResourceManager.GetObject("kottans");
                pbVendor.Image = (Image)logo;
            }

        }

        private bool ValidationCheck(TextBox tb)
        {
            lblIsCreditCardNumberValid.Text = BankOperation.IsCreditCardNumberValid(tb.Text).ToString(); // for test
            lblGetCreditCardVendor.Text = BankOperation.GetCreditCardVendor(tb.Text);                    // for test


            if (BankOperation.IsCreditCardNumberValid(tb.Text))
            {
                lblVendor.Text = BankOperation.GetCreditCardVendor(tb.Text);
                if (lblVendor.Text != "Unknown")
                {
                    lblValid.Text = "Номер валідний";
                    object check = Properties.Resources.ResourceManager.GetObject("true");
                    pbCheck.Image = (Image)check;
                    ChosePicture();
                    return true;
                }
                else
                {
                    lblValid.Text = "Номер не валідний";
                    object check = Properties.Resources.ResourceManager.GetObject("false");
                    pbCheck.Image = (Image)check;
                    ChosePicture();
                    return false;
                }
            }

            else
            {
                lblVendor.Text = "Unknown";
                lblValid.Text = "Номер не валідний";

                object logo = Properties.Resources.ResourceManager.GetObject("kottans");
                pbVendor.Image = (Image)logo;

                object check = Properties.Resources.ResourceManager.GetObject("false");
                pbCheck.Image = (Image)check;
                return false;
            }
        }

        #endregion

        #region ***** Events *****

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbInput.Text))
                    return;

                ValidationCheck(tbInput);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                tbInput.Clear();
                tbGenerator.Clear();

                lblVendor.Text = "Unknown";
                lblValid.Text = "Unknown";

                object check = null;
                pbCheck.Image = (Image)check;

                ChosePicture();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("V1.2\n10.05.2016\nRoman Kovalchuk\nroman@kovalchuk.eu", "Тестове завдання для kottans.org");
        }

        private void btnGenerator_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbInput.Text))
                    return;

                if (ValidationCheck(tbInput))
                {
                    if (String.IsNullOrEmpty(tbGenerator.Text))
                        tbGenerator.Text = tbInput.Text;
                    tbGenerator.Text = BankOperation.GenerateNextCreditCardNumber(tbGenerator.Text);
                    ValidationCheck(tbGenerator);
                }
                else
                {
                    MessageBox.Show("Новий номер можна згенерувати тільки на основі існуючого валідного.");
                }
            }
            catch { }
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            try { e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsDigit(e.KeyChar); }
            catch (Exception) { }
        }

        #endregion

        private void btnDel_Click(object sender, EventArgs e)
        {
            tbGenerator.Text = "";
        }
    }
}
