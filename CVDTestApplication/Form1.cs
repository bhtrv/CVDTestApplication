using System;
using System.Windows.Forms;

namespace CVDTestApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tasksListBox.SelectedIndex)
            {
                case 0:
                    empInfoDataGridView.DataSource = DBConnection.GetDataFromSql(DBRequests.salarySumByDepartmentsQuery());
                    break;
                case 1:
                    empInfoDataGridView.DataSource = DBConnection.GetDataFromSql(DBRequests.maxSalaryDepartmentQuery());
                    break;
                case 2:
                    empInfoDataGridView.DataSource = DBConnection.GetDataFromSql(DBRequests.chiefsSalariesQuery());
                    break;
                default:
                    MessageBox.Show("Выберите запрос");
                    break;
            }
        }
    }
}