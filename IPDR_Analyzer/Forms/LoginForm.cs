using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuAnimatorNS;
using IPDR_Analyzer.Classes;
using ReadExcelApp.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPDR_Analyzer.Forms
{
    public partial class loginForm : Form
    {
        private bool isLoginPassVisible;
        private bool isRegPassVisible;
        private bool isRegRePassVisible;
        public loginForm()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsFormValid())
                {

                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("cmsp_verify_logindetails", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@username", txtUserName.Text.ToString().Trim());
                            cmd.Parameters.AddWithValue("@password", HWID.EncryptPassword(txtPassword.Text.ToString().Trim()));
                            cmd.Parameters.AddWithValue("@mid", HWID.GetMachineid());

                            if (con.State != ConnectionState.Open)
                                con.Open();

                            DataTable login = new DataTable();

                            SqlDataReader sdr = cmd.ExecuteReader();

                            login.Load(sdr);

                            if (login.Rows.Count > 0)
                            {
                                // Procure to find record
                                string procFindAppVersion = "exec dbo.[cdrsp_AppVersionInstalledTable_FindRecord] '" + txtUserName.Text.Trim() + "'";

                                // DataTable to get records
                                var dtRecordFound = await CommonMethods.getRecords(procFindAppVersion);

                                // If record already exist update it
                                if (dtRecordFound.Rows.Count >= 1)
                                {
                                    //string procUpdateRecord = "exec dbo.[cdrsp_AppVersionInstalledTable_UpdateRecord] '" + txtUserName.Text.Trim() + "', '" + APP_VERSION + "'";
                                    //CommonMethods.insertRecords(procUpdateRecord);
                                }

                                // Insert New Record
                                else
                                {
                                    //string procInsertRecord = "exec dbo.[cdrsp_AppVersionInstalledTable_InsertNewRecord] '" + txtUserName.Text.Trim() + "', '" + APP_VERSION + "'";
                                    //CommonMethods.insertRecords(procInsertRecord);
                                }

                                updateLogin_tm_tbl(txtUserName.Text.Trim());
                                Common.userName = txtUserName.Text.Trim();
                                txtUserName.Clear();
                                txtPassword.Clear();
                                Hide();
                                Dashboard db = new Dashboard();
                                db.Show();
                                /*MainForm cDRAnalyzer = new MainForm();
                                cDRAnalyzer.Show();*/
                            }
                            else
                            {
                                MessageBox.Show("Check your username and password!!");
                                txtUserName.Clear();
                                txtPassword.Clear();
                                txtUserName.Focus();
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool IsFormValid()
        {
            try
            {
                var Valid = true;
                if (txtUserName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("User Name is Required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    Valid = false;
                }
                if (txtUserName.Text.Trim().Length >= 50)
                {
                    MessageBox.Show("User Name should be less than 50!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                    Valid = false;
                }
                if (txtPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Password is Required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    Valid = false;
                }
                if (txtPassword.Text.Trim().Length >= 50)
                {
                    MessageBox.Show("Password length should be less than 50!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    Valid = false;
                }
                return Valid;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return true;
            }
        }

        private void updateLogin_tm_tbl(string user_name)
        {
            try
            {
                string proc = "exec dbo.[cdrsp_LoginTimeTable_InsertLoginTime] '" + user_name + "'";
                CommonMethods.insertRecords(proc);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (!userAlreadyExist())
                {
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("cmsp_reg_account", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@username", txtRegUserName.Text.ToString().Trim());
                            cmd.Parameters.AddWithValue("@password", HWID.EncryptPassword(txtRegPassword.Text.ToString().Trim()));
                            cmd.Parameters.AddWithValue("@mid", HWID.GetMachineid());
                            if (con.State != ConnectionState.Open)
                                con.Open();

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("User Created Successfully!");

                        }

                    }
                }
                else
                {
                    MessageBox.Show("User account already Exist", "Already Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearRegForm();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //when enter is press button login is click
                    btnLogin.PerformClick();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                BunifuTransition transition = new BunifuTransition();
                transition.HideSync(bcLogin, false,
                   Animation.Mosaic);
                transition.ShowSync(bcRegisteration, false,
                Animation.Mosaic);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            try
            {
                BunifuTransition transition = new BunifuTransition();
                transition.HideSync(bcRegisteration, false,
                   Animation.Mosaic);
                transition.ShowSync(bcLogin, false,
                Animation.Mosaic);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                bcLogin.BackColor = ThemeManager.RandomizeTheme();
                await Task.Delay(100);
                BunifuTransition transition = new BunifuTransition();
                transition.ShowSync(bcLogin, false,
                Animation.Mosaic);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void clearRegForm()
        {
            try
            {
                txtRegUserName.Clear();
                txtRegPassword.Clear();
                txtRegRePassword.Clear();
                txtRegUserName.Focus();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool IsRegFormValid()
        {
            try
            {
                var Valid = true;
                if (txtRegUserName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("User Name is Required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegUserName.Focus();
                    Valid = false;
                }
                if (txtRegUserName.Text.Trim().Length >= 50)
                {
                    MessageBox.Show("User Name should be less than 50!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegUserName.Focus();
                    Valid = false;
                }
                if (txtRegPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Password is Required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegPassword.Focus();
                    Valid = false;
                }
                if (txtRegPassword.Text.Trim().Length >= 50)
                {
                    MessageBox.Show("Password length should be less than 50!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegPassword.Focus();
                    Valid = false;
                }

                // Console.WriteLine("{0} {1}", txtPassword, txtRePassword)
                if (!Equals(txtRegRePassword.Text.Trim(), txtRegPassword.Text.Trim()))
                {
                    MessageBox.Show("Both Password Must Match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                    Valid = false;
                }
                return Valid;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void txtPassword_OnIconRightClick(object sender, EventArgs e)
        {
            try
            {
                if (isLoginPassVisible)
                {
                    txtPassword.UseSystemPasswordChar = true;
                    //txtPassword.IconRight = Resources.eye_grey;
                    isLoginPassVisible = false;
                }
                else
                {
                    txtPassword.UseSystemPasswordChar = false;
                    //txtPassword.IconRight = Resources.eye_white;
                    isLoginPassVisible = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtRegPassword_OnIconRightClick(object sender, EventArgs e)
        {
            try
            {
                if (isRegPassVisible)
                {
                    txtRegPassword.UseSystemPasswordChar = true;
                    //txtRegPassword.IconRight = Resources.eye_grey;
                    isRegPassVisible = false;
                }
                else
                {
                    txtRegPassword.UseSystemPasswordChar = false;
                    //txtRegPassword.IconRight = Resources.eye_white;
                    isRegPassVisible = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtRegRePassword_OnIconRightClick(object sender, EventArgs e)
        {
            try
            {
                if (isRegRePassVisible)
                {
                    txtRegRePassword.UseSystemPasswordChar = true;
                    //txtRegRePassword.IconRight = Resources.eye_grey;
                    isRegRePassVisible = false;
                }
                else
                {
                    txtRegRePassword.UseSystemPasswordChar = false;
                    //txtRegRePassword.IconRight = Resources.eye_white;
                    isRegRePassVisible = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtPassword_TextChange(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtRegPassword_TextChange(object sender, EventArgs e)
        {
            txtRegPassword.UseSystemPasswordChar = true;
        }

        private void txtRegRePassword_TextChange(object sender, EventArgs e)
        {
            txtRegRePassword.UseSystemPasswordChar = true;
        }

        private bool userAlreadyExist()
        {
            try
            {
                bool alreadyExist = false;
                if (IsRegFormValid())
                {
                    using (SqlConnection con = new SqlConnection(AppConnection.GetConnectionString()))
                    {
                        using (SqlCommand cmd = new SqlCommand("cmsp_account_exist", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@username", txtRegUserName.Text.ToString().Trim());
                            cmd.Parameters.AddWithValue("@mid", HWID.GetMachineid());

                            if (con.State != ConnectionState.Open)
                                con.Open();

                            DataTable login = new DataTable();

                            SqlDataReader sdr = cmd.ExecuteReader();

                            login.Load(sdr);

                            if (login.Rows.Count > 0)
                            {
                                alreadyExist = true;
                            }
                        }
                    }

                }

                return alreadyExist;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
