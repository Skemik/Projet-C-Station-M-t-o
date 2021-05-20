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
        
        int gridColumns = 6;
        int gridRows = 1;
        int boxwidth = 125;
        int boxheight = 25;
        List<byte> tableInter = new List<byte>();
        static ArrayList listeTram = new ArrayList();
        Config.UserControl_AddAlarme userControl_AddAlarme;
        Utilisateur.UserControl_NouveauUtilisateur userControl_newuser;
        Utilisateur.UserControl_Connexion userControl_Connexion;
        Utilisateur.UserControl_SupprimerUtilisateur userControl_SupprimerUtilisateur;
        Config.UserControl_portCom userControl_portCom;
        DataGridView grid_userTable;
        DataGridView grid_accessTable;
        DataGridView grid;
        GraphControl graphControl1;
        Button update_button;
        Label label_portcom;
        TabControl tabControl_users;
        TabPage tabPage1 = new TabPage();
        TabPage tabPage2 = new TabPage();


        public Form1()
        {
            InitializeComponent();

            //UserControl pour save/load Configuration
            this.userControlConfig = new UserControl_config();
            this.userControlConfig.Location = new System.Drawing.Point(12, 33);
            this.userControlConfig.Name = "userControlConfig";
            this.userControlConfig.Size = new System.Drawing.Size(370, 393);
            this.userControlConfig.TabIndex = 11;
            this.Controls.Add(userControlConfig);
            userControlConfig.Visible = false;
            this.userControlConfig.addConfig.Click += new System.EventHandler(addConfig_Click);
            
            //User control Alarme
            userControl_AddAlarme = new Config.UserControl_AddAlarme();
            userControl_AddAlarme.Location = new System.Drawing.Point(12, 33);
            userControl_AddAlarme.Name = "userControl_AddAlarme";
            userControl_AddAlarme.Size = new System.Drawing.Size(270, 217);
            userControl_AddAlarme.TabIndex = 18;
            userControl_AddAlarme.Visible = false;
            userControl_AddAlarme.submit_alarme.Click+= new System.EventHandler(ajouterAlarme);
            Controls.Add(userControl_AddAlarme);

            // userControl_Connexion
            userControl_Connexion = new Utilisateur.UserControl_Connexion();
            userControl_Connexion.Location = new System.Drawing.Point(12, 27);
            userControl_Connexion.Name = "userControl_Connexion";
            userControl_Connexion.Size = new System.Drawing.Size(364, 367);
            userControl_Connexion.TabIndex = 14;
            userControl_Connexion.Visible = false;
            this.userControl_Connexion.connexion_submit.Click += new System.EventHandler(connexionUtilisateur);
            Controls.Add(userControl_Connexion);

            //grid User table
            grid_userTable = new DataGridView();
            grid_userTable.AllowUserToAddRows = false;
            grid_userTable.AllowUserToDeleteRows = false;
            grid_userTable.AllowUserToOrderColumns = true;
            grid_userTable.AllowUserToResizeColumns = false;
            grid_userTable.AllowUserToResizeRows = false;
            grid_userTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_userTable.Location = new System.Drawing.Point(12, 60);
            grid_userTable.Name = "grid_userTable";
            grid_userTable.RowHeadersVisible = false;
            grid_userTable.ScrollBars = ScrollBars.None;
            grid_userTable.Size = new System.Drawing.Size(501, 193);
            grid_userTable.TabIndex = 12;
            grid_userTable.Visible = false;
            Controls.Add(grid_userTable);

            //grid Acces Table
            grid_accessTable = new DataGridView();
            grid_accessTable.AllowUserToAddRows = false;
            grid_accessTable.AllowUserToDeleteRows = false;
            grid_accessTable.AllowUserToOrderColumns = true;
            grid_accessTable.AllowUserToResizeColumns = false;
            grid_accessTable.AllowUserToResizeRows = false;
            grid_accessTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_accessTable.Location = new System.Drawing.Point(12, 285);
            grid_accessTable.Name = "grid_accessTable";
            grid_accessTable.RowHeadersVisible = false;
            grid_accessTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            grid_accessTable.Size = new System.Drawing.Size(501, 191);
            grid_accessTable.TabIndex = 13;
            grid_accessTable.Visible = false;
            grid_accessTable.ReadOnly = true;
            Controls.Add(grid_accessTable);

            //grid trame view 
            grid = new DataGridView();
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = true;
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.ReadOnly = true;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.ColumnHeadersVisible = false;
            grid.Location = new System.Drawing.Point(12, 61);
            grid.Name = "grid";
            grid.RowHeadersVisible = false;
            grid.Size = new System.Drawing.Size(677, 153);
            grid.TabIndex = 0;
            grid.Visible = false;
            Controls.Add(grid);


            //Graphique
            graphControl1 = new GraphControl();
            graphControl1.Location = new System.Drawing.Point(12, 33);
            graphControl1.Name = "graphControl1";
            graphControl1.Size = new System.Drawing.Size(432, 405);
            graphControl1.TabIndex = 11;
            graphControl1.Visible = false;
            Controls.Add(graphControl1);


            //button update 
            update_button = new Button();
            update_button.Location = new System.Drawing.Point(215,35);
            update_button.Name = "update_button";
            update_button.Size = new System.Drawing.Size(94, 23);
            update_button.TabIndex = 17;
            update_button.Text = "Mettre à jour";
            update_button.UseVisualStyleBackColor = true;
            update_button.Visible = false;
            update_button.Click += new System.EventHandler(this.update);
            Controls.Add(update_button);

            // userControl_portCom
            userControl_portCom = new Config.UserControl_portCom();
            userControl_portCom.Location = new System.Drawing.Point(12, 27);
            userControl_portCom.Name = "userControl_portCom";
            userControl_portCom.Size = new System.Drawing.Size(303, 236);
            userControl_portCom.TabIndex = 10;
            userControl_portCom.Visible = false;
            userControl_portCom.submit_portCom.Click += new EventHandler(submit_portCOM);
            Controls.Add(userControl_portCom);

            //Tabcontrol
            tabControl_users = new TabControl();
            tabControl_users.Controls.Add(this.tabPage1);
            tabControl_users.Controls.Add(this.tabPage2);
            tabControl_users.Location = new System.Drawing.Point(517, 27);
            tabControl_users.Name = "tabControl_users";
            tabControl_users.SelectedIndex = 0;
            tabControl_users.Size = new System.Drawing.Size(283, 240);
            tabControl_users.TabIndex = 10;
            tabControl_users.Visible = false;
            Controls.Add(tabControl_users);

            // tabPage1
            tabPage1.Location = new System.Drawing.Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = new System.Drawing.Size(275, 214);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ajout";
            tabPage1.UseVisualStyleBackColor = true;

            // userControl_NouveauUtilisateur1
            userControl_newuser = new Utilisateur.UserControl_NouveauUtilisateur();
            userControl_newuser.Location = new System.Drawing.Point(6, 3);
            userControl_newuser.Name = "userControl_NouveauUtilisateur1";
            userControl_newuser.Size = new System.Drawing.Size(293, 299);
            userControl_newuser.TabIndex = 0;
            userControl_newuser.submit_newuser.Click += new System.EventHandler(ajouterUtilisateurClick);
            tabPage1.Controls.Add(this.userControl_newuser);

            // tabPage2
            tabPage2.Location = new System.Drawing.Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(3);
            tabPage2.Size = new System.Drawing.Size(275, 214);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Suppression";
            tabPage2.UseVisualStyleBackColor = true;

            // userControl_SupprimerUtilisateur1
            userControl_SupprimerUtilisateur = new Utilisateur.UserControl_SupprimerUtilisateur();
            userControl_SupprimerUtilisateur.Location = new System.Drawing.Point(3, 0);
            userControl_SupprimerUtilisateur.Name = "userControl_SupprimerUtilisateur";
            userControl_SupprimerUtilisateur.Size = new System.Drawing.Size(266, 267);
            userControl_SupprimerUtilisateur.TabIndex = 0;
            userControl_SupprimerUtilisateur.deleteUser_submit.Click += new System.EventHandler(supprimerUtilisateur);
            tabPage2.Controls.Add(this.userControl_SupprimerUtilisateur);
 
            // label_portcom
            label_portcom = new Label();
            label_portcom.AutoSize = true;
            label_portcom.Location = new System.Drawing.Point(12, 42);
            label_portcom.Name = "label_portcom";
            label_portcom.Size = new System.Drawing.Size(110, 13);
            label_portcom.TabIndex = 10;
            label_portcom.Text = "Port COM : Non défini";
            label_portcom.Visible = false;
            Controls.Add(label_portcom);


            ConfigDataset();
            Utilisateur.Tools.Config();
            Utilisateur.Adapter.Fill(Local_UserAccess, "Local_AccessTable", "AccessTable", grid_accessTable);
            gererAccesSelonDroits(access_Id);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            grid.ColumnCount = gridColumns;
            grid.Rows.Add("ID", "TYPE", "DATA CONVERTIE", "INTERVALLE MIN", "INTERVALLE MAX","STATUT");
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
                        if (trame.alarmeMin != 0 || trame.alarmeMax != 0)
                        {
                            if (trame.dataConverti <= trame.alarmeMin)
                            {
                                grid.Rows[i].Cells[j + 5].Value = "Trop faible !!";
                            }
                            else if (trame.dataConverti >= trame.alarmeMax)
                            {
                                grid.Rows[i].Cells[j + 5].Value = "Trop Haut !!";
                            }
                            else
                            {
                                grid.Rows[i].Cells[j + 5].Value = "Normal";
                            }
                        }
                        else
                        {
                            grid.Rows[i].Cells[j + 5].Value = "Alarme non défini";
                        }
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
            cacherTouslesComposantsGraphiques();
            grid.Visible = true;
            label_portcom.Visible = true;

        }

        private void ajouterAlarmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cacherTouslesComposantsGraphiques();
            userControl_AddAlarme.Visible = true;

        }

        private void portCOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cacherTouslesComposantsGraphiques();
            userControl_portCom.Visible = true;

        }


        private void submit_portCOM(object sender, EventArgs e)
        {
            serialPort.Close();
            serialPort.PortName = userControl_portCom.input_portCom.Text;
            label_portcom.Text = "Port COM : " + serialPort.PortName;
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

        private void cacherTouslesComposantsGraphiques()
        {
            userControl_portCom.Visible = false;
            userControl_AddAlarme.Visible = false;
            grid.Visible = false;
            userControlConfig.Visible = false;
            graphiqueOuvert = false;
            graphControl1.Visible = false;
            update_button.Visible = false;
            grid_accessTable.Visible = false;
            grid_userTable.Visible = false;
            userControlConfig.Visible = false;
            graphiqueOuvert = false;
            graphControl1.Visible = false;    
            userControl_Connexion.Visible = false;
            label_portcom.Visible = false;
            tabControl_users.Visible = false;

        }

    }
}
