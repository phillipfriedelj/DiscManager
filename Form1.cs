using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscManager
{
    public partial class Form1 : Form
    {

        DatabaseManager dbManager = new DatabaseManager();
        public Form1()
        {
            InitializeComponent();
            comboBoxSearch.DataSource = Enum.GetValues(typeof(DatabaseManager.DatabaseCategories));
            dbManager.CreateConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            dbManager.ExecuteQuery(DatabaseManager.OperationType.RetrieveAll, null, null);
            dbManager.CloseConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseManager.DatabaseCategories dbCategory;
            Enum.TryParse<DatabaseManager.DatabaseCategories>(comboBoxSearch.SelectedValue.ToString(), out dbCategory);
            dbManager.ExecuteQuery(DatabaseManager.OperationType.RetrieveOne, dbCategory, textBoxSearch.Text);
        }
    }
}
