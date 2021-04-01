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
        public GraphControl()
        {
            
            InitializeComponent();
            
        }

        public void ajoutervaleur(int value)
        {
            
            chart.Series["Series1"].Points.AddXY(indiceX, value);
            indiceX=indiceX+1;

            if (indiceX == 10)
            {
                indiceX = 0;
                viderGraphique();
            }
        }
        public void viderGraphique()
        {
            chart.Series["Series1"].Points.Clear();
        }

        public int getX()
        {
            return indiceX;
        }


    }
}
