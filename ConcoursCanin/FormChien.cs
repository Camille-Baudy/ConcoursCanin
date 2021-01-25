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
    public partial class FormChien : Form
    {
        private CONCOURSCANINEntities2 monModele;
        public FormChien()
        {
            InitializeComponent();
            monModele = new CONCOURSCANINEntities2();
        }

        //pour retourner à l'accueil
        #region bouton retour à l'accueil
        private void btn_return_Click(object sender, EventArgs e) //on ouvre le fomrAccueil et on ferme le formChien
        {
            //on ouvre le formAccueil et on ferme le formChien
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauform));
            monthread.Start();
            this.Close();
        }
        public static void ouvrirnouveauform()
        {
            Application.Run(new FormAccueil());
        }
#endregion

        //pour voir le tableau des chiens de race
        #region bouton voir RACE
        private void ch_btn_voirRace_Click(object sender, EventArgs e) //on affiche le data des chiens de race
        {
            ch_dgv_batard.Hide();
            ch_dgv_chiens.Hide();
            ch_dgv_race.Show();
        }
#endregion

        //pour voir le tableau des chiens de batard
        #region bouton voir BATARD
        private void ch_btn_voirBatard_Click(object sender, EventArgs e) //on affiche le data des chiens batard
        {
            ch_dgv_race.Hide();
            ch_dgv_chiens.Hide();
            ch_dgv_batard.Show();
        }
#endregion

        //pour voir le tebleau de tous les chiens confondus
        #region bouton voir TOUS
        private void ch_btn_voirTous_Click(object sender, EventArgs e) //on affiche le data de tous les chiens
        {
            ch_dgv_batard.Hide();
            ch_dgv_race.Hide();
            ch_dgv_chiens.Show();
        }
#endregion

        //affichement par défaut des fomulaire + chargement des datagridviews + chargement des combobox proprio
        #region FormChien_Load()
        private void FormChien_Load(object sender, EventArgs e)
        {
            //par défaut on affiche tous les chiens
            ch_dgv_batard.Hide();
            ch_dgv_race.Hide();
            ch_dgv_chiens.Show();

            //on cache le txb du code chien pour le form BATARD
            ch_BATARD_lbl_codeChien.Hide();
            ch_RACE_lbl_codeChien.Hide();

            //on cache les txb des propriétaire
            ch_BATARD_lbl_proprio.Hide();
            ch_RACE_lbl_proprio.Hide();

            //on cache les bouton modifier et supprimer
            ch_BATARD_btn_modif.Hide();
            ch_BATARD_btn_suppr.Hide();
            ch_RACE_btn_modif.Hide();
            ch_RACE_btn_suppr.Hide();

            //on charge les data
            reload();

            //on remplie les combo box des propriétaire
            ch_BATARD_cbx_proprio.Items.Clear();
            ch_RACE_cbx_proprio.Items.Clear();
            var req = from p in monModele.PROPRIETAIRE
                       select p;

            foreach (PROPRIETAIRE p in req)
            {
                string pro = p.codeproprietaire + " " + p.nomproprietaire.Trim();
                ch_BATARD_cbx_proprio.Items.Add(pro);
                ch_RACE_cbx_proprio.Items.Add(pro);
            }
        }
        #endregion

        //pour recharger les datagridviews
        #region reload()
        public void reload() //on remet à jour les data
        { 
            //pour tous les chiens
            var reqC = from c in monModele.CHIEN
                       select c;
            bdgSourceChien.DataSource = reqC.ToList();
            ch_dgv_chiens.DataSource = bdgSourceChien;

            //pour les races
            var reqR = from r in monModele.DERACE
                       select r;
            bdgSourceRace.DataSource = reqR.ToList();
            ch_dgv_race.DataSource = bdgSourceRace;

            //pour les batards
            var reqB = from b in monModele.BATARD
                       select b;
            bdgSourceBatard.DataSource = reqB.ToList();
            ch_dgv_batard.DataSource = bdgSourceBatard;
        }
#endregion

        //pour annuler la saisie et remettre à vide le formulaire des chiens de batard
        #region bouton annuler BATARD
        private void ch_BATARD_btn_annuler_Click(object sender, EventArgs e)
        {
            clean1(); //on nettoie le formulaire
        }
#endregion

        //pour mettre à vide le formulaire des chiens de batard
        #region clean1() BATARD
        public void clean1()
        {
            //on nettoie le formulaire des chiens de batard
            ch_BATARD_txb_caract.Clear();
            ch_BATARD_txb_codeChien.Clear();
            ch_BATARD_txb_nomChien.Clear();
            ch_BATARD_txb_ddn.Clear();
            ch_BATARD_cbx_proprio.Text = "";
            ch_BATARD_lbl_codeChien.Text = "Code du chien";
            ch_BATARD_lbl_codeChien.Hide();
            ch_BATARD_txb_codeChien.Show();
            ch_BATARD_lbl_proprio.Text = "Propriétaire";
            ch_BATARD_lbl_proprio.Hide();
            ch_BATARD_cbx_proprio.Show();
            //on raffiche le bouton pour ajouter
            ch_BATARD_btn_add.Show();

            //on cache les bouton modifier et supprimer
            ch_BATARD_btn_modif.Hide();
            ch_BATARD_btn_suppr.Hide();

        }
#endregion

        //pour mettre à vide le formulaire des chiens de race
        #region clean2() RACE
        public void clean2()
        {
            //on nettoie le formulaire des chiens de race
            ch_RACE_txb_robe.Clear();
            ch_RACE_txb_nom.Clear();
            ch_RACE_txb_race.Clear();
            ch_RACE_txb_codeChien.Clear();
            ch_RACE_txb_ddn.Clear();
            ch_RACE_cbx_proprio.Text = "";
            ch_RACE_lbl_codeChien.Text = "Code du chien";
            ch_RACE_lbl_codeChien.Hide();
            ch_RACE_txb_codeChien.Show();
            ch_RACE_lbl_proprio.Text = "Propriétaire";
            ch_RACE_lbl_proprio.Hide();
            ch_RACE_cbx_proprio.Show();
            //on raffiche le bouton pour ajouter
            ch_RACE_btn_add.Show();
            //on cache les bouton modifier et supprimer
            ch_RACE_btn_modif.Hide();
            ch_RACE_btn_suppr.Hide();
        }
        #endregion

        //pour remplir le formualire des chiens de batard en cliquant simplement dans le tableau
        #region sélection tableau BATARD
        private void ch_dgv_batard_CellContentClick(object sender, DataGridViewCellEventArgs e) //on rempli le formulaire pour les chiens batard
        {
            //on va faire une modification donc on ne peut pas changer le code du chien et du proprio
            ch_BATARD_txb_codeChien.Hide();
            ch_BATARD_lbl_codeChien.Show();
            ch_BATARD_lbl_proprio.Show();
            ch_BATARD_cbx_proprio.Hide();

            //on affiche les bouton modifier et supprimer
            //on cache le botuon ajouter
            ch_BATARD_btn_modif.Show();
            ch_BATARD_btn_suppr.Show();
            ch_BATARD_btn_add.Hide();

            //on cache le bouton pour ajouter
            ch_BATARD_btn_add.Hide();

            //on récupère les informations
            string codeChien = ch_dgv_batard.Rows[e.RowIndex].Cells[0].Value.ToString();
            string codeProprio = ch_dgv_batard.Rows[e.RowIndex].Cells[1].Value.ToString();
            string caract = ch_dgv_batard.Rows[e.RowIndex].Cells[2].Value.ToString();

            //on récupère le nom du propriétaire
            var req1 = from nomP in monModele.PROPRIETAIRE
                       where nomP.codeproprietaire == codeProprio
                       select nomP;

            foreach (PROPRIETAIRE value in req1)
            {
                //on remplie la combobox propriétaire
                ch_BATARD_lbl_proprio.Text = codeProprio + " " + value.nomproprietaire.Trim();
            }

            //on récupère le nom du chien
            var req2 = from nomC in monModele.CHIEN
                       where nomC.codechien == codeChien
                       select nomC;

            foreach (CHIEN value in req2)
            {
                //on remplie le formulaire
                ch_BATARD_txb_nomChien.Text = value.nomchien.Trim();
            }

            //on récupère la date de naissance du chien
            foreach (CHIEN value in req2)
            {
                //on arrange la date pour enlever le 00:00:00 à la fin
                string date = Convert.ToString(value.ddnchien);
                string[] laDate = date.Split(' ');
                //on remplie le formulaire
                ch_BATARD_txb_ddn.Text = Convert.ToString(laDate[0]);
            }

            //on remplie le formulaire
            ch_BATARD_lbl_codeChien.Text = codeChien.Trim();
            ch_BATARD_txb_caract.Text = caract.Trim();
        }
        #endregion

        //pour remplir le formualire des chiens de race en cliquant simplement dans le tableau
        #region selection tableau RACE
        private void ch_dgv_race_CellContentClick(object sender, DataGridViewCellEventArgs e) // on rempli le formulaire pour les chiens de race
        {
            //on va faire une modification donc on ne peut pas changer le code du chien et du proprio
            ch_RACE_txb_codeChien.Hide();
            ch_RACE_lbl_codeChien.Show();
            ch_RACE_lbl_proprio.Show();
            ch_RACE_cbx_proprio.Hide();

            //on affiche les bouton modifier et supprimer
            //on cache le bouton ajouter
            ch_RACE_btn_annuler.Show();
            ch_RACE_btn_suppr.Show();
            ch_RACE_btn_add.Hide();

            //on cache le bouton pour ajouter
            ch_RACE_btn_add.Hide();

            //on récupère les informations
            string code = ch_dgv_race.Rows[e.RowIndex].Cells[0].Value.ToString();
            string proprio = ch_dgv_race.Rows[e.RowIndex].Cells[1].Value.ToString();
            string race = ch_dgv_race.Rows[e.RowIndex].Cells[2].Value.ToString();
            string robe = ch_dgv_race.Rows[e.RowIndex].Cells[3].Value.ToString();

            //on récupère le nom du propriétaire
            var req1 = from nomP in monModele.PROPRIETAIRE
                       where nomP.codeproprietaire == proprio
                       select nomP;

            foreach (PROPRIETAIRE value in req1)
            {
                //on remplie la combobox propriétaire
                ch_RACE_lbl_proprio.Text = proprio + " " + value.nomproprietaire.Trim();
            }

            //on récupère le nom du chien
            var req2 = from nomC in monModele.CHIEN
                       where nomC.codechien == code
                       select nomC;

            foreach (CHIEN value in req2)
            {
                //on remplie le formulaire
                ch_RACE_txb_nom.Text = value.nomchien.Trim();
            }

            //on récupère la date de naissance du chien
            foreach (CHIEN value in req2)
            {
                //on arrange la date pour enlever le 00:00:00 à la fin
                string date = Convert.ToString(value.ddnchien);
                string[] laDate = date.Split(' ');
                //on remplie le formulaire
                ch_RACE_txb_ddn.Text = Convert.ToString(laDate[0]);
            }

            //on remplie le formulaire
            ch_RACE_lbl_codeChien.Text = code.Trim();
            ch_RACE_txb_race.Text = race.Trim();
            ch_RACE_txb_robe.Text = robe.Trim();

        }
        #endregion

        //pour annuler la saisie et remettre à vide le formulaire des chiens de race
        #region bouton annuler RACE
        private void ch_RACE_btn_annuler_Click(object sender, EventArgs e)
        {
            //on nettoie le formulaire
            clean2();
        }
        #endregion

        //pour tester si le code chien n'est pas déjà utilisé
        #region testCodeChien()
        public string testCodeChien(string code)
        {
            //si le code existe déjà alors on va récupérer le code propriétaire associé

            var reqCode = from c in monModele.CHIEN
                          where c.codechien == code
                          select c;

            string proprio = "";
            foreach (CHIEN value in reqCode)
            {
                
                proprio = value.codeproprietaire;
               
            }

            return proprio;
           
        }
        #endregion

        //ajouter un chien de batard
        #region bouton ajouter BATARD
        private void ch_BATARD_btn_add_Click(object sender, EventArgs e)
        {
            //ajouter un chien batard

            //on regarde si le formualire est rempli ou non
            if (ch_BATARD_txb_codeChien.Text == "" && ch_BATARD_txb_caract.Text == "" && ch_BATARD_txb_ddn.Text == "" && ch_BATARD_txb_nomChien.Text == "" && ch_BATARD_cbx_proprio.Text == "")
            {
                MessageBox.Show("Votre formulaire est vide !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = ch_BATARD_txb_codeChien.Text; //on récupère dans une variable le code chien


                var reqCode = from c in monModele.CHIEN
                              select c;

                //si le code est déjà donnée
                string codeDuPropriétaire = testCodeChien(code); //on récupère dans une variable le code du propriétaire associé au code chien déjà existant

                //on récupère le code du propriétaire du formualire
                string p = ch_BATARD_cbx_proprio.Text;
                string[] codeP = p.Split(' ');

                //on regarde si le code chien est libre
                var req = monModele.CHIEN.Find(code, codeDuPropriétaire);
                if (req != null)
                {
                    //on affiche un message à l'utilisateur pour prévenir que le code est déjà pris
                    MessageBox.Show("Le code " + code + " existe déjà !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //on remet à vide le texbox
                    ch_BATARD_txb_codeChien.Clear();
                }
                else
                {
                    //on vérifie si les infos sont toutes remplies
                    if (ch_BATARD_txb_codeChien.Text == "") //on regarde s'il y a un code
                    {
                        //on affiche un mesage à l'utilisateur
                        MessageBox.Show("Veuillez entrer un code au nouveau chien.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (ch_BATARD_cbx_proprio.Text == "") //on regarde s'il y a un proprio
                        {
                            //on affiche un mesage à l'utilisateur
                            MessageBox.Show("Veuillez séléctionner un propriétaire.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (ch_BATARD_txb_caract.Text == "") //on regarde s'il y a une caractéristique
                            {
                                //on affiche un mesage à l'utilisateur
                                MessageBox.Show("Veuillez entrer une caractéristique.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                if (ch_BATARD_txb_ddn.Text == "") //on regarde s'il y a une ddn
                                {
                                    //on affiche un mesage à l'utilisateur
                                    MessageBox.Show("Veuillez entrer une date de naissance sous la forme jj/MM/aaaa.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    if (ch_BATARD_txb_nomChien.Text == "") //on regarde s'il y a un nom
                                    {
                                        //on affiche un mesage à l'utilisateur
                                        MessageBox.Show("Veuillez entrer un nom au nouveau chien.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else //sinon il y a aucune erreur
                                    {
                                        var unBatard = new BATARD()
                                        {
                                            codechien = code,
                                            caracteristiques = ch_BATARD_txb_caract.Text,
                                            codeproprietaire = Convert.ToString(codeP[0])
                                        };
                                        //on ajoute le chien dans la table batard
                                        monModele.BATARD.Add(unBatard);

                                        var unChien = new CHIEN()
                                        {
                                            codechien = code,
                                            codeproprietaire = Convert.ToString(codeP[0]),
                                            ddnchien = Convert.ToDateTime(ch_BATARD_txb_ddn.Text),
                                            nomchien = ch_BATARD_txb_nomChien.Text
                                        };
                                        //on ajoute le chien dans la table chien
                                        monModele.CHIEN.Add(unChien);

                                        //on sauvegarde les changements
                                        monModele.SaveChanges();

                                        //on affiche un mesage à l'utilisateur
                                        MessageBox.Show("Le chien a bien été ajouté.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        //on nettoie le formulaire
                                        clean1();
                                        //on regarde le data
                                        reload();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            

            #region idée de base MARCHE PAS
            /*  //on récupère les infos du formulaire
              string code = ch_BATARD_txb_codeChien.Text;
              //on récupère le code du propriétaire
              string p = ch_BATARD_lbl_proprio.Text;
              string[] codeP = p.Split(' ');
              //on va regarder si le code est libre ou non
              if (testCodeChien(code) == true)
              {
                  //on affiche un message à l'utilisateur pour prévenir que le code est déjà pris
                  MessageBox.Show("Le code " + code + " existe déjà !","Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                  //on remet à vide le formulaire
                  clean1();
              }
              else
              {
                  try
                  {
                      var unBatard = new BATARD()
                      {
                          codechien = code,
                          caracteristiques = ch_BATARD_txb_caract.Text,
                          codeproprietaire = Convert.ToString(codeP[0])
                      };
                      //on ajoute le chien dans la table batard
                      monModele.BATARDs.Add(unBatard);

                      var unChien = new CHIEN()
                      {
                          codechien = code,
                          codeproprietaire = Convert.ToString(codeP[0]),
                          ddnchien = Convert.ToDateTime(ch_BATARD_txb_ddn.Text),
                          nomchien = ch_BATARD_txb_nomChien.Text
                      };
                      //on ajoute le chien dans la table chien
                      monModele.CHIENs.Add(unChien);

                      //on sauvegarde les changements
                      monModele.SaveChanges();

                      //on affiche un mesage à l'utilisateur
                      MessageBox.Show("Le chien a bien été ajouté.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                      //on nettoie le formulaire
                      clean1();
                      //on regarde le data
                      reload();
                  }
                  catch
                  {
                      MessageBox.Show("Veuillez entrer toutes les informations.\nSi le formulaire est remplie, veuillez vérifier si la date est bien sous forme jj/MM/aaaa", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  }
              } */
            #endregion
        }
        #endregion

        //ajouter un chien de race
        #region bouton ajouter RACE
        private void ch_RACE_btn_add_Click(object sender, EventArgs e) //ajouter un chien de race
        {
            //on regarde si le formualire est vide
            if (ch_RACE_txb_codeChien.Text == "" && ch_RACE_txb_race.Text == "" && ch_RACE_txb_robe.Text == "" && ch_RACE_txb_ddn.Text == "" && ch_RACE_txb_nom.Text == "" && ch_RACE_cbx_proprio.Text == "")
            {
                MessageBox.Show("Votre formulaire est vide !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string code = ch_RACE_txb_codeChien.Text; //on récupère dans une varibale le code chien

                //si le code du chien est déjà donnée
                string codeDuPropriétaire = testCodeChien(code); //on récupère dans une variable le code propriétaire associé au code de chien déjà existant

                //on récupère le code du propriétaire indiquer dans le formualire
                string p = ch_RACE_cbx_proprio.Text;
                string[] codeP = p.Split(' ');

                //on regarde si le code est libre
                var req = monModele.CHIEN.Find(code, codeDuPropriétaire);
                if (req != null)
                {
                    //on affiche un message à l'utilisateur pour prévenir que le code est déjà pris
                    MessageBox.Show("Le code " + code + " existe déjà !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //on vide le textbox du code
                    ch_RACE_txb_codeChien.Clear();

                }
                else
                {
                    //on vérifie si les infos sont toutes remplies
                    if (ch_RACE_txb_codeChien.Text == "") //on regarde s'il y a un code
                    {
                        //on affiche un mesage à l'utilisateur
                        MessageBox.Show("Veuillez entrer un code au nouveau chien.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (ch_RACE_cbx_proprio.Text == "") //on regarde q'il y a un proprio
                        {
                            //on affiche un mesage à l'utilisateur
                            MessageBox.Show("Veuillez choisire un propriétaire.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            if (ch_RACE_txb_race.Text == "")
                            {
                                //on affiche un mesage à l'utilisateur
                                MessageBox.Show("Veuillez indiquer la race du nouveau chien.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else
                            {
                                if (ch_RACE_txb_robe.Text == "")
                                {
                                    //on affiche un mesage à l'utilisateur
                                    MessageBox.Show("Veuillez entrer la robe.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                }
                                else
                                {
                                    if (ch_RACE_txb_ddn.Text == "")
                                    {
                                        //on affiche un mesage à l'utilisateur
                                        MessageBox.Show("Veuillez entrer la date de naissance sous la forme jj/MM/aaaa.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                    else
                                    {
                                        if (ch_RACE_txb_nom.Text == "")
                                        {
                                            //on affiche un mesage à l'utilisateur
                                            MessageBox.Show("Veuillez entrer le nom du nouveau chien.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        }
                                        else
                                        {
                                            var unRace = new DERACE()
                                            {
                                                codechien = code,
                                                codeproprietaire = Convert.ToString(codeP[0]),
                                                race = ch_RACE_txb_race.Text,
                                                robe = ch_RACE_txb_robe.Text

                                            };
                                            //on ajoute le chien dans la table race
                                            monModele.DERACE.Add(unRace);

                                            var unChien = new CHIEN()
                                            {
                                                codechien = code,
                                                codeproprietaire = Convert.ToString(codeP[0]),
                                                ddnchien = Convert.ToDateTime(ch_RACE_txb_ddn.Text), //NE MARCHE PAS
                                                nomchien = ch_RACE_txb_nom.Text
                                            };
                                            //on ajoute le chien dans la table chien
                                            monModele.CHIEN.Add(unChien);

                                            //on sauvegarde les changements
                                            monModele.SaveChanges();

                                            //on affiche un mesage à l'utilisateur
                                            MessageBox.Show("Le chien a bien été ajouté.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            //on nettoie le formulaire
                                            clean2();
                                            //on recharge le data
                                            reload();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            

            #region idée de base MARCHE PAS
            /* //on récupère les infos du formulaire
            string code = ch_RACE_txb_codeChien.Text;
            //on récupère le code du propriétaire
            string p = ch_RACE_cbx_proprio.Text;
            string[] codeP = p.Split(' ');

            //si toutes les infos ne sont pas indiquées
            if (ch_RACE_txb_codeChien.Text == "" || ch_RACE_cbx_proprio.Text == "" || ch_RACE_txb_race.Text == "" || ch_RACE_txb_robe.Text == "" || ch_RACE_txb_ddn.Text == "" || ch_RACE_txb_nom.Text == "")
            {
                MessageBox.Show("Veuillez entrer toutes les informations.\nSi le formulaire est remplie, veuillez vérifier si la date est bien sous forme jj/MM/aaaa", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (testCodeChien(code) == true)  //on va regarder si le code est libre ou non
                {
                    //on affiche un message à l'utilisateur pour prévenir que le code est déjà pris
                    MessageBox.Show("Le code " + code + " existe déjà !", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    //on remet à vide le formulaire
                    clean2();
                }
                else
                {
                    var unRace = new DERACE()
                    {
                        codechien = code,
                        codeproprietaire = Convert.ToString(codeP[0]),
                        race = ch_RACE_txb_race.Text,
                        robe = ch_RACE_txb_robe.Text

                    };
                    //on ajoute le chien dans la table race
                    monModele.DERACEs.Add(unRace);

                    var unChien = new CHIEN()
                    {
                        codechien = code,
                        codeproprietaire = Convert.ToString(codeP[0]),
                        ddnchien = Convert.ToDateTime(ch_RACE_txb_ddn.Text), //NE MARCHE PAS
                        nomchien = ch_RACE_txb_nom.Text
                    };
                    //on ajoute le chien dans la table chien
                    monModele.CHIENs.Add(unChien);

                    //on sauvegarde les changements
                    monModele.SaveChanges();

                    //on affiche un mesage à l'utilisateur
                    MessageBox.Show("Le chien a bien été ajouté.", "Avertissment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //on nettoie le formulaire
                    clean2();
                    //on regarde le data
                    reload();
                }

            } */
            #endregion
        }
        #endregion

        //pour modifier un chien de batard
        #region bouton modifier BATARD
        private void ch_BATARD_btn_modif_Click_1(object sender, EventArgs e) //modifier un chien batard
        {
            try
            {
                //on récupère le code du proprio
                string codeP = ch_BATARD_lbl_proprio.Text;
                string[] codePro = codeP.Split(' ');

                //on récupère les infos
                var unB = monModele.CHIEN.Find(ch_BATARD_lbl_codeChien.Text, codePro[0]);

                unB.ddnchien = Convert.ToDateTime(ch_BATARD_txb_ddn.Text);
                unB.nomchien = ch_BATARD_txb_nomChien.Text;

                var unBbis = monModele.BATARD.Find(ch_BATARD_lbl_codeChien.Text, codePro[0]);

                unBbis.caracteristiques = ch_BATARD_txb_caract.Text;

                //on sauvegarde les modifications
                monModele.SaveChanges();

                //on affiche un message à l'utilisateur
                MessageBox.Show("Le chien " + ch_BATARD_lbl_codeChien.Text + " a bie été modifié.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //on recharge les datagrid
                reload();

                //on nettoie le formulaire
                clean1();
            }
            catch
            {
                MessageBox.Show("Veuillez entrer toutes les informations.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        //pour modifier un chien de race
        #region bouton modifier RACE
        private void ch_RACE_btn_modif_Click(object sender, EventArgs e) //ajouter un chien de race
        {
            try
            {
                //on récupère le code du proprio
                string codeP = ch_RACE_lbl_proprio.Text;
                string[] codePro = codeP.Split(' ');

                //on récupère les infos
                var unR = monModele.CHIEN.Find(ch_RACE_lbl_codeChien.Text, codePro[0]);

                unR.ddnchien = Convert.ToDateTime(ch_RACE_txb_ddn.Text);
                unR.nomchien = ch_RACE_txb_nom.Text;

                var unRbis = monModele.DERACE.Find(ch_RACE_lbl_codeChien.Text, codePro[0]);

                unRbis.robe = ch_RACE_txb_robe.Text;
                unRbis.race = ch_RACE_txb_race.Text;

                //on sauvegarde les modifications
                monModele.SaveChanges();

                //on affiche un message à l'utilisateur
                MessageBox.Show("Le chien " + ch_RACE_lbl_codeChien.Text + " a bie été modifié.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //on recharge les datagrid
                reload();

                //on nettoie le formulaire
                clean2();
            }
            catch
            {
                MessageBox.Show("Veuillez entrer toutes les informations.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        //pour supprimer un chien de batard
        #region bouton supprimer BATARD
        private void ch_BATARD_btn_suppr_Click(object sender, EventArgs e) //supprimer un chien batard
        {
            //on récupère le code du chien
            string code = ch_BATARD_lbl_codeChien.Text;
            //on récupère le code du proprio
            string codeP = ch_BATARD_lbl_proprio.Text;
            string[] codePro = codeP.Split(' ');

            //on récupère les infos
            var unB = monModele.BATARD.Find(ch_BATARD_lbl_codeChien.Text, codePro[0]);

            //on supprime d'abord dans la table batard
            monModele.BATARD.Remove(unB);

            //on sauvegarde
            monModele.SaveChanges();

            //on récupère les infos
            var unC = monModele.CHIEN.Find(ch_BATARD_lbl_codeChien.Text, codePro[0]);

            //on supprime dans la table chiens
            monModele.CHIEN.Remove(unC);

            //on sauvegarde
            monModele.SaveChanges();

            //on affiche un messsage à l'utilisateur
            MessageBox.Show("Le chien " + code + " a bien été supprimé.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //on nettoie le formulaire
            clean1();

            //on met à jour les data
            reload();

        }
        #endregion

        //pour supprimer un chien de race
        #region bouton supprimer RACE
        private void ch_RACE_btn_suppr_Click(object sender, EventArgs e) //supprimer un chien de race
        {
            //on récupère le code du chien
            string code = ch_RACE_lbl_codeChien.Text;
            //on récupère le code du proprio
            string codeP = ch_RACE_lbl_proprio.Text;
            string[] codePro = codeP.Split(' ');

            //on récupère les infos
            var unR = monModele.DERACE.Find(ch_RACE_lbl_codeChien.Text, codePro[0]);

            //on supprime d'abord dans la table batard
            monModele.DERACE.Remove(unR);

            //on sauvegarde
            monModele.SaveChanges();

            //on récupère les infos
            var unC = monModele.CHIEN.Find(ch_RACE_lbl_codeChien.Text, codePro[0]);

            //on supprime dans la table chiens
            monModele.CHIEN.Remove(unC);

            //on sauvegarde
            monModele.SaveChanges();

            //on affiche un messsage à l'utilisateur
            MessageBox.Show("Le chien " + code + " a bien été supprimé.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //on nettoie le formulaire
            clean2();

            //on met à jour les data
            reload();
        }
        #endregion
    }
}
