using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _310_deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            //prepare diplay screen (cleaning)
            tabControlRegister.Hide();

            //************Read it from text area.***********\\
            string userRecordPath = @"C:\Users\Oğuzhan Kuş\source\repos\310_deneme\UserRecord.txt";

            //variables for user records
            string[] userInfoArray = File.ReadAllLines(userRecordPath);
            List<string> userInfoList = new List<string>();             //this for checking login
            userInfoList = File.ReadAllLines(userRecordPath).ToList();  //this for recording new entries on text (easy append in string format)
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            groupLogin.Hide();
            tabControlRegister.Show();
        }
    }
}
