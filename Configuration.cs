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
		public void check()
		{
			String contenu="Les lignes sont composé de cette forme la id;type;min;max;alarmeMin;alarmeMax\r\nDebut";
			foreach (IdBase trame in listeTram)
			{
				contenu += trame.id+ ";" + trame.type + ";" + ((IdMesure)trame.min) + ";" + ((IdMesure)trame.max) + ";" + ((IdMesure)trame.alarmeMin) + ";" + ((IdMesure)trame.alarmeMax);
			
			}
			contenu += "Fin";
			MessageBox.Show("Erreur égalité des CheckSum !!!");


		}
	}
}
	

