using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;

namespace MicrocreditCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string input;
        public string loanSumPer;
        public string loanTermPer;

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    input = sr.ReadToEnd();
                    sr.Close();
                }

                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void PutButton_Click(object sender, EventArgs e)
        {
            try
            {
                input += Int32.Parse(Bet.Text) + "\n";
                Bet.Text = "";

                Heading.Text = "Microcredit Calculator";
                Heading.ForeColor = Color.Green;

            }

            catch 
            {
                Heading.Text = "Invalid input format";
                Heading.ForeColor = Color.Red;
            }
     
        }

        private void WriteLoanButton_Click(object sender, EventArgs e)
        {
            try
            {
                double qwe = Double.Parse(LoanSum.Text);
                int asd = Int32.Parse(LoanTerm.Text);

                loanSumPer = LoanSum.Text;
                loanTermPer = LoanTerm.Text;

                input += loanSumPer + '\n';
                input += loanTermPer + '\n';

                Heading.Text = "Microcredit Calculator";
                Heading.ForeColor = Color.Green;
            }

            catch
            {
                Heading.Text = "Invalid input format";
                Heading.ForeColor = Color.Red;
            }
        }

        private void FinishTyping_Click(object sender, EventArgs e)
        {
            input = input.TrimEnd('\n');
            var rs = new StreamWriter(openFileDialog1.FileName, false);
            rs.WriteLine(input);
            rs.Close();
        }

        private void SaveReportButton_Click(object sender, EventArgs e)
        {
            var sr = new StreamReader(openFileDialog1.FileName);
            int lenfile = sr.ReadToEnd().Split('\n').Length;
            sr = new StreamReader(openFileDialog1.FileName);

            double loanSumPer0 = 0;
            int loanTermPer0 = 0;


            ArrayList betArray = new ArrayList();

            for (int i = 0; i < lenfile; i++)
            {
                string inputline = sr.ReadLine();
                if (inputline != "\n" && inputline != "" && inputline != null)
                {
                    if (i == 0)
                    {
                        loanSumPer0 = Double.Parse(inputline);
                    }

                    else if (i == 1)
                    {
                        loanTermPer0 = Int32.Parse(inputline);
                    }

                    else
                    {
                        betArray.Add(Double.Parse(inputline));
                    }
                }
            }

            ArrayList Cumulative = new ArrayList();
            ArrayList PayoutAmount = new ArrayList();

            double CumulativePer = 0;
            double PayoutAmountPer = 0;
            PayoutAmountPer += loanSumPer0;

            foreach (double i in betArray)
            {
                CumulativePer += (loanSumPer0 * i) / 100;
                Cumulative.Add(CumulativePer);

                PayoutAmountPer = loanSumPer0 + CumulativePer;
                PayoutAmount.Add(PayoutAmountPer);

            }

            double TotalPayoutAmount = PayoutAmountPer;
            double amountInterest = CumulativePer;
            double EffectiveBid = amountInterest / loanSumPer0 / loanTermPer0;


            string otchet = Convert.ToString(TotalPayoutAmount) + '\n' + Convert.ToString(amountInterest) + '\n' + Convert.ToString(EffectiveBid * 100) + '\n';

            for (int i = 0; i < Cumulative.Count; i++)
            {
                otchet += Convert.ToString(Cumulative[i]) + "; " + Convert.ToString(PayoutAmount[i]) + '\n';
            }

            System.IO.File.WriteAllText("C:\\Users\\201904\\Documents\\Report.txt", otchet);
        }
    }
}
