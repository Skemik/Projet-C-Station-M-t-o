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
using System.IO;

namespace StationMeteo
{
	public partial class Form1
	{
		private UserControl_config userControlConfig;
		

		public void sauvegarderConfigDansUnFichier()
		{
			String contenu = "Les lignes sont composé de cette forme la id;type;intervalleMin;intervalleMax;alarmeMin;alarmeMax\r\nDebut\r\n";
			foreach (IdBase trame in listeTram)
			{
				if (trame.id>0&&trame.id<11&& ((IdMesure)trame).intervalleMin!=0&& ((IdMesure)trame).intervalleMax!=0)
				{
					contenu += trame.id + ";" + trame.type + ";" + ((IdMesure)trame).intervalleMin + ";" + ((IdMesure)trame).intervalleMax + ";" + ((IdMesure)trame).alarmeMin + ";" + ((IdMesure)trame).alarmeMax+"\r\n";
				}
				

			}
			contenu += "Fin";
			using(SaveFileDialog monSauvegardeur= new SaveFileDialog())
			{
				String path =Directory.GetCurrentDirectory();
				monSauvegardeur.InitialDirectory = "..\\..\\"+path;
				monSauvegardeur.Filter= "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
				monSauvegardeur.Title = "Sauvegarder Configuration";
				monSauvegardeur.FilterIndex = 2;
				if (monSauvegardeur.ShowDialog() == DialogResult.OK)
				{
					
					var file = monSauvegardeur.OpenFile();
                    try
                    {
						using (StreamWriter writer = new StreamWriter(file))
						{
							writer.Write(contenu);
						}
                    }
                    catch(NullReferenceException e)
                    {
						MessageBox.Show("Réference nulle !");
                    }
                    catch(Exception e)
                    {
						MessageBox.Show(e.Message);
                    }	
				}

			}
			
			


		}
		public void sauvegarderConfig(object sender, EventArgs e)
		{
			cacherTouslesComposantsGraphiques();
			userControlConfig.Visible = true;




		}

		public void chargerConfig(object sender, EventArgs e)
		{
			using (OpenFileDialog monChargeur=new OpenFileDialog())
			{
				String path = Directory.GetCurrentDirectory();
				monChargeur.InitialDirectory = "..\\..\\" + path;
				monChargeur.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
				monChargeur.Title = "Charger Configuration";
				monChargeur.FilterIndex = 2;
				
				if (monChargeur.ShowDialog() == DialogResult.OK)
				{

					var file = monChargeur.OpenFile();
					try
					{


						using (StreamReader reader = new StreamReader(file))
						{
							int[] tableau = new int[10];
							String line = reader.ReadLine();
							bool read = false;
							while (line != null)
							{
								if (line.Contains("Debut"))
								{
									read = true;
								}
								line = reader.ReadLine();
								if (line != null && line.Contains(";"))
								{
									tableau = Array.ConvertAll(line.Split(';'), int.Parse);
									ChargerConfigDansLesTrames(tableau[0], tableau[2], tableau[3],"Intervalle");
								}
							}

						}
					}
					catch (NullReferenceException s)
					{
						MessageBox.Show("Mauvais type de fichier !");
					}
					catch (Exception s)
                    {
						MessageBox.Show(s.Message);
                    }          
                }
			}
		}

		public void sauverConfig_Click(object sender, EventArgs e)
		{
			int id;
			int intervalleMin;
			int intervalleMax;
			int.TryParse(userControlConfig.getIdConfig(), out id);
			int.TryParse(userControlConfig.getintervMinConfig(), out intervalleMin);
			int.TryParse(userControlConfig.getintervMaxConfig(), out intervalleMax);
			ChargerConfigDansLesTrames(id, intervalleMin, intervalleMax,"Intervalle");
			sauvegarderConfigDansUnFichier();
		}

		public void ChargerConfigDansLesTrames(int id,int min,int max,string intervalleOuAlarme)
		{
			if (id < 11 && id > 0)
			{
				foreach (IdBase trame in listeTram)
				{


					if (trame.id == id)
					{
						if (intervalleOuAlarme.Equals("Intervalle"))
						{

							((IdMesure)trame).intervalleMin = min;
							((IdMesure)trame).intervalleMax = max;
						}
						else if (intervalleOuAlarme.Equals("Alarme"))
						{
							((IdMesure)trame).alarmeMin = min;
							((IdMesure)trame).alarmeMax = max;
						}
						MettreAJourGrid(((IdMesure)trame));
						calculDataconvertiTrame(((IdMesure)trame));

					}
				}
				
				
			}
		}

		private void addConfig_Click(object sender, EventArgs e)
		{
			int id;
			int intervalleMin;
			int intervalleMax;
			int.TryParse(userControlConfig.getintervMinConfig(), out intervalleMin);
			int.TryParse(userControlConfig.getIdConfig(), out id);
			int.TryParse(userControlConfig.getintervMaxConfig(), out intervalleMax);
			ChargerConfigDansLesTrames(id, intervalleMin, intervalleMax,"Intervalle");
		}


		private void ajouterAlarme(object sender, EventArgs e)
		{
			int id;
			int AlarmeMin;
			int AlarmeMax;
			int.TryParse(userControl_AddAlarme.alarmeMinConfigAlarme.Text, out AlarmeMin);
			int.TryParse(userControl_AddAlarme.idConfigAlarme.Text, out id);
			int.TryParse(userControl_AddAlarme.alarmeMaxConfigAlarme.Text, out AlarmeMax);
			ChargerConfigDansLesTrames(id,AlarmeMin, AlarmeMax,"Alarme");
		}
	}
}


