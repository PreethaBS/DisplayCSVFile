using System;
using System.Threading;
using System.Windows.Forms;

namespace DisplayCSVFile
{
    public partial class Form1 : Form
    {
        PresentData presentData = new PresentData();
        public Form1()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            presentData.ReadFromCSV();
            presentData.DisplayDataGrid(dgViewDisplayCSV);

            //Read from CSV file and Populate combobox
            presentData.ReadForCombobox();
            presentData.DisplayComboBox(cmbxDisplayName);
        }       
        
        /// <summary>
        /// Event Handler to Delete Row from Datagrid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            presentData.DeleteSelectedRow(dgViewDisplayCSV);            
        }
        /// <summary>
        /// Event Handler to display ID based on Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplayID_Click(object sender, EventArgs e)
        {
            presentData.DisplayMessageID(cmbxDisplayName);
        }

        /// <summary>
        /// To Change the CultureUI Based on the language selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbxLanguage.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es");
                    break;
                case 2:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
            ReloadContentsInContainerControls();

        }
        /// <summary>
        /// Method to reload the existing data content in controls
        /// when language selection change happens
        /// </summary>
        private void ReloadContentsInContainerControls()
        {
            //presentData.ReadFromCSV();
            presentData.DisplayDataGrid(dgViewDisplayCSV);

            //Read from CSV file and Populate combobox
            presentData.ReadForCombobox();
            presentData.DisplayComboBox(cmbxDisplayName);
        }

        
        /// <summary>
        /// To handle cell format in datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgViewDisplayCSV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            if (e.ColumnIndex == 1)
            {
                MessageBox.Show(" Enter Valid Station Number ");
            }
            if (e.ColumnIndex == 2)
            {
                MessageBox.Show(" Enter Valid Date ");
            }
            if (e.ColumnIndex == 3)
            {
                MessageBox.Show(" Enter Valid Number ");
            }            
        }
    }
}
