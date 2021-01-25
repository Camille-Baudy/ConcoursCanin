using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcoursCanin
{
    public partial class FormAccueil : Form
    {
        public FormAccueil()
        {
            InitializeComponent();
        }

        private void btn_formConcours_Click(object sender, EventArgs e)
        {
            //on ouvre le formConcours et on ferme le formAccueil
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform));
            monthread.Start();
            this.Close();
        }
        public static void ouvrirnouveauform()
        {
            Application.Run(new FormConcours());
        }

        private void btn_formResultat_Click(object sender, EventArgs e)
        {
            //on ouvre le formResultat et on ferme le formAccueil
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform2));
            monthread.Start();
            this.Close();
        }
        public static void ouvrirnouveauform2()
        {
            Application.Run(new FormResultat());
        }

        private void btn_formChien_Click(object sender, EventArgs e)
        {
            //on ouvre le formChien et on ferme le formAccueil
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform3));
            monthread.Start();
            this.Close();
        }
        public static void ouvrirnouveauform3()
        {
            Application.Run(new FormChien());
        }

        private void FormAccueil_Load(object sender, EventArgs e)
        {

        }
    }
    
}
