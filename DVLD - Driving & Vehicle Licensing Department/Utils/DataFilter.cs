using System;
using System.Data;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DVLD_UI.Utils
{
    public class DataFilter
    {
        DataGridView _dataGridView;
        ComboBox _cmbFilterOptions;
        TextBox _txtFilterValue;
        string _defaultFilterOptionValue = "None";

        public DataFilter(DataGridView dataGridView, ComboBox cmbFilterOptions, TextBox txtFilterValue)
        {
            _dataGridView = dataGridView;
            _cmbFilterOptions = cmbFilterOptions;
            _txtFilterValue = txtFilterValue;

        }
        private void LoadFilterOptions()
        {
            _cmbFilterOptions.Items.Clear();
            _cmbFilterOptions.Items.Add(_defaultFilterOptionValue);
            foreach (DataGridViewColumn column in _dataGridView.Columns)
            {
                if (column.ValueType == typeof(string) || column.ValueType == typeof(int))
                {
                    _cmbFilterOptions.Items.Add(column.Name);
                }
            }
            _cmbFilterOptions.SelectedItem = _defaultFilterOptionValue;
        }
        public void Apply()
        {
            LoadFilterOptions();
            string selectedFilterColumn = _cmbFilterOptions.SelectedItem.ToString();
            string selectedFilterText = _txtFilterValue.Text.Trim().Replace("'", "''");
            if (_dataGridView.DataSource is DataTable dt)
            {
                DataView filteredView = dt.DefaultView;
                _txtFilterValue.Visible = selectedFilterColumn != _defaultFilterOptionValue;
                if (selectedFilterColumn == _defaultFilterOptionValue)
                {
                    _txtFilterValue.Clear();
                    filteredView.RowFilter = string.Empty;
                }
                else if (_dataGridView.Columns[selectedFilterColumn].ValueType == typeof(string))
                {
                    filteredView.RowFilter = $"CONVERT({selectedFilterColumn}, System.String) LIKE '%{selectedFilterText}%'";
                }

            }
        }


    }
}
