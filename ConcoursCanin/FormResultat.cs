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
    public partial class FormResultat : Form
    {
        private CONCOURSCANINEntities2 monModele;
        public FormResultat()
        {
            InitializeComponent();
            monModele = new CONCOURSCANINEntities2();
        }

        //retourner à l'accueil
        #region bouton retour
        private void btn_return_Click(object sender, EventArgs e) //retourner à l'accueil
        {
            //on ouvre le formAccueil et on ferme le formResultat
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform));
            monthread.Start();
            this.Close();
        }
        public static void ouvrirnouveauform()
        {
            Application.Run(new FormAccueil());
        }
        #endregion

        //chargement des combobox code concours & propriétaire
        #region FormResultat_Load
        private void FormResultat_Load(object sender, EventArgs e)
        {
            //on remplie la combobox avec les codes concours
            res_cbx_concours.Items.Clear();
            var req = from c in monModele.CONCOURS
                      select c.codeconcours;
            foreach (string c in req)
            {
                res_cbx_concours.Items.Add(c);
            }

            //on remplie la cbx proprietaire
            res_cbx_proprietaire.Items.Clear();
            var req2 = from p in monModele.PROPRIETAIRE
                       select p;
          
            foreach (PROPRIETAIRE p in req2)
            {
                string pro = p.codeproprietaire + " " + p.nomproprietaire;
                res_cbx_proprietaire.Items.Add(pro);
            }

            //on cache le textbox qui permet de stocke le code proprio pour avoir sa liste de chien
            res_txb_pCode.Hide();
            //on cache le label proprio et chien qu'on affichera que lors de la modification
            res_lbl_proprio.Hide();
            res_lbl_chien.Hide();
            //on cache le bouton modifier
            res_btn_modif.Hide();
            
        }
        #endregion

        //procédure reload() pour charger le datagrid
        #region relaod()
        public void relaod() //pour charger le datagrid en fonction du code choisi
        {
            var req = from p in monModele.PARTICIPE
                      where p.CONCOURS.codeconcours == res_cbx_concours.Text
                      select p;
            bdgSourceParticiper.DataSource = req.ToList();
            dgv_participer.DataSource = bdgSourceParticiper;
        }
        #endregion

        //voir la liste des résultats en fonction du code concours choisi
        #region bouton voir
        private void res_btn_voir_Click(object sender, EventArgs e) //afficher le datagrid
        {
            if(res_cbx_concours.Text == "")
            {
                MessageBox.Show("Veuillez choisir un concours.", "Avertissement");
            }
            else
            {
                relaod();
            }
        }
        #endregion

        //procédure clean() pour mettre à 0 le formulaire
        #region clean()
        public void clean() //on remet à vie le formulaire
        {
            res_cbx_proprietaire.Text = "";
            res_cbx_chien.Text = "";
            res_txb_note.Clear();
            //on affiche la combobox proprio et chien
            res_cbx_proprietaire.Show();
            res_cbx_chien.Show();
            //on cache le libelle proprio et chien
            res_lbl_chien.Text = "Chien";
            res_lbl_proprio.Text = "Propriétaire";
            res_lbl_proprio.Hide();
            res_lbl_chien.Hide();
            //on raffiche le bouton pour voir les chiens car la modification est terminée
            res_btn_voirChien.Show();
            //on cache le bouton modifier
            res_btn_modif.Hide();
            //on raffiche le bouton valider
            res_btn_valider.Show();
        }
        #endregion

        //valider/ajouter un résultat
        #region bouton valider
        private void res_btn_valider_Click(object sender, EventArgs e)
        {
            //on regarde si le formualire n'est pas vide
            if (res_cbx_proprietaire.Text == "" && res_cbx_chien.Text == "" && res_txb_note.Text == "")
            {
                if (MessageBox.Show("Votre formualire est vide !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                    clean();

            }
            else
            {
                //récupérer seulement le code chien
                string codeChien = res_cbx_chien.Text;
                string[] cChien = codeChien.Split(' ');
                //on recherche dans la bdd si le résultat existe déjà
                var req = monModele.PARTICIPE.Find(res_txb_pCode.Text, Convert.ToString(cChien[1]), res_cbx_concours.Text);
                if (req != null) //si le chien a déjà été noté pour ce concours
                {
                    //On prévient l'utilisateur
                    if (MessageBox.Show("Le chien " + Convert.ToString(cChien[0]) + " a déjà participé au concours ! \nIl ne peut pas participé deux fois !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop) == DialogResult.OK)
                        //on remet à vide le formulaire
                        clean();
                }
                else //si le chien n'a pas été noté pour ce concours
                {
                    try
                    {
                        //récupérer que le code chien
                        string code = res_cbx_chien.Text;
                        string[] c = code.Split(' ');

                        //récupérer que le code propriétaire
                        string codeP = res_cbx_proprietaire.Text;
                        string[] p = codeP.Split(' ');

                        //on vérifie que la note soit entre 0 et 10
                        if (0 <= Convert.ToInt16(res_txb_note.Text) && Convert.ToInt16(res_txb_note.Text) <= 10)
                        {
                            var unParticipant = new PARTICIPE()
                            {
                                codechien = Convert.ToString(c[1]),
                                codeproprietaire = Convert.ToString(p[0]),
                                codeconcours = res_cbx_concours.Text,
                                note = Convert.ToInt16(res_txb_note.Text)
                            };
                            //on l'ajoute à la table
                            monModele.PARTICIPE.Add(unParticipant);
                            //on sauvegarde
                            monModele.SaveChanges();
                            //on affiche un message à l'utilisateur
                            MessageBox.Show("La note a bien été attribuée." +
                                "\n\nLe chien " + Convert.ToString(cChien[0]) + " du propriétaire " + res_txb_pCode.Text + " a eu comme résultat : " + res_txb_note.Text + "/10", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //on nettoie le formulaire
                            clean();
                            //on rafraichit le datagrid
                            relaod();
                        }
                        else
                        {
                            MessageBox.Show("La note doit être comprise entre 0 et 10 !", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }


                    }
                    catch
                    {
                        MessageBox.Show("Veuillez entrer toutes les informations." +
                            "\n\nSi ce message d'erreur perssiste, veuillez retourner à l'accueil et recommencer votre saisie.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            
            
        }
        #endregion

        //annuler la saisie en mettant à 0 le formulaire
        #region bouton annuler
        private void res_btn_annuler_Click(object sender, EventArgs e)
        {
            //on remet à vide le formulaire
            clean();
        }
        #endregion

        //bouton voir la liste des chiens en fonctio du code propriétaire choisi
        #region bouton voirChien
        private void res_btn_voirChien_Click(object sender, EventArgs e) //pour voir la liste des chiens correspondant au propriétaire
        {
            //on stocke le code propriétaire dans le textbox caché
            //récupérer que le code propriétaire
            string codeP = res_cbx_proprietaire.Text;
            string[] pr = codeP.Split(' ');
            res_txb_pCode.Text = pr[0];

            //on remplie la cbx chien
            res_cbx_chien.Items.Clear();
            var req3 = from ch in monModele.CHIEN
                       where ch.codeproprietaire == res_txb_pCode.Text
                       select ch;
            foreach (CHIEN ch in req3)
            {
                string chien = ch.nomchien.Trim();
                string chi = chien + " " + ch.codechien;
                res_cbx_chien.Items.Add(chi);
            }
        }
        #endregion

        //remplir le formualrie en sélectionnant une ligne du datagridview
        #region sélectionner une ligne du datagridview
        private void dgv_participer_CellContentClick(object sender, DataGridViewCellEventArgs e)
            //remplire le formulaire en séléctionnant la ligne
        {
            //comme on va faire une modification, on part du principe que l'erreur vient la note
            res_cbx_proprietaire.Hide();
            res_lbl_proprio.Show();
            res_cbx_chien.Hide();
            res_lbl_chien.Show();

            //on cache le bouton pour voir la liste des chiens car elle ne sert à rien
            res_btn_voirChien.Hide();
            //on cache le bouton valider et on affiche le bouton modifier
            res_btn_valider.Hide();
            res_btn_modif.Show();

            //on récupère les infos du datagrid
            string codeProprio = dgv_participer.Rows[e.RowIndex].Cells[0].Value.ToString();
            string codeChien = dgv_participer.Rows[e.RowIndex].Cells[1].Value.ToString();
            string note = dgv_participer.Rows[e.RowIndex].Cells[2].Value.ToString();

            //on récupère le nom du proprio
            var req1 = from nomP in monModele.PROPRIETAIRE
                       where nomP.codeproprietaire == codeProprio
                       select nomP;

            foreach (PROPRIETAIRE value in req1)
            {
                //pour que la combo box des chien corresponde au proprio
                //on remplie la combobox propriétaire
                res_cbx_proprietaire.Text = codeProprio + " " + value.nomproprietaire.Trim();

                //on remplie le formulaire
                res_lbl_proprio.Text = codeProprio + " " + value.nomproprietaire.Trim();

            }

            //on recupère le nom du chien
            var req2 = from nomC in monModele.CHIEN
                       where nomC.codechien == codeChien
                       select nomC;

            foreach (CHIEN value in req2)
            {
                //on remplie le formulaire
                res_lbl_chien.Text = value.nomchien.Trim() + " " + codeChien;
            }

            //on remplie le formulaire
            res_txb_note.Text = note;
            res_txb_pCode.Text = codeProprio;
                       
        }
        #endregion

        //modifier la note 
        #region bouton modifier
        private void res_btn_modif_Click(object sender, EventArgs e)
        {
            //on modifie le résultat

            try
            {
                //récupérer que le code chien
                string codeChien = res_lbl_chien.Text;
                string[] cChien = codeChien.Split(' ');
                //on récupère le resultat dans la bdd
                var unR = monModele.PARTICIPE.Find(res_txb_pCode.Text, Convert.ToString(cChien[1]), res_cbx_concours.Text);

                //on modifie la note
                unR.note = Convert.ToInt16(res_txb_note.Text);

                //on sauvegarde les modifiications
                monModele.SaveChanges();

                //on affiche un message à l'utilisateur
                if (MessageBox.Show("Le résultat a bien été modifié." +
                    "\n\nLe chien " + Convert.ToString(cChien[0]) + " du propriétaire " + res_txb_pCode.Text + " a eu comme résultat : " + res_txb_note.Text + "/10", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)

                    //on nettoie le formulaire
                    clean();

                //on recharge le datagrid
                relaod();
            }
            catch
            {
                MessageBox.Show("Veuillez entrer toutes les informations.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
