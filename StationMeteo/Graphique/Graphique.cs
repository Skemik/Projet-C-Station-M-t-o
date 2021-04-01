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
		List<int> nbAAfficherGraphique = new List<int>();
		public void afficherGraphiqueID1(object sender, EventArgs e)
        {
			graphiqueOuvert = true;
			idgraphiqueAAfficher = 1;
			graphControl1.Visible = true;

		}
		public void afficherGraphiqueID2(object sender, EventArgs e)
		{
			idgraphiqueAAfficher = 2;
			graphiqueOuvert = true;
			graphControl1.Visible = true;
		}
		public void afficherGraphiqueID3(object sender, EventArgs e)
		{
			idgraphiqueAAfficher = 3;
			graphiqueOuvert = true;
			graphControl1.Visible = true;
		}
		public void afficherGraphiqueID4(object sender, EventArgs e)
		{
			idgraphiqueAAfficher = 4;
			graphiqueOuvert = true;
			graphControl1.Visible = true;
		}
		public void afficherGraphiqueID5(object sender, EventArgs e)
		{
			idgraphiqueAAfficher = 5;
			graphiqueOuvert = true;
			graphControl1.Visible = true;
		}

	    public void verifupdateGraphique(int id,float value)
        {
			if (graphiqueOuvert&&graphControl1.Visible)
			{


				foreach (IdBase trame in listeTram)
				{
					if (trame.id == idgraphiqueAAfficher)
					{
						IdMesure trameCorrecte = (IdMesure)trame;
						MessageBox.Show(" " + (int)trameCorrecte.dataConverti);
						graphControl1.ajoutervaleur((int)trameCorrecte.dataConverti);
						
					}
				}
			}
		}

		public void afficherGraphique()
		{
			
			for (int i = 0; i < nbAAfficherGraphique.Count; i++)
			{
				label1.Text = "X = " + graphControl1.getX();
				graphControl1.ajoutervaleur(nbAAfficherGraphique[i]);
			}

		}

	}
}
