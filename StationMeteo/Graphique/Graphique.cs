using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections;

namespace StationMeteo
{
	public partial class Form1
	{
		bool graphiqueOuvert = false;
		int idgraphiqueAAfficher;
		public void afficherGraphiqueID1(object sender, EventArgs e)
        {
			cacherTouslesComposantsGraphiques();
			graphiqueOuvert = true;
			idgraphiqueAAfficher = 1;
			graphControl1.Visible = true;


		}
		public void afficherGraphiqueID2(object sender, EventArgs e)
		{
			cacherTouslesComposantsGraphiques();
			idgraphiqueAAfficher = 2;
			graphiqueOuvert = true;
			graphControl1.Visible = true;

		}
		public void afficherGraphiqueID3(object sender, EventArgs e)
		{
			cacherTouslesComposantsGraphiques();
			idgraphiqueAAfficher = 3;
			graphiqueOuvert = true;
			graphControl1.Visible = true;

		}


    }
}
