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

        int erreurCheckSum;
        byte[] tab;
        List<byte> tableInter = new List<byte>();
        DataTable dt = new DataTable();
        static ArrayList listeTram = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid.ColumnCount = 14;
            grid.Rows.Add("id","nbrData","type","data","Alarme");
            serialPort.DataReceived += new SerialDataReceivedEventHandler(displayDataOnGrid);
            serialPort.Open();

        }

        private void timerRead_Tick(object sender, EventArgs e)
        {
            
        }

        private void displayDataOnGrid(object sender,SerialDataReceivedEventArgs e)
        {
            int count = serialPort.BytesToRead;
            tab = new byte[count];
            serialPort.Read(tab,0,count);
            addToTempArray(count);

        }

        private void addToTempArray(int count)
        {
            String sum = "";          
            for (int i = 0; i < tab.Length; i++)
            {
                sum += tab[i]+"/";
                tableInter.Add(tab[i]);
            }
            for (int i = 0; i < tableInter.Count; i++)
            {
                if (i + 11< tableInter.Count && tableInter[i]==85&& tableInter[i + 1] == 170 && tableInter[i + 2] == 85&& tableInter[i + 3] < 11 && tableInter[(i + 7) + tableInter[i + 4]] == 170 && tableInter[(i + 8) + tableInter[i + 4]] == 85&& tableInter[(i + 9) + tableInter[i + 4]] == 170)
                {
                    int longueurTrame = 10 + tableInter[i + 4];
                    instantierTrame(longueurTrame,i);
                }
            }

        }


        public void instantierTrame(int longueurTrame,int indiceTramDansTab)
        {
            int id= tableInter[indiceTramDansTab + 3];
            int nbr= tableInter[indiceTramDansTab + 4];
            int type= tableInter[indiceTramDansTab + 5];
            byte cheksum=0;
            ulong data=0;
            int data0 = 0;
            int data1 = 0;
            int data2 = 0;
            int data3 = 0;

            if (nbr > 0)
            {
                data0= tableInter[indiceTramDansTab + 6];
                data=(ulong)data0;
                cheksum= tableInter[indiceTramDansTab + 7];
            }
            if (nbr > 1)
            {
                data1 = tableInter[indiceTramDansTab + 7];
                ulong temp = (ulong)data1;
                temp <<= 8;
                data += temp;
                cheksum = tableInter[indiceTramDansTab + 8];
            }
            if (nbr > 2)
            {
                data2 = tableInter[indiceTramDansTab + 8];
                ulong temp = (ulong)data2;
                temp <<= 16;
                data += temp;
                cheksum = tableInter[indiceTramDansTab + 9];
            }
            if (nbr > 3)
            {
                data3 = tableInter[indiceTramDansTab + 9];
                ulong temp = (ulong)data3;
                temp <<= 24;
                data += temp;
                cheksum = tableInter[indiceTramDansTab + 10];
            }
            byte checksumCalculer = (byte)(id+nbr+type+data0+data1+data2+data3);

            if (cheksum != checksumCalculer)
            {
                erreurCheckSum++;
                MessageBox.Show("Erreur égalité des CheckSum !!!");
            }
            //MessageBox.Show(data.ToString());
            if (tableInter[indiceTramDansTab + 3] == 0)
            {
                //MessageBox.Show("Je vais créer un id de base");
                placerTrameKeepAlive(id, nbr, type, data);
                
            }
            else if (tableInter[indiceTramDansTab + 3] <11)
            {
                //MessageBox.Show("Je vais créer un id de mesure");
                placerTrameMesure(id, nbr, type, data);
            }
            else if (tableInter[indiceTramDansTab + 3] == 50)
            {
                //MessageBox.Show("Je vais créer un id d'alarme");
                placerTrameAlarme(0,0,0,0,0,0,0);
            }
            supprimerTrameTableauByte(longueurTrame);
        }

        public void supprimerTrameTableauByte(int longueurTrame)
        {
            for(int i = 0; i < longueurTrame; i++)
            {
                tableInter.RemoveAt(0);
            }
        }

        public void placerTrameKeepAlive(int id, int nbr,int type,ulong data)
        {
            bool placer = false;
            foreach(IdBase trame in listeTram)
            {
                if (trame.id == id&&!placer)
                {
                    trame.nbData = nbr;
                    trame.type = type;
                    trame.data = data;
                    placer = true;
                    MettreAJourGrid(trame);
                }
            }
            if (!placer)
            {
                IdBase trame = new IdBase(id, nbr, type, data);
                listeTram.Add(trame);
                DataGridViewRow row = (DataGridViewRow)grid.Rows[0].Clone();
                row.Cells[0].Value = trame.id;
                row.Cells[1].Value = trame.nbData;
                row.Cells[2].Value = trame.type;
                row.Cells[3].Value = trame.data;
                row.Cells[4].Value = trame.alarme;
                grid.Invoke((MethodInvoker)(() => grid.Rows.Add(row)));
            }
        }

        public void placerTrameAlarme(int id, int nbr, int type, ulong data,int idAlarme,int typeAlarme,int etat)
        {
            bool placer = false;
            foreach (IdBase trame in listeTram)
            {
                if (trame.id == id && !placer)
                {
                    IdAlarme trameCorrecte =(IdAlarme) trame;
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
                IdAlarme trame = new IdAlarme(0, 0, 0);
                listeTram.Add(trame);

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
                    placer = true;
                    MettreAJourGrid(trameCorrecte);
                }
            }
            if (!placer)
            {
                IdMesure trame = new IdMesure();
                trame.id = id;
                trame.nbData = nbr;
                trame.type = type;
                trame.data = data;
                listeTram.Add(trame);
                DataGridViewRow row = (DataGridViewRow)grid.Rows[0].Clone();
                row.Cells[0].Value = trame.id;
                row.Cells[1].Value = trame.nbData;
                row.Cells[2].Value = trame.type;
                row.Cells[3].Value = trame.data;
                row.Cells[4].Value = trame.alarme;
                row.Cells[5].Value = trame.intervalleMin;
                row.Cells[6].Value = trame.intervalleMax;
                grid.Invoke((MethodInvoker)(() => grid.Rows.Add(row)));
            }
            
        }

        private void MettreAJourGrid(IdBase trame)
        {
            for(int i = 0; i < grid.Rows.Count;i++)
            {
                for (int j = 0; j < grid.Columns.Count;j++)
                {
                    if (j == 0 && grid.Rows[i].Cells[j].Value.ToString() == trame.id.ToString())
                    {
                        grid.Rows[i].Cells[j + 1].Value = trame.nbData;
                        grid.Rows[i].Cells[j + 2].Value = trame.type;
                        grid.Rows[i].Cells[j + 3].Value = trame.data;
                        grid.Rows[i].Cells[j + 4].Value = trame.alarme;
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
                        grid.Rows[i].Cells[j + 1].Value = trame.nbData;
                        grid.Rows[i].Cells[j + 2].Value = trame.type;
                        grid.Rows[i].Cells[j + 3].Value = trame.data;
                        grid.Rows[i].Cells[j + 4].Value = trame.alarme;
                        grid.Rows[i].Cells[j + 5].Value = trame.intervalleMin;
                        grid.Rows[i].Cells[j + 6].Value = trame.intervalleMax;
                    }

                }
            }
        }



        private void validerConfig_Click(object sender, EventArgs e)
        {
            int id;
            int intervalleMin;
            int intervalleMax;
            int.TryParse(idConfig.Text, out id);
            int.TryParse(intervMinConfig.Text, out intervalleMin);
            int.TryParse(intervMaxConfig.Text, out intervalleMax);
            ChargerConfigDansLesTrames(id, intervalleMin, intervalleMax);
            check();
        }

        public void ChargerConfigDansLesTrames(int id,int intervalleMin,int intervalleMax)
        {
            if (id < 11 && id > 0)
            {
                foreach (IdBase trame in listeTram)
                {


                    if (trame.id == id)
                    {
                        ((IdMesure)trame).intervalleMin = intervalleMin;
                        ((IdMesure)trame).intervalleMax = intervalleMax;
                        MettreAJourGrid(((IdMesure)trame));
                        calculDataconvertiTrame(((IdMesure)trame));

                    }
                }
            }
        }

        private void calculDataconvertiTrame(IdMesure trame)
        {
            long temp = (int)Math.Pow(2,trame.nbData*8);
            MessageBox.Show("temp : "+temp);
            float calcul= trame.data / (float)temp* (trame.intervalleMax - trame.intervalleMin) + trame.intervalleMin;
            MessageBox.Show("reponse calcul : " + calcul+" et data ="+trame.data);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            grid.Visible = true;
            labelConfig1.Visible = false;
            labelConfig2.Visible = false;
            labelConfig3.Visible = false;
            labelConfig4.Visible = false;
            idConfig.Visible = false;
            intervMinConfig.Visible = false;
            intervMaxConfig.Visible = false;
            addConfig.Visible = false;
            validerConfig.Visible = false;
        }

        private void addConfig_Click(object sender, EventArgs e)
        {
            int id;
            int intervalleMin;
            int intervalleMax;
            int.TryParse(idConfig.Text, out id);
            int.TryParse(intervMinConfig.Text, out intervalleMin);
            int.TryParse(intervMaxConfig.Text, out intervalleMax);
            ChargerConfigDansLesTrames(id, intervalleMin, intervalleMax);
        }
    }
}
