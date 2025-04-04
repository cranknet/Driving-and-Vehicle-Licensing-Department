﻿using DVLD_Data;
using DVLD_Logic;
using DVLD_UI.Utils;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class UserProfileCard : UserControl
    {
        public UserProfileCard(AppSettings.EnMode enMode, int userID)
        {
            InitializeComponent();
            EnMode = enMode;
            InitializeUser(userID);
        }
        private void UserProfileCard_Load(object sender, System.EventArgs e)
        {
            Display();
        }
        private void pbCloseCard_Click(object sender, System.EventArgs e)
        {
            this.FindForm()?.Close();
        }
        private void btnReset_Click(object sender, System.EventArgs e)
        {
        }
        private void btnUserEditPerson_Click(object sender, System.EventArgs e)
        {
            PersonProfileCard personProfileCard = new PersonProfileCard(EnMode, User.PersonID);
            using (FrmHost frmHost = new FrmHost(personProfileCard))
            {
                frmHost.FormClosing += FrmHost_FormClosing;
                frmHost.ShowDialog();
            }
        }
        private void FrmHost_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Reset The User Card Info When The Person Card about to close.
            Person = People.FindByPersonID(User.PersonID);
            LoadUserInfo();
            btnReset_Click(sender, e);
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {

            if (SaveUser())
            {
                if (EnMode == AppSettings.EnMode.Update)
                {
                    DialogResult result = MessageBox.Show("User Password updated successfully\nDo you want to close the card?", "User Password Update", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        this.FindForm()?.Close();
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("User added successfully\nDo you want to close the card?", "User Add New", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        this.FindForm()?.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Can't update User password!");
            }
        }
        private void btnPersonSelect_Click(object sender, System.EventArgs e)
        {
            PersonSelectCard personSelectCard = new PersonSelectCard(DataCache.Instance.GetNonUserPersons());
            using (FrmHost frmHost = new FrmHost(personSelectCard))
            {
                //frmHost.FormClosing += FrmHost_FormClosing;
                personSelectCard.OnPersonIDSelected += (personID) =>
                {
                    User.PersonID = personID;
                    Person = People.FindByPersonID(personID);
                    pbPersonImage.ImageLocation = (Person != null) ? Person.ImagePath : string.Empty;
                    ToggleAddUserTextBoxes(true);
                };
                frmHost.ShowDialog();
            }
        }
    }
}
