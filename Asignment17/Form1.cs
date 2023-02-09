using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            TXTID.Text = "";
            TXTName.Text = "";
            TXTSalary.Text = "";
            TXTID.Focus();
        }
        private void BTNClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {                       
            if (!string.IsNullOrEmpty(TXTID.Text) && !string.IsNullOrEmpty(TXTName.Text) && !string.IsNullOrEmpty(TXTSalary.Text))
            {
                if (new Regex(@"^\d?$").IsMatch(TXTID.Text.Trim())&& new Regex(@"^[A-Z]([a-z]+)$").IsMatch(TXTName.Text.Trim())&&new Regex(@"^\d{3}(\d)*$").IsMatch(TXTSalary.Text.Trim()))
                {
                    object[] Row = { TXTID.Text.Trim(), TXTName.Text.Trim(), TXTSalary.Text.Trim() };
                    DGV.Rows.Add(Row);
                    Clear();
                }
                else
                {
                    MessageBox.Show("Someone or more of data you have entered is not valid, please try again");
                    TXTID.Focus();
                }
            }
            else if (string.IsNullOrEmpty(TXTID.Text) && !string.IsNullOrEmpty(TXTName.Text) && !string.IsNullOrEmpty(TXTSalary.Text))
            {
                MessageBox.Show("You couldn't let the ID box empty");
                TXTID.Focus();
            }
            else if (!string.IsNullOrEmpty(TXTID.Text) && string.IsNullOrEmpty(TXTName.Text) && !string.IsNullOrEmpty(TXTSalary.Text))
            {
                MessageBox.Show("You couldn't let the name box empty");
                TXTName.Focus();
            }
            else if (!string.IsNullOrEmpty(TXTID.Text) && !string.IsNullOrEmpty(TXTName.Text) && string.IsNullOrEmpty(TXTSalary.Text))
            {
                MessageBox.Show("You couldn't let the salary box empty");
                TXTSalary.Focus();
            }
            else
            {
                MessageBox.Show("You couldn't let the data boxes empty");
                TXTID.Focus();
                return;
            }                        
        }
        private void BTNEdit_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentRow != null)
            {
                if (new Regex(@"^\d?$").IsMatch(TXTID.Text.Trim()) && new Regex(@"^[A-Z]([a-z]+)$").IsMatch(TXTName.Text.Trim()) && new Regex(@"^\d{3}(\d)*$").IsMatch(TXTSalary.Text.Trim()))
                { 
                DGV.CurrentRow.Cells[0].Value = TXTID.Text;
                DGV.CurrentRow.Cells[1].Value = TXTName.Text;
                DGV.CurrentRow.Cells[2].Value = TXTSalary.Text;
                Clear();
            }
            else
            {
                MessageBox.Show("Someone or more of data you have entered is not valid, please try again");
                TXTID.Focus();
            }
        }
    }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            if (DGV.CurrentRow != null)
            {
                DGV.Rows.Remove(DGV.CurrentRow);
            }
        }

        private void BTNExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV.CurrentRow!=null)
            {
                TXTID.Text = DGV.CurrentRow.Cells[0].Value + "";
                TXTName.Text = DGV.CurrentRow.Cells[1].Value + "";
                TXTSalary.Text = DGV.CurrentRow.Cells[2].Value + "";
            }
        }
    }
}
