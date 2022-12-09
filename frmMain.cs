using System.Text;

namespace XorString
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public static string Xr(string Key, string Text)
        {
            StringBuilder sData = new StringBuilder();
            for (int i = 0; i < Text.Length; i++)
                sData.Append((char)(Text[i] ^ Key[(i % Key.Length)]));
            String result = sData.ToString();

            return result;
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMain.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string ORG = txtKey.Text;
            string mainText = txtMain.Text;
            string Xored = Xr(ORG, mainText);



            //encryption check
            if (ORG != "" &&
                mainText != "" &&
               Xr(ORG, Xored) == mainText)
            {
                txtGenerated.Text =Xored;
            }
            else
            {
                MessageBox.Show("Error Xoring !", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCopyWithCode_Click(object sender, EventArgs e)
        {
            string ORG = txtKey.Text;
            string mainText = txtMain.Text;
            string Xored = Xr(ORG, mainText);



            //encryption check
            if (ORG != "" &&
                mainText != "" &&
               Xr(ORG, Xored) == mainText)
            {
                txtGenerated.Text = Xored;
                Clipboard.SetText(Xored);
                MessageBox.Show("Copy Seccussfully And Clear!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Xoring !", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string ORG = txtKey.Text;
            string mainText = txtMain.Text;
            string Xored = Xr(ORG, mainText);



            //encryption check
            if (ORG != "" &&
                mainText != "" &&
               Xr(ORG, Xored) == mainText)
            {

                txtGenerated.Text = Xored;
                Clipboard.SetText(@" /*" + txtMain.Text + "*/Xr(\"" + txtKey.Text + "\",\"" + txtGenerated.Text + "\") ");
                MessageBox.Show("Copy Seccussfully And Clear!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Copy Error Xoring !", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}