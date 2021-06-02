using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationMeteo
{
    public partial class GraphControl : UserControl
    {
        int indiceX = 0;
        int idActuel;
        List<int> tabGraphique = new List<int>();
        
        public GraphControl()
        {
            
            InitializeComponent();

            

        }
        public void ajoutervaleur(int value,int id)
        {
            if (id != idActuel)
            {
                viderGraphique();
                tabGraphique = new List<int>();
            }
            if (idActuel == id)
            {
                tabGraphique.Add(value);
                viderGraphique();
                if (tabGraphique.Count > 10)
                {
                    tabGraphique.RemoveAt(0);
                }
                for (int i = 0; i < tabGraphique.Count; i++)
                {
                    chart.Series["Series valeurs trames"].Points.AddXY(i, tabGraphique[i]);
                }
                
            }
            if (indiceX == 10||idActuel!=id)
            {
                indiceX = 0;
                viderGraphique();
            }
            idActuel = id;
            label_graphique.Text = "Graphique de l'id : " + idActuel;
            
        }
        public void viderGraphique()
        {
            chart.Series["Series valeurs trames"].Points.Clear();
        }




    }
}
