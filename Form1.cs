using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace OrganizationProfile
{
    public partial class Form1 : Form{
        public long StudentNumber(string studNum)
        {

            StudentNumber = long.Parse(studNum);

            return StudentNumber;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                ContactNo = long.Parse(Contact);
            }

            return ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                Age = Int32.Parse(age);
            }

            return Age;
        }




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
{
               "BS Information Technology",
               "BS Computer Science",
               "BS Information Systems",
               "BS In Accountancy",
               "BS In Hospitality Management",
               "BS In Tourism Management",
};
            for (int i = 0; i < 6; i++)
            {
                Program.Item.Add(ListOfProgram[i].ToString());
            }
        }
    }
 }

