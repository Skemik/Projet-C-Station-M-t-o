using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationMeteo
{
    public partial class UserControl_config : UserControl
    {
        public UserControl_config()
        {
            InitializeComponent();
        }

        private void idConfig_TextChanged(object sender, EventArgs e)
        {

        }

        public String getIdConfig()
        {
            return idConfig.Text;
        }
        public String getintervMinConfig()
        {
            return intervMinConfig.Text;
        }
        public String getintervMaxConfig()
        {
            return intervMaxConfig.Text;
        }

    }
}
