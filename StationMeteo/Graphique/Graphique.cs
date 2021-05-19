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

			graphiqueOuvert = true;
			idgraphiqueAAfficher = 1;
			graphControl1.Visible = true;
			grid.Visible = false;
			grid_accessTable.Visible = false;
			grid_userTable.Visible = false;
			userControlConfig.Visible = false;
			userControl_newuser.Visible = false;
			userControl_SupprimerUtilisateur.Visible = false;
			update_button.Visible = false;

		}
		public void afficherGraphiqueID2(object sender, EventArgs e)
		{

			idgraphiqueAAfficher = 2;
			graphiqueOuvert = true;
			graphControl1.Visible = true;
			grid.Visible = false;
			grid_accessTable.Visible = false;
			grid_userTable.Visible = false;
			userControlConfig.Visible = false;
			userControl_newuser.Visible = false;
			userControl_SupprimerUtilisateur.Visible = false;
			update_button.Visible = false;
		}
		public void afficherGraphiqueID3(object sender, EventArgs e)
		{

			idgraphiqueAAfficher = 3;
			graphiqueOuvert = true;
			graphControl1.Visible = true;
			grid.Visible = false;
			grid_accessTable.Visible = false;
			grid_userTable.Visible = false;
			userControlConfig.Visible = false;
			userControl_newuser.Visible = false;
			userControl_SupprimerUtilisateur.Visible = false;
			update_button.Visible = false;
		}
		public void afficherGraphiqueID4(object sender, EventArgs e)
		{
			idgraphiqueAAfficher = 4;
			graphiqueOuvert = true;
			graphControl1.Visible = true;
			grid.Visible = false;
			grid_accessTable.Visible = false;
			grid_userTable.Visible = false;
			userControlConfig.Visible = false;
			userControl_newuser.Visible = false;
			userControl_SupprimerUtilisateur.Visible = false;
			update_button.Visible = false;
		}
		public void afficherGraphiqueID5(object sender, EventArgs e)
		{
			idgraphiqueAAfficher = 5;
			graphiqueOuvert = true;
			graphControl1.Visible = true;
			grid.Visible = false;
			grid_accessTable.Visible = false;
			grid_userTable.Visible = false;
			userControlConfig.Visible = false;
			userControl_newuser.Visible = false;
			userControl_SupprimerUtilisateur.Visible = false;
			update_button.Visible = false;
		}

    }
}
