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
    public partial class Form1 : Form
    {
        
        int gridColumns = 5;
        int gridRows = 1;
        int boxwidth = 125;
        int boxheight = 25;
        List<byte> tableInter = new List<byte>();
        DataTable dt = new DataTable();
        static ArrayList listeTram = new ArrayList();
        public Form1()
        {
            InitializeComponent();

            //UserControl pour save/load Configuration
            this.userControlConfig = new UserControl_config();
            this.userControlConfig.Location = new System.Drawing.Point(100, 50);
            this.userControlConfig.Name = "userControlConfig";
            this.userControlConfig.Size = new System.Drawing.Size(370, 393);
            this.userControlConfig.TabIndex = 11;
            this.userControlConfig.validerConfig.Click += new System.EventHandler(sauverConfig_Click);
            this.Controls.Add(userControlConfig);
            userControlConfig.Visible = false;
            this.userControlConfig.addConfig.Click += new System.EventHandler(addConfig_Click);
            this.userControl_newuser.submit_newuser.Click += new System.EventHandler(ajouterUtilisateurClick);
            creerUserTable();
            creerAccesTable();
            recupererAccesDeLaBd();
            MakeDataRelation();
            BindToDataGrid();
            
            recupererUtilisateursDeLaBd();
           
            /*insererUnUtilisateur();
            supprimerUnUtilisateur();*/
            
           


        }


        private void Form1_Load(object sender, EventArgs e)
        {
            grid.ColumnCount = gridColumns;
            grid.Rows.Add("ID", "TYPE", "DATA CONVERTIE", "INTERVALLE MIN", "INTERVALLE MAX");
            for (int i = 0; i < gridColumns; i++)
            {
                grid.Columns[i].Width = boxwidth;
                
                
            }
            for (int i = 0; i < grid.RowCount; i++)
            {
                grid.Rows[i].Height = boxheight;

            }
            grid.Width = boxwidth * gridColumns + 3;
            grid.Height = boxheight*gridRows+3;
            try
            {
                serialPort.DataReceived += new SerialDataReceivedEventHandler(recupererDonneeBuffer);
                serialPort.Open();
            }
            catch (NullReferenceException d)
            {
                MessageBox.Show("Le port choisi n'existe pas !");
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
            

        }

        private void recupererDonneeBuffer(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] tab;
            int count = serialPort.BytesToRead;
            tab = new byte[count];
            serialPort.Read(tab, 0, count);
            for (int i = 0; i < tab.Length; i++)
            {
                tableInter.Add(tab[i]);
            }


        }

        private void timer_Tick(object sender, EventArgs e)
        {          
            int i = 0;
            while (tableInter.Count != 0)
            {
                if (verifSiTrameCorrecte())
                {
                    
                        int longueurTrame = 10 + tableInter[i + 4];
                        instantierTrame(longueurTrame, i);
                }
                else
                {
                    tableInter.RemoveAt(0);
                }
            }
        }
        
      
        

        private Boolean verifSiTrameCorrecte()
        {
            Boolean bReturn = false;
            if (tableInter.Count > 9 && tableInter[0] == 85 && tableInter[1] == 170 && tableInter[2] == 85 && tableInter[3] <= 50)
            {
                int debutDeFinDeTrame = 7 + tableInter[4];
                if (debutDeFinDeTrame + 2 < tableInter.Count && tableInter[debutDeFinDeTrame] == 170 && tableInter[debutDeFinDeTrame + 1] == 85 && tableInter[debutDeFinDeTrame + 2] == 170)
                {
                    bReturn = true;
                }
            }
                return bReturn;
        }


        public void instantierTrame(int longueurTrame, int indiceTramDansTab)
        {
            int id = tableInter[3];
            int nbr = tableInter[4];
            int type = tableInter[5];
            ulong data = 0;
            int data0 = 0;
            int data1 = 0;
            int data2 = 0;
            int data3 = 0;
            
            if (nbr > 0)
            {
                data0 = tableInter[indiceTramDansTab + 6];
                data = (ulong)data0;
            }
            if (nbr > 1)
            {
                data1 = tableInter[indiceTramDansTab + 7];
                ulong temp = (ulong)data1;
                temp <<= 8;
                data += temp;
            }
            if (nbr > 2)
            {
                data2 = tableInter[indiceTramDansTab + 8];
                ulong temp = (ulong)data2;
                temp <<= 16;
                data += temp;
            }
            if (nbr > 3)
            {
                data3 = tableInter[indiceTramDansTab + 9];
                ulong temp = (ulong)data3;
                temp <<= 24;
                data += temp;
            }

            if (tableInter[3] == 50)
            {
                placerTrameAlarme(id, nbr,type, data, 0, 0, 0);
            }
            else if (tableInter[3] == 0)
            {
                placerTrameKeepAlive(id, nbr, type, data);

            }
            else if (tableInter[3] < 11)
            {
                placerTrameMesure(id, nbr, type, data);
            }

            supprimerTrameTableauByte(longueurTrame);
        }

        public void supprimerTrameTableauByte(int longueurTrame)
        {
            for (int i = 0; i < longueurTrame; i++)
            {
                tableInter.RemoveAt(0);
            }
        }

        public void placerTrameKeepAlive(int id, int nbr, int type, ulong data)
        {
            bool placer = false;
            foreach (IdBase trame in listeTram)
            {
                if (trame.id == id && !placer)
                {
                    trame.nbData = nbr;
                    trame.type = type;
                    trame.data = data;
                    placer = true;
                }
            }
            if (!placer)
            {
                IdBase trame = new IdBase(id, nbr, type, data);
                listeTram.Add(trame);
                DataGridViewRow row = (DataGridViewRow)grid.Rows[0].Clone();
                row.Cells[0].Value = trame.id;
                row.Cells[1].Value = "Keep Alive";
                gridRows++;
                grid.Height = boxheight * gridRows + 3;
                grid.Invoke((MethodInvoker)(() => grid.Rows.Add(row)));
            }
        }

        public void placerTrameAlarme(int id, int nbr, int type, ulong data, int idAlarme, int typeAlarme, int etat)
        {
            bool placer = false;
            foreach (IdBase trame in listeTram)
            {
                if (trame.id == id && !placer)
                {
                      IdAlarme trameCorrecte = (IdAlarme)trame;
                      trameCorrecte.nbData = nbr;
                      trameCorrecte.type = type;
                      trameCorrecte.data = data;
                      trameCorrecte.idAl = idAlarme;
                      trameCorrecte.typeAlarme = typeAlarme;
                      trameCorrecte.etat = etat;
                      placer = true;
                    MettreAJourGrid(trameCorrecte);

                }
            }
            if (!placer)
            {
                IdAlarme trame = new IdAlarme();
                trame.id = id;
                trame.nbData = nbr;
                trame.type = type;
                trame.data = data;
                listeTram.Add(trame);
                DataGridViewRow row = (DataGridViewRow)grid.Rows[0].Clone();
                row.Cells[0].Value = trame.id;
                row.Cells[1].Value = trame.type;
                gridRows++;
                grid.Height = boxheight * gridRows + 3;
                grid.Invoke((MethodInvoker)(() => grid.Rows.Add(row)));
                

            }
        }
        public void placerTrameMesure(int id, int nbr, int type, ulong data)
        {
            bool placer = false;
            foreach (IdBase trame in listeTram)
            {
                if (trame.id == id && !placer)
                {
                    IdMesure trameCorrecte = (IdMesure)trame;
                    trameCorrecte.nbData = nbr;
                    trameCorrecte.type = type;
                    trameCorrecte.data = data;
                    trameCorrecte.dataConverti = calculDataconvertiTrame(trameCorrecte);
                    placer = true;
                    MettreAJourGrid(trameCorrecte);
                    if (trameCorrecte.id == idgraphiqueAAfficher&&graphiqueOuvert)
                    {
                        graphControl1.ajoutervaleur((int)trameCorrecte.dataConverti,trameCorrecte.id);

                    }
                }
            }
            if (!placer)
            {
                IdMesure trame = new IdMesure();
                trame.id = id;
                trame.nbData = nbr;
                trame.type = type;
                trame.data = data;
                trame.dataConverti = calculDataconvertiTrame(trame);
                listeTram.Add(trame);
                DataGridViewRow row = (DataGridViewRow)grid.Rows[0].Clone();
                row.Cells[0].Value = trame.id;
                row.Cells[1].Value = trame.type;
                row.Cells[3].Value = trame.intervalleMin;
                row.Cells[4].Value = trame.intervalleMax;
                gridRows++;
                grid.Height = boxheight * gridRows + 3;
                grid.Invoke((MethodInvoker)(() => grid.Rows.Add(row)));
                if (trame.id == idgraphiqueAAfficher && graphiqueOuvert)
                {
                   
                    graphControl1.ajoutervaleur((int)trame.dataConverti, trame.id);
                }
            }


        }

        private void MettreAJourGrid(IdAlarme trame)
        {
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                for (int j = 0; j < grid.Columns.Count; j++)
                {
                    if (j == 0 && grid.Rows[i].Cells[j].Value.ToString() == trame.id.ToString())
                    {
                        grid.Rows[i].Cells[j + 1].Value = "Alarme";
                    }

                }
            }



        }

        private void MettreAJourGrid(IdMesure trame)
        {
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                for (int j = 0; j < grid.Columns.Count; j++)
                {
                    if (j == 0 && grid.Rows[i].Cells[j].Value.ToString() == trame.id.ToString())
                    {                      
                        grid.Rows[i].Cells[j + 3].Value = trame.intervalleMin;
                        grid.Rows[i].Cells[j + 4].Value = trame.intervalleMax;
                        grid.Rows[i].Cells[j + 2].Value = trame.dataConverti;
                        if (trame.type == 1)
                        {
                            grid.Rows[i].Cells[j + 1].Value = "Température";
                        }
                        else if (trame.type == 2)
                        {
                            grid.Rows[i].Cells[j + 1].Value = "Humidité";
                        }
                        else if (trame.type == 3)
                        {
                            grid.Rows[i].Cells[j + 1].Value = "Pression atmosphérique";
                        }
                        else if (trame.type == 4)
                        {
                            grid.Rows[i].Cells[j + 1].Value = "Luminosité";
                        }
                    }

                }
            }

            
        }

        private float calculDataconvertiTrame(IdMesure trame)
        {
            long temp = (int)Math.Pow(2, trame.nbData * 8);
            float calcul = trame.data / (float)temp * (trame.intervalleMax - trame.intervalleMin) + trame.intervalleMin;
            return calcul;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            grid.Visible = true;
            userControlConfig.Visible = false;
            graphiqueOuvert = false;
            graphControl1.Visible = false;
        }

        
    }
}
