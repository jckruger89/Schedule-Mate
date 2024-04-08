using System.Collections.Generic;
using System.Windows.Forms;

namespace Software2
{
    public static class ComboBoxes
    {
        public static void LoadAppointmentTypeComboBox(ComboBox TypeCB)
        {
            TypeCB.Items.Clear();
            List<string> appointmentTypes = new List<string>()
            { "PRESENTATION", "SCRUM", "DAILY STANDUP", "RETROSPECTIVE", "BRAINSTORMING", "SPRINT PLANNING", "WEEKLY PRIORITY" };

            appointmentTypes.ForEach(type => TypeCB.Items.Add(type)); // Using a lambda expression here for conciseness and expressiveness

            TypeCB.SelectedIndex = 0;
        }

        public static void LoadReportTypeComboBox(ComboBox ReportTypeCB)
        {
            ReportTypeCB.Items.Clear();
            List<string> reportTypes = new List<string>()
            {"Monthly Appointment Types", "Monthly Customer Appointments", "User Schedule"};

            reportTypes.ForEach(type => ReportTypeCB.Items.Add(type)); // Using a lambda expression here for conciseness and expressiveness
            
            ReportTypeCB.SelectedIndex = 0;
        }
    }
}
