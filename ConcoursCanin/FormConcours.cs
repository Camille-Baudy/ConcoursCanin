using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcoursCanin
{
    public partial class FormConcours : Form
    {
      //  private CONCOURSCANINEntities1 monModele2;
        private CONCOURSCANINEntities2 monModele;
       
        public FormConcours()
        {
            InitializeComponent();
            monModele = new CONCOURSCANINEntities2();
        }

        //chargement du datagridview
        #region FormConcours_Load
        private void FormConcours_Load(object sender, EventArgs e)
        {
            reload(); //on affiche le dgv_Concours

            //on cache le label code car il n'apparaitra que pour les modifications
            //ou les suppressions car le code ne pas être changé (il est l'id)
            con_lbl_code.Hide();

            //on cache les boutons modifier et supprimer qui apparaitront que quand on sélectionnera une ligne dans le tableau
            con_btn_Suppr.Hide();
            con_btn_modifier.Hide();
        }
        #endregion

        //procédure reload() pour charger le datagridview
        #region reload()
        public void reload() //charger le dtg_Concours
        {
            var req = from c in monModele.CONCOURS
                      select c;
            bdgSourceConcours.DataSource = req.ToList();
            dgv_Concours.DataSource = bdgSourceConcours;
        }
        #endregion

        //retourner à l'accueil
        #region bouton retour
        private void btn_return_Click(object sender, EventArgs e) //returner à l'accueil
        {
            //on ouvre le formAccueil et on ferme le formConcours
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform));
            monthread.Start();
            this.Close();
        }
        public static void ouvrirnouveauform()
        {
            Application.Run(new FormAccueil());
        }
        #endregion

        //ajouter un concours
        #region bouton ajouter
        private void con_btn_ajouter_Click(object sender, EventArgs e) //ajouter un concours
        {
            //on regarde si le formualire est vide ou non
            if (con_txb_code.Text == "" && con_txb_adresse.Text == "" && con_txb_cp.Text == "" && con_txb_date.Text == "" && con_txb_salle.Text == "" && con_txb_ville.Text == "")
            {
                MessageBox.Show("Votre formualire est vide !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //on va regarder si le code est libre
                var req = monModele.CONCOURS.Find(con_txb_code.Text);
                if (req != null) //si le concours existe déjà
                {
                    //on prévient l'utilisateur
                    MessageBox.Show("Le code concours " + con_txb_code.Text + " existe déjà !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //on remet à vide le champ du code
                    con_txb_code.Clear();
                }
                else //si le concours n'existe pas
                {
                    try
                    {
                        var unConcours = new CONCOURS()
                        {
                            codeconcours = con_txb_code.Text,
                            adresseconcours = con_txb_adresse.Text,
                            cpconcours = con_txb_cp.Text,
                            dateconcours = Convert.ToDateTime(con_txb_date.Text),
                            salleconcours = con_txb_salle.Text,
                            villeconcours = con_txb_ville.Text

                        };
                        //on ajoute le concours dans la table
                        monModele.CONCOURS.Add(unConcours);
                        monModele.SaveChanges(); //on sauvegarde les changements
                                                 //On affiche un message à l'utilisateur pour le prévenir
                        MessageBox.Show("Le concours a bien été ajouté.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //on nettoie le formulaire
                        clean();
                        //on regarge le dgw_Concours
                        reload();

                    }
                    catch
                    {
                        MessageBox.Show("Veuillez entrer toutes les informations.\nSi le formulaire est remplie, veuillez vérifier que la date soit bien sous forme jj/MM/aaaa", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }

        }
        #endregion

        //procédure clean() pour mettre à 0 le formulaire
        #region clean()
        public void clean() //Permet de remettre à 0 les infos
        {
            con_txb_adresse.Clear();
            con_txb_code.Clear();
            con_txb_code.Show();
            con_lbl_code.Text = "Code";
            con_lbl_code.Hide();
            con_txb_cp.Clear();
            con_txb_salle.Clear();
            con_txb_ville.Clear();
            con_txb_date.Clear();
            con_btn_ajouter.Show();
            con_btn_Suppr.Hide();
            con_btn_modifier.Hide();
        }
        #endregion

        //remplir le formulaire en sélectionnant une ligne
        #region sélection datagridview
        private void dgv_Concours_CellContentClick(object sender, DataGridViewCellEventArgs e) //Remplir le formulaire en sélectionnant
                                                                                               //la ligne
        {
            //comme le code ne doit pas être modifié, on ne laisse pas à l'utilisateur la possibilité de le supprimé
            con_txb_code.Hide();
            con_lbl_code.Show();

            //on ne peut pas ajouter ce concours car il existe déjà donc on cache le bontou ajouter
            con_btn_ajouter.Hide();

            //on affiche les boutons modifier et annuler
            con_btn_modifier.Show();
            con_btn_Suppr.Show();

            //On récupère toutes les infos du datagrid
            string code = dgv_Concours.Rows[e.RowIndex].Cells[0].Value.ToString();
            string adresse = dgv_Concours.Rows[e.RowIndex].Cells[1].Value.ToString();
            string cp = dgv_Concours.Rows[e.RowIndex].Cells[2].Value.ToString();
            string date = dgv_Concours.Rows[e.RowIndex].Cells[3].Value.ToString();
            string salle = dgv_Concours.Rows[e.RowIndex].Cells[4].Value.ToString();
            string ville = dgv_Concours.Rows[e.RowIndex].Cells[5].Value.ToString();

            //on arrange la date pour enlever le 00:00:00 à la fin
            string[] laDate = date.Split(' ');

            //On remplir le formulaire avec les infos récupérées
            con_lbl_code.Text = code.Trim();
            con_txb_adresse.Text = adresse.Trim();
            con_txb_cp.Text = cp.Trim();
            con_txb_date.Text = laDate[0];
            con_txb_salle.Text = salle.Trim();
            con_txb_ville.Text = ville.Trim();

        }
        #endregion

        //supprimer un concours
        #region bouton supprimer
        //ON DOIT SUPPRIMER LES PARTICIPANTS AU CONCOURS AVANT DE POUVOIR LE SUPPRIMER
        private void con_btn_Suppr_Click(object sender, EventArgs e) //supprimer un concours
        {
            string code = con_lbl_code.Text;
            var unC = monModele.CONCOURS.Find(code);
            //on supprime les participations à ce concours
            var req = from p in monModele.PARTICIPE
                      where p.codeconcours == code
                      select p;
            if (req != null) //on vérifie s'il y bien des participants à ce concours
            {
                foreach (PARTICIPE p in monModele.PARTICIPE)
                {
                    monModele.PARTICIPE.Remove((PARTICIPE)p);
                }
            }


            monModele.CONCOURS.Remove(unC); //on supprime le concours
            monModele.SaveChanges(); //on sauvegarde les changements
            //on affiche un message à l'utilisateur
            if (MessageBox.Show("Le concours " + code + " a bien été supprimé.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK) 
            //on nettoie le formulaire
            clean();
            //on regarde le dgv_Concours
            reload();
            
        }
        #endregion

        //modifier un concours
        #region bouton modifier
        private void con_btn_modifier_Click(object sender, EventArgs e) //Modifier un concours
        {
            try
            {
                var unC = monModele.CONCOURS.Find(con_lbl_code.Text); //on récupère le concours
                                                                      //on change les infos de la bdd par celle du formulaire
                unC.adresseconcours = con_txb_adresse.Text;
                unC.cpconcours = con_txb_cp.Text;
                unC.dateconcours = Convert.ToDateTime(con_txb_date.Text); //on convertit la date
                unC.salleconcours = con_txb_salle.Text;
                unC.villeconcours = con_txb_ville.Text;

                //on sauvegarde les modifications
                monModele.SaveChanges();

                //on affiche un message à l'utilisateur
                if (MessageBox.Show("Le concours " + con_txb_code.Text + " a bien été modifié.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)

                //on nettoie le formulaire
                clean();

                //on recharge le datagrid
                reload();

            }
            catch
            {
                MessageBox.Show("Veuillez entrer toutes les informations.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion

        //annuler la saisie + remise à 0 du formulaire
        #region bouton annuler
        private void con_btn_annuler_Click(object sender, EventArgs e)
        {
            //on remet simplement à vide le formulaire
            clean();
        }
        #endregion
    }

}
