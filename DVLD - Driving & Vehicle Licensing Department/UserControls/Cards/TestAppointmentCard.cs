using DVLD_Logic;
using DVLD_UI.Utils;
using System.Windows.Forms;
namespace DVLD_UI.UserControls.Cards
{
    public partial class TestAppointmentCard : UserControl
    {

        public TestAppointmentCard(int ldlAppID, AppSettings.TestType testType)
        {
            InitializeComponent();
            InitializeValues(ldlAppID, testType);
        }
        private void pbCloseCard_Click(object sender, System.EventArgs e)
        {
            this.FindForm().Close();
        }
        private void ButtonShowPersonInfo_Click(object sender, System.EventArgs e)
        {
            PersonProfileCard personProfileCard = new PersonProfileCard(AppSettings.EnMode.Read, _Person.PersonID);
            using (FrmHost frmHost = new FrmHost(personProfileCard))
            {
                frmHost.ShowDialog();
            }
        }
        private void ButtonAddTestAppointment_Click(object sender, System.EventArgs e)
        {
            if (!TestAppointment.ActiveTestAppointmentExistsBy(TestTypeID, LDLAppID))
            {

                ScheduleTestAppointmentCard scheduleTestAppointmentCard = new ScheduleTestAppointmentCard(LDLAppID, (AppSettings.TestType)TestTypeID);
                using (FrmHost frmHost = new FrmHost(scheduleTestAppointmentCard))
                {
                    frmHost.Text = string.Format(AppSettings.ScheduleTestTitle, _TestType.Title);
                    frmHost.FormClosing += (s, ev) =>
                    {
                        LoadTestAppointments((AppSettings.TestType)TestTypeID, LDLAppID);
                    };
                    frmHost.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show($"An active appointment is already exists!");
            }

        }

        private void editToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            // Check if test appointment exists before show Edit User control
            if (TestAppointment.TestAppointmentExistsBy(SelectedTestAppointmentID))
            {
                ScheduleTestAppointmentCard scheduleTestAppointmentCard = new ScheduleTestAppointmentCard(LDLAppID, (AppSettings.TestType)TestTypeID, SelectedTestAppointmentID);
                using (FrmHost frmHost = new FrmHost(scheduleTestAppointmentCard))
                {
                    frmHost.Text = string.Format(AppSettings.ScheduleTestTitle, _TestType.Title);
                    frmHost.FormClosing += (s, ev) =>
                    {
                        LoadTestAppointments((AppSettings.TestType)TestTypeID, LDLAppID);
                    };
                    frmHost.ShowDialog();
                }
            }
            return;
        }

        private void AppointmentsGridView_SelectionChanged(object sender, System.EventArgs e)
        {
            if (AppointmentsGridView.Columns.Contains(AppSettings.TestAppointmentIDColumnName))
            {
                SelectedTestAppointmentID = Utils.Utils.GetIDFrom(AppSettings.TestAppointmentIDColumnName, AppointmentsGridView);

            }
            else
            {
                SelectedTestAppointmentID = 0;
                MessageBox.Show(AppSettings.TestAppointmentLoadFailedFromCell);
            }
        }
    }
}
