using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AppLuckyNumber_Client_
{
    public partial class FormMain : Form
    {
        private int _totalPlayer;
        public int TotalPlayer
        {
            get { return _totalPlayer; }
            set
            {
                if (_totalPlayer != value)
                {
                    _totalPlayer = value;
                }
            }
        }    
        private int _lkNumber;
        public int LkNumber
        {
            get { return _lkNumber; }
            set
            {
                if (_lkNumber != value)
                {
                    _lkNumber = value;
                }
            }
        }      
        private double _totalCoin;
        public double TotalCoin
        {
            get { return _totalCoin; }
            set
            {
                if (_totalCoin != value)
                {
                    _totalCoin = value;
                }
            }
        }
        private string _infoAccount;
        private System.Windows.Forms.Timer timer;
        public FormMain()
        {
            InitializeComponent();
            InitializeComponent1();
            lblStatus.Text = "Bạn chưa đạt cược!";
        }
        private void InitializeComponent1()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Cập nhật mỗi giây
            timer.Tick += timer1_Tick_1;
            timer.Start();
        }
        public FormMain(string loginInfo)
        {
            InitializeComponent();
            _infoAccount = loginInfo;
            List<string> accountWalletInfo = new List<string>();
            accountWalletInfo= CallAPIGetInfoAccountWallet();
            if (accountWalletInfo != null)
            {
                if (!accountWalletInfo.Contains("Bạn không có ví, không thể chơi"))
                {
                    lblAccount.Text = accountWalletInfo[5].Trim();
                    DateTime dateTime = DateTime.Parse(accountWalletInfo[13].Trim());
                    lblNgaySinh.Text = dateTime.ToString("dd-MM-yyyy");
                    lblName.Text = accountWalletInfo[17].Trim();
                    lblIDVi.Text = accountWalletInfo[19].Trim();
                    lblCoin.Text = accountWalletInfo[20].Trim();
                    lblLuckyNumber.Text = CallAPIGetLuckyNumber().ToString().Trim();
                }
            }
            else
            {
                grbInfo.Hide();
                lblIDVi.Text = "Bạn không có ví, không thể chơi";
                btnCuoc.Enabled = false;
                txtLKNumber.Enabled = false;
            }
            lblLuckyNumber.Text = CallAPIGetLuckyNumber().ToString().Trim();

        }
        //Lấy thông tin tài khoản
        private  List<string> CallAPIGetInfoAccountWallet()
        {
            try
            {
                List<string> info =_infoAccount.Split('\"').ToList();
                xNet.HttpRequest http = new xNet.HttpRequest();
                string result = http.Get("http://tahoang111-001-site1.btempurl.com/api/Walletes/PhoneNumber?phoneNumber=" + info[5].ToString().Trim()).ToString();
                if (result.Contains(info[5].ToString().Trim()))
                {
                    var arr=result.Split('\"');
                    info.Add(arr[3].ToString().Trim());
                    info.Add(arr[11].ToString().Trim());
                    return info;
                }
                else
                {
                    info = new List<string>();
                    info.Add("Bạn không có ví, không thể chơi");
                    return info;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        } 
        //Lấy số may mắn của lần chơi trước
        private int CallAPIGetLuckyNumber()
        {
            try
            {
                xNet.HttpRequest http = new xNet.HttpRequest();
                int result = int.Parse(http.Get("http://tahoang111-001-site1.btempurl.com/api/Check/LuckyNumber").ToString());
                return result;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }     
        //Lấy tổng số người đang chơi
        //private void CallAPIGetTotalPlayer()
        //{
        //    try
        //    {
        //        xNet.HttpRequest http = new xNet.HttpRequest();
        //        Thread t = new Thread(() =>
        //        {
        //            while (true)
        //            {
        //                int result = int.Parse(http.Get("http://tahoang111-001-site1.btempurl.com/api/Check/CountPlayerCurrent").ToString());
        //                TotalPlayer = result;
        //                lblTotalPlayer.Text = TotalPlayer.ToString();
        //                Thread.Sleep(10000);//10 giây gửi yêu cầu 1 lần
        //            }
        //        });
        //        t.Start();
        //    }
        //    catch (Exception ex)
        //    {
        //        lblTotalPlayer.Text ="error";
        //    }
        //}

        private void btnCuoc_Click(object sender, EventArgs e)
        {
            try
            {
                string phoneNumber = lblAccount.Text.Trim();
                string chooseLuckyNumber = txtLKNumber.Text.Trim();
                if (chooseLuckyNumber.Length > 1|| chooseLuckyNumber.Length==0)//chỉ cho nhập 1 số
                {
                    MessageBox.Show(this, "Chỉ nhập số có 1 chữ số", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                xNet.HttpRequest http = new xNet.HttpRequest(); 
                string result = http.Post("http://tahoang111-001-site1.btempurl.com/api/Check/ChooseNumber?chooseNumber=" + chooseLuckyNumber + "&phoneNumber=" + phoneNumber.Trim()).ToString();
                if (result == "true")
                {
                    double coin = double.Parse(lblCoin.Text.Trim());
                    lblCoin.Text = (coin - 15000).ToString();
                    MessageBox.Show(this, "Cược thành công", "Thông báo", MessageBoxButtons.OK);
                    lblStatus.Text = "Bạn đã cược số: "+ chooseLuckyNumber;
                }
                else
                {
                    int time = DateTime.Now.Minute;
                    MessageBox.Show(this, "Cược thất bại, bạn đã cược rồi, hãy chờ: " + (60 - time) + " phút", "Cảnh báo", MessageBoxButtons.OK);
                    lblStatus.Text = "Bạn đã cược trước đó, số: " + chooseLuckyNumber;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, "Lỗi " + ex.ToString(), "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(UpdateLblTotalPlayer);
            thread1.Start();
            Thread thread2 = new Thread(UpdateLblLKNumber);
            thread2.Start();   
            Thread thread3 = new Thread(UpdateLblCoin);
            thread3.Start();

        }
        private void UpdateLblTotalPlayer()
        {
            try
            {
                xNet.HttpRequest http = new xNet.HttpRequest();
                while (true)
                {
                    int result = int.Parse(http.Get("http://tahoang111-001-site1.btempurl.com/api/Check/CountPlayerCurrent").ToString());
                    TotalPlayer = result;
                    UpdateLblUpdateLblTotalPlayerValue(TotalPlayer.ToString());
                    Thread.Sleep(10000);//10 giây gửi yêu cầu 1 lần
                }
            }
            catch(Exception ex)
            {

            }
        }       
        private void UpdateLblLKNumber()
        {
            try
            {
                xNet.HttpRequest http = new xNet.HttpRequest();
                while (true)
                {
                    int result = int.Parse(http.Get("http://tahoang111-001-site1.btempurl.com/api/Check/LuckyNumber").ToString());
                    LkNumber = result;
                    UpdateLblUpdateLblLkNumberValue(LkNumber.ToString());
                    Thread.Sleep(10000);//10 giây gửi yêu cầu 1 lần
                }
            }
            catch(Exception ex)
            {

            }
        }     
        private void UpdateLblCoin()
        {
            try
            {
                xNet.HttpRequest http = new xNet.HttpRequest();
                while (true)
                {
                    List<string> info = _infoAccount.Split('\"').ToList();
                    double coinOld = double.Parse(lblCoin.Text.Trim());
                    string result = http.Get("http://tahoang111-001-site1.btempurl.com/api/Walletes/PhoneNumber?phoneNumber=" + info[5].ToString().Trim()).ToString();
                    if (!result.Contains("null"))
                    {
                        TotalCoin = double.Parse(result.Split('\"')[11]);
                        UpdateLblUpdateLblCoinValue(TotalCoin.ToString());
                        if (TotalCoin > coinOld)
                        {
                            MessageBox.Show(this, "Bạn đã chiến thắng, thưởng 100.000 Coin", "Thông báo", MessageBoxButtons.OK);
                            txtLKNumber.Clear();
                            txtLKNumber.Focus();
                        }
                    }
                    Thread.Sleep(10000);//10 giây gửi yêu cầu 1 lần
                }
            }
            catch(Exception ex)
            {

            }
        }
        private void UpdateLblUpdateLblTotalPlayerValue(string value)
        {
            if (lblTotalPlayer.InvokeRequired)
            {
                // Truy cập và cập nhật Label thông qua UI thread
                lblTotalPlayer.Invoke((MethodInvoker)(() => lblTotalPlayer.Text = value));
            }
            else
            {
                lblTotalPlayer.Text = value;
            }
        }    
        private void UpdateLblUpdateLblCoinValue(string value)
        {
            if (lblCoin.InvokeRequired)
            {
                // Truy cập và cập nhật Label thông qua UI thread
                lblCoin.Invoke((MethodInvoker)(() => lblCoin.Text = value));
            }
            else
            {
                lblCoin.Text = value;
            }
        }
        private void UpdateLblUpdateLblLkNumberValue(string value)
        {
            if (lblLuckyNumber.InvokeRequired)
            {
                // Truy cập và cập nhật Label thông qua UI thread
                lblLuckyNumber.Invoke((MethodInvoker)(() => lblLuckyNumber.Text = value));
            }
            else
            {
                lblLuckyNumber.Text = value;
            }
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss, dd-MM-yyyy"); // Định dạng ngày giờ đầy đủ
            }
            catch
            {

            }
        }
    }
}
