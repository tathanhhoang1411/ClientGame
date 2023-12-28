using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace AppLuckyNumber_Client_
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        public Form1()
        {
            InitializeComponent();
            txtPassWord.PasswordChar = '*';
            txtAccount.Focus();
        }

        private async void btnDK_Click(object sender, EventArgs e)
        {
            try
            {
                bool isAllDigits = CheckIfAllDigits(txtAccountDK.Text.Trim());

                if (txtAccountDK.Text.Trim().Length !=10 || !isAllDigits)
                {
                    MessageBox.Show(this,"Account( là SDT) của bạn chưa hợp lệ", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                if (txtHVT.Text.Trim() == "")
                {
                    MessageBox.Show(this, "Không để tên trống", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                if (dtPicNgaySinh.Value.Year == DateTime.Now.Year)
                {
                    MessageBox.Show(this, "Chọn ngày sinh hợp lệ", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }          
                if (txtPasswordDK.Text.Trim().Length<=2)
                {
                    MessageBox.Show(this, "Mật khẩu phải nhiều hơn 2 kí tự", "Cảnh báo", MessageBoxButtons.OK);
                    return;
                }
                string accountDK= txtAccountDK.Text.Trim();
                string name= txtHVT.Text.Trim();
                var  birthday = dtPicNgaySinh.Value;
                string passwordDK = txtPasswordDK.Text.Trim();
                bool result=await CallAPIRegiterAccount(name, accountDK, passwordDK, birthday);
                if (result)
                {
                MessageBox.Show(this, "Đăng kí tài khoản: " +accountDK+" thành công !", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(this, "Đăng kí tài khoản: " + accountDK + " thất bại !", "Thông báo", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {

            }
        }
        //kiểm tra là  chuỗi số hay không
        static bool CheckIfAllDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
        //gửi yêu cầu tạo tài khoản
        private async Task<bool> CallAPIRegiterAccount(string name,string account, string password,DateTime birthday)
        {
            try
            {
                string birthdayNew = birthday.ToString("dd/MM/yyyy").Trim().Replace("/", "%2F");
                xNet.HttpRequest http = new xNet.HttpRequest();
                string result = http.Post("http://tahoang111-001-site1.btempurl.com/api/Accounts/NewAccount?name=" + name.Trim() + "&phone="+account.Trim() + "&pass="+password.Trim() + "&birthDay="+ birthdayNew.Trim()).ToString();
                string resultIDWallet = http.Post("http://tahoang111-001-site1.btempurl.com/api/Walletes/NewWallet?phone=" + account.Trim()).ToString();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        private async void btnDN_Click(object sender, EventArgs e)
        {
            try
            {
                string account = txtAccount.Text.Trim();
                string password = txtPassWord.Text.Trim();
                string loginInfo = await CallAPIGetAccount(account, password);
                if (loginInfo!="")//đúng thì mở form đặt cược
                {
                    this.Hide();
                    //mở form mới
                    FormMain fromMain=new FormMain(loginInfo);
                    fromMain.ShowDialog();
                    //đóng form hiện tại
                }
                else
                {
                    lblStatus.Visible = true;
                }
            }
            catch (Exception ex)
            {

            }
        }
        //gửi yêu cầu đăng nhập kt account
        private async Task<string> CallAPIGetAccount(string account, string password)
        {
            try
            {
                xNet.HttpRequest http = new xNet.HttpRequest();
                string result = http.Get("http://tahoang111-001-site1.btempurl.com/api/Accounts/PhoneNumber?phonenumber=" + account.Trim() + "&password=" + password.Trim()).ToString();
                if (result.Contains(account))
                {
                    return result;
                }
                return "";
            }
            catch (Exception ex)
            {
                return "";
            }
        }     
        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/tathanhhoang1411");
        }
    }
}
