using System;
using System.Linq;
using System.IO;
using CsvHelper;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;


namespace DisplayCSVFile
{
    class PresentData
    {
        public BindingList<ElementsCSV> dataList;
        public BindingList<ElementsCombo> comboList;
        
        /// <summary>
        /// Read Csv File and assign contents to BindingList
        /// </summary>
        public void ReadFromCSV()
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "data.csv");
            
            using (var streamReader = new StreamReader(filePath))
            {
                using(var csvReader = new CsvReader(streamReader,CultureInfo.InvariantCulture))
                {                                      
                    dataList = new BindingList<ElementsCSV>(csvReader.GetRecords<ElementsCSV>().ToList());
                   
                }
            }            
        }
        /// <summary>
        /// Method to display the selected name
        /// </summary>
        /// <param name="cmbxDisplayName"></param>
        internal void DisplayComboBox(ComboBox cmbxDisplayName)
        {
            cmbxDisplayName.DataSource = comboList;
            cmbxDisplayName.DisplayMember = "Name";
        }

        /// <summary>
        /// Method to Display ID based on Name selection
        /// </summary>
        /// <param name="cmbxDisplayName"></param>
        internal void DisplayMessageID(ComboBox cmbxDisplayName)
        {
            try
            {
                int selItem = comboList[cmbxDisplayName.SelectedIndex].Id;
                MessageBox.Show("Selected item's Id = " + selItem);
            }
            catch (Exception)
            {
                MessageBox.Show("Select Valid Entry");
            }
            
            
        }
        /// <summary>
        /// Read Csv File and assign contents to comboBindingList
        /// </summary>
        internal void ReadForCombobox()
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "combo_example.csv");
            
            using (var streamReader = new StreamReader(filePath))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    comboList = new BindingList<ElementsCombo>(csvReader.GetRecords<ElementsCombo>().ToList());

                }
            }
        }
        
        /// <summary>
        /// Bind DataGrid datasource to BindingList
        /// </summary>
        /// <param name="dgView"></param>
        public void DisplayDataGrid(DataGridView dgView)
        {
            dgView.DataSource = dataList;
        }

        /// <summary>
        /// Entire row selected from datagrid will be deleted
        /// </summary>
        /// <param name="dgView"></param>
        public void DeleteSelectedRow(DataGridView dgView)
        {
            try
            {
                dataList.RemoveAt(dgView.SelectedRows[0].Index);
            }
            catch (Exception)
            {
                MessageBox.Show("Select Entire Row to Delete");
            }            
        }

    }
}
