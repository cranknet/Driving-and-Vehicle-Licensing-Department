using System;
using System.Data;
using System.Windows.Forms;
namespace DVLD_UI.Utils
{
    public class DataFilter
    {
        DataGridView _dataGridView;
        ComboBox _cmbFilterOptions;
        TextBox _txtFilterValue;
        private readonly string _defaultFilterOptionValue = "None";
        public DataFilter(DataGridView dataGridView, ComboBox cmbFilterOptions, TextBox txtFilterValue)
        {
            _dataGridView = dataGridView ?? throw new ArgumentNullException(nameof(dataGridView));
            _cmbFilterOptions = cmbFilterOptions ?? throw new ArgumentNullException(nameof(cmbFilterOptions));
            _txtFilterValue = txtFilterValue ?? throw new ArgumentNullException(nameof(txtFilterValue));
        }
        public void LoadFilterOptions()
        {
            _cmbFilterOptions.Items.Clear();
            _cmbFilterOptions.Items.Add(_defaultFilterOptionValue);
            foreach (DataGridViewColumn column in _dataGridView.Columns)
            {
                Type columnType = column.ValueType;
                if (columnType == typeof(string) || columnType == typeof(int) || columnType == typeof(double) || columnType == typeof(decimal))
                {
                    _cmbFilterOptions.Items.Add(column.Name);
                }
            }
            _cmbFilterOptions.SelectedItem = _defaultFilterOptionValue;
        }
        public void Apply()
        {
            if (_cmbFilterOptions.SelectedItem == null)
            {
                return;
            }
            string selectedFilterColumn = _cmbFilterOptions.SelectedItem?.ToString() ?? _defaultFilterOptionValue;
            string selectedFilterText = _txtFilterValue.Text.Trim().Replace("'", "''");
            if (_dataGridView.DataSource is DataTable dt)
            {
                DataView filteredView = dt.DefaultView;
                _txtFilterValue.Visible = selectedFilterColumn != _defaultFilterOptionValue;
                if (selectedFilterColumn == _defaultFilterOptionValue || string.IsNullOrWhiteSpace(selectedFilterColumn))
                {
                    _txtFilterValue.Clear();
                    filteredView.RowFilter = string.Empty;
                }
                else
                {
                    Type columnType = _dataGridView.Columns[selectedFilterColumn].ValueType;
                    if (columnType == typeof(int) || columnType == typeof(double) || columnType == typeof(decimal))
                    {
                        if (decimal.TryParse(selectedFilterText, out decimal parsedText))
                        {
                            filteredView.RowFilter = $"{selectedFilterColumn} = {parsedText}";
                        }
                        else
                        {
                            filteredView.RowFilter = string.Empty;
                        }
                    }
                    else
                    {
                        filteredView.RowFilter = $"CONVERT({selectedFilterColumn}, System.String) LIKE '%{selectedFilterText}%'";
                    }
                }
            }
        }
    }
}
