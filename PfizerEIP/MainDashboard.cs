using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MainDashboard
{
    public partial class dashboardForm : Form
    {
        public dashboardForm()
        {
            InitializeComponent();
        }

        private void globalIntelligenceButton_Click(object sender, EventArgs e)
        {
            //Show Global Intelligence Form
            globalIntelligenceForm aglobalIntelligenceForm = new globalIntelligenceForm();
            aglobalIntelligenceForm.ShowDialog();
        }

        private void businessIntelligenceButton_Click(object sender, EventArgs e)
        {
            businessIntelligenceForm abusinessIntelligenceForm = new businessIntelligenceForm();
            abusinessIntelligenceForm.ShowDialog();
        }

        private void sustainabilityIntelligenceButton_Click(object sender, EventArgs e)
        {
            sustainabilityIntelligenceForm asustainabilityForm = new sustainabilityIntelligenceForm();
            asustainabilityForm.ShowDialog();
        }
    }
}
