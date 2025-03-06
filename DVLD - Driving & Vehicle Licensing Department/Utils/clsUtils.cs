using DVLD_Logic;
using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace DVLD_UI.Utils
{
    public class clsUtils
    {
        public static string ImageHandler(PictureBox pictureBox, string imageFolder)
        {
            string destinationPath = string.Empty;
            using (OpenFileDialog ofdImage = new OpenFileDialog())
            {
                ofdImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofdImage.Multiselect = false;
                if (ofdImage.ShowDialog() == DialogResult.OK)
                {
                    string sourcePath = ofdImage.FileName;
                    string imagesFolder = Path.Combine(Application.StartupPath, imageFolder);
                    if (!Directory.Exists(imagesFolder))
                    {
                        Directory.CreateDirectory(imagesFolder);
                    }
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(sourcePath);
                    destinationPath = Path.Combine(imagesFolder, fileName);
                    try
                    {
                        File.Copy(sourcePath, destinationPath, true);
                        pictureBox.ImageLocation = destinationPath;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("_ImageHandler: Error copying image: " + ex.Message);
                    }
                }
            }
            return destinationPath;
        }
        public static bool DeleteImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                try
                {
                    File.Delete(imagePath);
                    return true;
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Access denied! You don't have permission to delete this file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException)
                {
                    MessageBox.Show("The file is currently in use. Close any applications using it and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred while deleting the image:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }
        // Validations
        public static bool IsValidText(string text)
        {
            return Regex.IsMatch(text, @"^[A-Za-z\s]+$");
        }
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^\+?\d{7,15}$"); // Allows optional + at start
        }
        public static bool IsValidDate(DateTime date)
        {
            return date <= DateTime.Today.AddYears(-18);
        }
        public static DateTime AllowedDate(int minAge)
        {
            return DateTime.Today.AddYears(-minAge);
        }
        public static void LoadFilterOptions(DataGridView gridView, ComboBox cmbFilter, string none = "None")
        {
            if (gridView == null) return;
            cmbFilter.Items.Clear();
            cmbFilter.Items.Add(none);
            foreach (DataGridViewColumn column in gridView.Columns)
            {
                Type columnType = column.ValueType;
                if (columnType == typeof(string) || columnType == typeof(int) || columnType == typeof(double) || columnType == typeof(decimal))
                {
                    cmbFilter.Items.Add(column.Name);
                }
            }
            cmbFilter.SelectedItem = none;
        }
        public static void LoadCountryList(ComboBox cmbCountryList, DataTable countryNames)
        {
            countryNames = clsCountry.GetListCountries().DefaultView.ToTable("CountryNames", false, "CountryName", "CountryID");
            cmbCountryList.DataSource = countryNames;
            cmbCountryList.DisplayMember = "CountryName";
            cmbCountryList.ValueMember = "CountryID";
        }
        public static void AdjustGridViewColumns(DataGridView dataGridView)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        public static int GetIDFrom(string cellName, DataGridView dataGridView)
        {
            if (dataGridView?.CurrentRow?.Cells[cellName]?.Value is int ID) return ID;
            return -1;
        }
        public static void LoadUserControl(Panel panel, UserControl userControl)
        {
            if (panel == null) return;
            panel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel.Controls.Add(userControl);
        }
    }
}
