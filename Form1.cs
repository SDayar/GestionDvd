using MySql.Data.MySqlClient;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gestionDvd
{
    
    public partial class Form1 : Form
    {
        public string chemin;
        public int numero;
       

        public Form1()
        {

            InitializeComponent();
            //Remplissage de la boite de listdvd, cmbogenre, et cmboActeurs//
            string connectionString = null;
            connectionString = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";

            ConnexionSql lstedvd = new ConnexionSql(connectionString);
            ConnexionSql lstecbogenre = new ConnexionSql(connectionString);
            ConnexionSql lstecboacteurs = new ConnexionSql(connectionString);
            lstedvd.reqSelect("select TITRE,NUMDVD from dvd");
            lstecbogenre.reqSelect("Select LIBELLE from genre ");
            lstecboacteurs.reqSelect("Select NOM from acteur");

            while (!lstedvd.fin())
            {
                this.lstDvd.Items.Add((lstedvd.champ("TITRE")).ToString());
                lstedvd.suivant();
                //Fin de l'ajout//
            }
            lstedvd.fin();
            while (!lstecbogenre.fin())
            {
                //Ajout des genres dans le combogenre//
                this.cboGenre.Items.Add((lstecbogenre.champ("LIBELLE")).ToString());
                lstecbogenre.suivant();
            }
            lstecbogenre.fin();

            while (!lstecboacteurs.fin())
            {
                //Ajout des acteures dans le comboacteurs//
                this.cboActeur.Items.Add((lstecboacteurs.champ("NOM")).ToString());
                lstecboacteurs.suivant();
            }
            lstecboacteurs.fin();

           


            //Ajout des éléments dans le lstdvdv//                    

            //Fin de l'ajout des genres//

            //Fin de l'ajout des acteurs//

            //Selection du premier dvd s'il y'en a //
            if (lstDvd.Items.Count != 0)
            {
                lstDvd.SelectedIndex = 0; 
                lstDvd.Focus();

            }
                
           
            //Remplissage des phootos des films//
            chemin = "C:\\Users\\sdaya\\OneDrive\\Documents\\Projet C#\\gestionDvd\\images";


            //Fin du remplissage dès le chargement du logiciel //


        }
     





        private void Form1_Load(object sender, EventArgs e)
        {





        }



       

        private void txtTitre_TextChanged(object sender, EventArgs e)
        {

        }


        //Selection et affichage des caractéristiques d'un film//
        private void lstDvd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDvd.SelectedItem != null)
            {
                


                string connectionString = null;
                connectionString = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";
                string dvd = (lstDvd.SelectedItem.ToString());
                string copie = dvd;
                ConnexionSql detail = new ConnexionSql(connectionString);
                ConnexionSql detail_duree = new ConnexionSql(connectionString);
                ConnexionSql numdvd_dvd = new ConnexionSql(connectionString);
                ConnexionSql info_genre = new ConnexionSql(connectionString);
                ConnexionSql liste_acteurs = new ConnexionSql(connectionString);
                ConnexionSql dvd_numro = new ConnexionSql(connectionString);
                ConnexionSql image_dvd = new ConnexionSql(connectionString);
                ConnexionSql descr_dvd = new ConnexionSql(connectionString);


               
                

               
                

                
                //Afichage du titre du film//
                txtTitre.Text = (lstDvd.SelectedItem).ToString();
                //Afichage de la durée du film//

                detail.reqSelect("select AVIS from dvd where TITRE =\'" + dvd + "\'");
                
                detail_duree.reqSelect(" select DUREE from dvd where TITRE=\'" + dvd+"\'");
                detail_duree.champ("DUREE").ToString();
                numdvd_dvd.reqSelect("select dvd.NUMDVD from dvd where TITRE=\'"+dvd+"\'");
                descr_dvd.reqSelect("select DESCRIPTION from dvd where TITRE=\'"+dvd+"\'");
                txtDurée.Text = (detail_duree.champ("DUREE").ToString());
                //Affichage des avis du fils || séries
                if (detail.champ("AVIS").ToString() != "")
                {
                    lblavis.Text = (detail.champ("AVIS").ToString());

                }
                else
                {
                    lblavis.Text = " Avis disponnible prochainement !";
                }
                detail.fin();

                //Afichage de la description du film//
                if (descr_dvd.champ("DESCRIPTION").ToString() != "")
                {
                    txtDesc.Text = (descr_dvd.champ("DESCRIPTION").ToString());
                }
                else
                {
                    txtDesc.Text = " Description non disponnible ! Veuillez réessayez ultérieurement !";

                }
                descr_dvd.fin();
                
               
                //Afichage du genre du film//
                info_genre.reqSelect("select LIBELLE from genre join dvd on genre.NUMGENRE = dvd.NUMGENRE where dvd.NUMDVD =" + int.Parse((numdvd_dvd.champ("NUMDVD").ToString())) + "");
                cboGenre.Text = (info_genre.champ("LIBELLE").ToString());
                info_genre.fin();


                //Affichage de la liste des acteurs//
                liste_acteurs.reqSelect("select NOM from acteur join acteur_dvd on acteur_dvd.NUMACTEUR = acteur.NUMACTEUR where acteur.NUMACTEUR =acteur_dvd.NUMACTEUR and acteur_dvd.NUMDVD=" + int.Parse(numdvd_dvd.champ("NUMDVD").ToString()));
                lstActeur.Items.Clear();
                while (!liste_acteurs.fin())
                {


                    this.lstActeur.Items.Add((liste_acteurs.champ("NOM")).ToString());
                    // this.lstActeur.Items.Add((dvd_numro.champ("TITRE")).ToString());
                    liste_acteurs.suivant();
                }
                liste_acteurs.fin();
                numdvd_dvd.fin();
                //Récupération des images du dvd//
                image_dvd.reqSelect("select IMAGE from dvd where TITRE=\'" + lstDvd.SelectedItem.ToString() + "\'");
                if (image_dvd.champ("IMAGE").ToString() == "")
                {
                    photo.Image = null;

                }
                else
                {
                    string fichier_dvd = "C:\\Users\\sdaya\\OneDrive\\Documents\\Projet C#\\gestionDvd\\images\\dvd" + "\\" + image_dvd.champ("IMAGE").ToString();

                    photo.Image = Image.FromFile(fichier_dvd);
                    image_dvd.fin();

                }
            }
            photoact.Image = null;
            Acteur.Text = "";
        }
        //remplissage des images acteurs/

        private void lstActeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";
            ConnexionSql image_act = new ConnexionSql(connectionString);
           

            if (lstActeur.SelectedItem != null)
            {
                
                string acteur = lstActeur.SelectedItem.ToString();
                image_act.reqSelect("select IMAGE,NOM from acteur where NOM=\'" + acteur + "\'");
                if (image_act.champ("IMAGE").ToString() == "")
                {
                    photoact.Image = null;
                    Acteur.Text =image_act.champ("NOM").ToString() + ": Photo indisponnible";
                }
                else
                {
                    string fichier_acteur = "C:\\Users\\sdaya\\OneDrive\\Documents\\Projet C#\\gestionDvd\\images\\Acteur(rice)" + "\\" + image_act.champ("IMAGE").ToString();
                    photoact.Image = Image.FromFile(fichier_acteur);
                    Acteur.Text = image_act.champ("NOM").ToString();
                    image_act.fin();

                }
               
                 

            }
           


        }
        //Fin du remplissage des photos des acteurs//


        private void cboGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Ajout d'un genre// 
        private void btnAjoutgenre_Click(object sender, EventArgs e)
        {
            int longcombo = 0;
            Boolean valid = false;

            if (txtAjtGenre.Text != "")
            {

                string connectionString = null;
                connectionString = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";
                ConnexionSql ajtgenre = new ConnexionSql(connectionString);
                ConnexionSql info_genre = new ConnexionSql(connectionString);
                info_genre.reqSelect("select LIBELLE from genre");

                while (longcombo < cboGenre.Items.Count)
                {

                    if (txtAjtGenre.Text != (cboGenre.Items[longcombo]).ToString())
                    {
                        valid = true;

                    }
                    else
                    {
                        valid = false;
                        break;

                    }

                    longcombo = longcombo + 1;
                }

                if (valid == true)
                {

                    ajtgenre.reqUpdate("insert into genre(LIBELLE) values(\'" + txtAjtGenre.Text + "\')");
                    cboGenre.Items.Add(txtAjtGenre.Text);
                    MessageBox.Show("Genre ajouté !");
                    txtAjtGenre.Clear();
                    ajtgenre.fin();
                    info_genre.fin();
                }
                else
                {
                    MessageBox.Show("le genre existe déjà !");
                    txtAjtGenre.Clear();
                }
                valid = false;



            }
            else
            {
                MessageBox.Show("Remplissez le champ ci-contre !");
            }

        }
        //Fin de l'ajout d'un genre//
        //Suppression d'un genre selctionné//
        private void btnSupprGenre_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";
            ConnexionSql genre_numgenre = new ConnexionSql(connectionString);
            ConnexionSql suppgenre = new ConnexionSql(connectionString);
            ConnexionSql dvd_numgenre = new ConnexionSql(connectionString);
            ConnexionSql compteur = new ConnexionSql(connectionString);
            string genreselec = (cboGenre.SelectedItem).ToString();
            int compt = 0;
            dvd_numgenre.reqSelect("select dvd.NUMGENRE, count(NUMDVD) as compteur from dvd");
            genre_numgenre.reqSelect("select genre.NUMGENRE from genre where LIBELLE=\'" + genreselec + "\'");
            /*Nombre d'éléments dans dvd */
            compt = int.Parse((dvd_numgenre.champ("compteur").ToString()));

            int dvdval;
            int genreval;
            /*Booléen qui décide si l'élément est supprimable ou non*/
            Boolean supprimable = false;



            // numgenre.reqSelect(" select genre.NUMGENRE from genre where genre.LIBELLE ='" + genreselec + "'");
            // imb.reqUpdate(" update dvd set dvd.NUMGENRE = null where dvd.NUMGENRE="+(numgenre.champ("NUMGENRE")).ToString()+"");


            //récupération des valeurs numgenre //
            /*dvdnumgenre*/
            dvdval = int.Parse((dvd_numgenre.champ("NUMGENRE")).ToString());
            /**genrenumgenre*/
            genreval = (int.Parse((genre_numgenre.champ("NUMGENRE")).ToString()));
            /*initialisation de dvdnumgenre à -1*/
            dvdval = dvdval - 1;
            /*compteur de la boucle*/
            int tamp = 0;
            while (compt >= tamp)
            {

                if (dvdval == genreval)
                {
                    //L'élément n'est pas supprimable car il est lié à un dvd//
                    supprimable = false;
                    break;

                }
                else
                {
                    //L'élément est supprimable car il n'est lié à aucun dvd//
                    supprimable = true;


                }
                dvdval = dvdval + 1;

                tamp = tamp + 1;

                /* Ligne de débogage : bool essaie = ((genre_numgenre.champ("NUMGENRE")).ToString() == (dvd_numgenre.champ("NUMGENRE")).ToString());
                 MessageBox.Show(" dvdgenre = " + dvdval + " genrenumgenre = " + genreval + " bool =" +essaie.ToString() + " iter = " +tamp);*/

            }


            //L'élément est supprimable //
            if (supprimable == true)
            {
                suppgenre.reqUpdate("delete from genre where LIBELLE =\'" + genreselec + "\'");
                int index_genre = cboGenre.Items.IndexOf(genreselec);
                cboGenre.Items.RemoveAt(index_genre);
                cboGenre.Text = "";
                MessageBox.Show(" Le genre a été supprimé avec succès !");
                suppgenre.fin();
                dvd_numgenre.fin();
                genre_numgenre.fin();
            }
            //l'élément n'est pas supprimable//
            else
            {
                MessageBox.Show(" Le genre est lié à un dvd. Il ne peut pas être supprimé !");
            }
        }
        //Fin de la suppression d'un genre//

        //Ajout d'un acteur// 
        private void button3_Click(object sender, EventArgs e)
        {
            int longcombo = 0;
            Boolean valid = false;

            if (txtActeur.Text != "")
            {

                string connectionString = null;
                connectionString = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";
                ConnexionSql ajtacteur = new ConnexionSql(connectionString);
                ConnexionSql info_acteur = new ConnexionSql(connectionString);
                info_acteur.reqSelect("select NOM from acteur");

                while (longcombo < cboActeur.Items.Count)
                {

                    if (txtActeur.Text != (cboActeur.Items[longcombo]).ToString())
                    {
                        valid = true;

                    }
                    else
                    {
                        valid = false;
                        break;

                    }

                    longcombo = longcombo + 1;
                }

                if (valid == true)
                {

                    ajtacteur.reqUpdate("insert into acteur(NOM) values(\'" + txtActeur.Text + "\')");
                    cboActeur.Items.Add(txtActeur.Text);
                    MessageBox.Show(" Acteur / actrice ajout(e)!");
                    txtActeur.Clear();
                    ajtacteur.fin();
                    info_acteur.fin();
                }
                else
                {
                    MessageBox.Show("L'acteur / actrice existe déjà !");
                    txtActeur.Clear();
                }
                valid = false;



            }
            else
            {
                MessageBox.Show("Remplissez le champ ci-contre !");
            }


        }
        //Fin de l'ajout d'un acteur//

        //Supression d'un acteur// 
        private void btnSupprActeur_Click(object sender, EventArgs e)
        {

            string connectionString = null;
            connectionString = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";
            ConnexionSql acteur_numacteur = new ConnexionSql(connectionString);
            ConnexionSql suppacteur = new ConnexionSql(connectionString);
            ConnexionSql dvd_numacteur = new ConnexionSql(connectionString);
            ConnexionSql compteur = new ConnexionSql(connectionString);
            //Contrôle de la séléction d'un(e) acteur /actrice//
            if (cboActeur.Text != "")
            {
                string acteurselec = (cboActeur.SelectedItem).ToString();
                int compt = 0;
                dvd_numacteur.reqSelect("select acteur_dvd.NUMACTEUR, count(NUMDVD) as compteur from acteur_dvd");
                acteur_numacteur.reqSelect("select acteur.NUMACTEUR from acteur where NOM=\'" + acteurselec + "\'");
                /*Nombre d'éléments dans dvd */
                compt = int.Parse((dvd_numacteur.champ("compteur").ToString()));

                int dvdval;
                int acteurval;
                /*Booléen qui décide si l'élément est supprimable ou non*/
                Boolean supprimable = false;



                // numgenre.reqSelect(" select genre.NUMGENRE from genre where genre.LIBELLE ='" + genreselec + "'");
                // imb.reqUpdate(" update dvd set dvd.NUMGENRE = null where dvd.NUMGENRE="+(numgenre.champ("NUMGENRE")).ToString()+"");


                //récupération des valeurs numgenre //
                /*dvdnumgenre*/
                dvdval = int.Parse((dvd_numacteur.champ("NUMACTEUR")).ToString());
                /**genrenumgenre*/
                acteurval = (int.Parse((acteur_numacteur.champ("NUMACTEUR")).ToString()));
                /*initialisation de dvdnumgenre à -1*/
                dvdval = dvdval - 2;
                /*compteur de la boucle*/
                int tamp = 0;
                compt = compt - 1;
                while (compt >= tamp)
                {

                    if (dvdval == acteurval)
                    {
                        //L'acteur ou actrice n'est pas supprimable car il/elle est joue dans un dvd//
                        supprimable = false;
                        break;

                    }
                    else
                    {
                        //L'acteur ou actrice est supprimable car il/elle ne joue pas dans aucun dvd//
                        supprimable = true;


                    }
                    dvdval = dvdval + 1;

                    tamp = tamp + 1;

                    /*/Ligne de débogage  bool essaie = dvdval== acteurval;
                     MessageBox.Show(" dvdacteur = " + dvdval + " acteurnumacteur = " + acteurval + " bool =" +essaie.ToString() + " iter = " +tamp + " supprimable " + supprimable + " compteur = "+ compt);*/

                }


                //L'acteur ou actrice est supprimable //
                if (supprimable == true)
                {
                    suppacteur.reqUpdate("delete from acteur where NOM='" + acteurselec + "'");
                    int index_acteur = cboActeur.Items.IndexOf(acteurselec);
                    cboActeur.Items.RemoveAt(index_acteur);
                    cboActeur.Text = "";
                    MessageBox.Show(" L'acteur / actrice a été supprimé(e) avec succès !");
                    suppacteur.fin();
                    dvd_numacteur.fin();
                    acteur_numacteur.fin();
                }
                //l'acteur ou actrice n'est pas supprimable//
                else
                {
                    MessageBox.Show(" L'acteur ou actrice joue dans un dvd. Il ou Elle ne peut pas être supprimé(e) !");
                }
            }
            else
            {
                MessageBox.Show(" Veuillez selectionner un(e) acteur/actrice !");
            }
        }
        //Fin de la suppression d'un(e) acteur (actrice)//


        //Ajout d'un dvd//
        private void btnAjoutDvd_Click(object sender, EventArgs e)
        {
            
            string connectionString = null;
            connectionString = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";
            ConnexionSql ajtdvd = new ConnexionSql(connectionString);
            ConnexionSql numgenre = new ConnexionSql(connectionString);
            ConnexionSql detail = new ConnexionSql(connectionString);
            Boolean ajoutable = false;
            if (lstDvd.SelectedItem != null)
            {

                if (txtTitre.Text != "" && txtDurée.Text != "" && cboGenre.SelectedItem != null && txtDesc.Text!="")
                {
                    //recupération de numgenre//
                    numgenre.reqSelect("select genre.NUMGENRE from genre where LIBELLE=\'" + cboGenre.Text + "\'");
                    for (int i = 0; i < lstDvd.Items.Count; i++)
                    {
                        if (txtTitre.Text != (lstDvd.Items[i].ToString()))
                        {
                            ajoutable = true;
                        }
                        else
                        {
                            ajoutable = false;
                            break;
                        }
                    }
                    if (ajoutable == true)
                    {


                        ajtdvd.reqUpdate("insert into dvd(NUMGENRE,TITRE,DUREE,DESCRIPTION,AVIS) values('" + int.Parse(numgenre.champ("NUMGENRE").ToString()) + "',   \' " + txtTitre.Text.Replace("'", "\"") + "\'" + " ,\'" + txtDurée.Text + "\', \'" + txtDesc.Text.Replace("'", "\"") + "\', \'" + "" + "\' )");
                        ajtdvd.fin();
                       MessageBox.Show(" Le DVD est ajouté sans aucun acteur(s) / actrice(s)");
                        UseWaitCursor = true;
                       Application.Restart();



                        

                       
                       





                    }
                    else
                    {
                        MessageBox.Show(" Le DVD existe déjà");

                    }

                }
                else
                {
                    MessageBox.Show(" Veillez à remplir tous les champs avant d'ajouter un DVD !");
                }
            }
        }
        //Ajout d'un acteur à un dvd //
        private void btnAjoutActeurDvd_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            connectionString = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";
            ConnexionSql acteur_numacteur = new ConnexionSql(connectionString);
            ConnexionSql acteur_dvd = new ConnexionSql(connectionString);
            ConnexionSql dvd_numdvd = new ConnexionSql(connectionString);
           

            //Contrôle qu'un(e) acteur ou actrice est bien selectionné(e)//
            if (cboActeur.Text != "")
            {
                //récupération du titre selectionné// 
                string dvd = lstDvd.SelectedItem.ToString();
                string acteurselec = (cboActeur.SelectedItem).ToString();
                int compt = 0;
                Boolean present = false;
                //récupération de numacteur//
                acteur_numacteur.reqSelect("select acteur.NUMACTEUR from acteur where NOM=\'" + acteurselec + "\'");
                //récupération de  numdvd//
                dvd_numdvd.reqSelect("select dvd.NUMDVD from dvd where TITRE =\'" + dvd + "\'");

                //Contrôle que l'acteur/actrice est déjà dans la liste des acteurs//



                /*compteur de la boucle*/


                while (lstActeur.Items.Count > compt)
                {

                    if (acteurselec == (lstActeur.Items[compt]).ToString())
                    {
                        //L'acteur ou actrice ne peut pas être ajouté(e) car il/elle est joue dans un dvd//
                        present = true;
                        break;

                    }
                    else
                    {
                        //L'acteur ou actrice peu être ajouté car il/elle ne joue pas dans le dvd//
                        present = false;


                    }
                    compt = compt + 1;

                    /*/Ligne de débogage  bool essaie = dvdval== acteurval;
                        MessageBox.Show(" dvdacteur = " + dvdval + " acteurnumacteur = " + acteurval + " bool =" +essaie.ToString() + " iter = " +tamp + " supprimable " + supprimable + " compteur = "+ compt);*/

                }

                if (present == true)
                {
                    MessageBox.Show("L'acteur/actrice est déjà présent(e) dans la liste des acteurs(actrices) du dvd suivant :" + dvd);
                }
                else
                {
                    //Enregistrement de l'acteur(actrice) //
                    acteur_dvd.reqUpdate("insert into acteur_dvd(NUMACTEUR,NUMDVD) values(\'" + int.Parse((acteur_numacteur.champ("NUMACTEUR")).ToString()) + "\', \'" + int.Parse((dvd_numdvd.champ("NUMDVD")).ToString()) + "\' )");
                    lstActeur.Items.Add(acteurselec);

                    acteur_dvd.fin();
                    acteur_numacteur.fin();
                    dvd_numdvd.fin();


                }


            }
            //Cas où l'acteur/actrice n'est pas sélectionné(e)//
            else
            {
                MessageBox.Show(" Veuillez Selectionner un acteur/actrice avant de l'ajouter ");
            }
        }


        //Fin de l'ajout d'un(e) acteur/actrice à un dvd//

        //Suppression d'un(e) acteur /actrice  à un dvd//
        private void btnSupprActeurDvd_Click(object sender, EventArgs e)
        {

            string connectionString = null;
            connectionString = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";
            ConnexionSql acteur_numacteur = new ConnexionSql(connectionString);
            ConnexionSql acteur_dvd = new ConnexionSql(connectionString);
            ConnexionSql supp = new ConnexionSql(connectionString);

            if (lstActeur.SelectedItem != null)
            {
                string acteur = lstActeur.SelectedItem.ToString();

                acteur_numacteur.reqSelect("select acteur.NUMACTEUR from acteur where NOM=\'" + acteur + "\'");
                acteur_dvd.reqSelect("select acteur_dvd.NUMDVD from acteur_dvd where NUMACTEUR='" + int.Parse(acteur_numacteur.champ("NUMACTEUR").ToString()) + "'");

                //suppression//
                int index;
                index = lstActeur.Items.IndexOf(acteur);
                lstActeur.Items.RemoveAt(index);
                photoact.Image = null;
                Acteur.Text = "";
                supp.reqUpdate("delete from acteur_dvd where NUMACTEUR='" + int.Parse(acteur_numacteur.champ("NUMACTEUR").ToString()) + "' and NUMDVD='" + int.Parse(acteur_dvd.champ("NUMDVD").ToString()) + "'");
                supp.fin();
                acteur_numacteur.fin();
                acteur_dvd.fin();
            }
            else
            {
                MessageBox.Show(" Veuillez Selectionner un acteur/actrice avant de l'effacer ");
            }
        }
        //Fin de Suppression d'un acteur//

        //Suppression d'un DVD// 
        private void btnSupprDvd_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show(" Etes vous sur(e) de vouloir effacer de DVD ?", " Confirmer la suppression", MessageBoxButtons.YesNo);
            //Suppresion acceptée//
            if (lstDvd.SelectedItem != null)
            {
                if (confirmation == DialogResult.Yes)
                {
                    string connectionString = null;
                    connectionString = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";
                    ConnexionSql suppr = new ConnexionSql(connectionString);
                    ConnexionSql suppr_dvd_act = new ConnexionSql(connectionString);
                    ConnexionSql numdvd = new ConnexionSql(connectionString);
                    string dvd = lstDvd.SelectedItem.ToString();
                    int index_dvd = lstDvd.Items.IndexOf(dvd);
                    numdvd.reqSelect("select dvd.NUMDVD from dvd where TITRE='" + dvd + "'");
                    //Suppression du lien dvd_acteur//
                    suppr_dvd_act.reqUpdate("delete from acteur_dvd where acteur_dvd.NUMDVD=" + int.Parse(numdvd.champ("NUMDVD").ToString()));
                    suppr.reqUpdate("delete from dvd where TITRE='" + dvd + "'");
                    lstDvd.Items.RemoveAt(index_dvd);
                    lstDvd.SelectedIndex = 0;
                    lstDvd.Focus();

                    suppr.fin();
                    suppr_dvd_act.fin();


                }
                //Suppresion non acceptée//
                else
                {
                    MessageBox.Show(" Le DVD ne" + lstDvd.SelectedItem.ToString() + " sera pas supprimé");

                }
            }

        }
        //Modification d'un DVD//
        private void btnModifDvd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Attention  : La modification ne prend pas en compte les acteurs du DVD !");
            //Si un titre est bien selectionné//
            if(lstDvd.SelectedItem != null)
            {

                string connectionString = null;
                connectionString = "server=localhost;database=gestiondvd;uid=root;pwd=\"\";";
                ConnexionSql modif_genre = new ConnexionSql(connectionString);
                
                ConnexionSql numgenre = new ConnexionSql(connectionString);
                ConnexionSql numdvd = new ConnexionSql(connectionString);
                
                string dvd = lstDvd.SelectedItem.ToString();
                int index = lstDvd.Items.IndexOf(dvd);
                Boolean present = false;
                //Si les champs de modification ne sont pas vides
                if(txtTitre.Text!="" && txtDurée.Text!=""&& cboGenre.Text!="" && txtDesc.Text!="")
                {
                    //Récupération du nouveau numgenre et du numdvd du DVD correspondant
                    numgenre.reqSelect("select NUMGENRE from genre where LIBELLE=\'" + cboGenre.Text + "\'");
                    numdvd.reqSelect("select dvd.NUMDVD from dvd where TITRE=\'"+dvd+"\'");

                    //Comparaisonn aves les titres déjà présents
                    for (int i=0; i < lstDvd.Items.Count; i++)
                    {
                        if (txtTitre.Text == lstDvd.Items[index].ToString())
                        {
                            present = true;
                            break;
                        }
                        if (txtTitre.Text == lstDvd.Items[i].ToString())
                        {
                            //Le titre est bien présent on sort de la boucle
                            present = true;
                            
                        }
                        else
                        {
                            //Le titre n'est pas présent
                            present = false;
                        }

                    }
                    if (present == true)
                    {
                        //Pas de modification
                        MessageBox.Show(" Le DVD est déjà présent ou aucune modification n'a été apporté au DVD :"+dvd+". Pas de modification possible !");
                    }
                    else
                    {
                        //Modification possible


                        
                        modif_genre.reqUpdate("update dvd set dvd.NUMGENRE=" + int.Parse(numgenre.champ("NUMGENRE").ToString())+" where TITRE='"+dvd+"'");
                        modif_genre.reqUpdate("update dvd set DUREE=" +txtDurée.Text + " where NUMDVD=" + int.Parse(numdvd.champ("NUMDVD").ToString()) + "");
                        modif_genre.reqUpdate("update dvd set TITRE=\'" + txtTitre.Text.Replace("'", "\"") + "\'where NUMDVD=" + int.Parse(numdvd.champ("NUMDVD").ToString()) + "");
                       
                        modif_genre.reqUpdate("update dvd set DESCRIPTION=\'" + txtDesc.Text.Replace("'", "\"") + "\'where NUMDVD=" + int.Parse(numdvd.champ("NUMDVD").ToString()) + "");
                        modif_genre.reqUpdate("update dvd set AVIS=\'" + txtDesc.Text.Replace("'", "\"") + "\'where NUMDVD=" + int.Parse(numdvd.champ("NUMDVD").ToString()) + "");
                        lstDvd.Items[index] = txtTitre.Text;
                        lstDvd.SelectedIndex= 0; 
                        lstDvd.Focus();
                        numgenre.fin();
                        modif_genre.fin();
                        numdvd.fin();
                        MessageBox.Show(" DVD modifié !");

                        
                        
                        
                       

                    }
                  
                    


                }
                else
                {
                    //Champs non remplis
                    MessageBox.Show("Remplissez les champs à modifier !");
                    lstDvd.SelectedIndex = 0;
                    lstDvd.Focus();
                }


            }
            else 
            {
                MessageBox.Show("Veuillez selectionner un DVD à modifier !");
                lstDvd.SelectedIndex = 0;
                lstDvd.Focus();

            }


        }
        public void reinitialiser(){
            if(lstDvd.SelectedIndex== 0)
            {
            lstDvd.Refresh();
            }

        }




        //Classe ConnexionSql// 
        class ConnexionSql
        {
            // propriétés //
            private bool finCurseur = true; // fin du curseur atteinte
            private MySqlConnection connection; // chaine de connexion
            private MySqlCommand command; // envoi de la requête à la base de données
            private MySqlDataReader reader; // gestion du curseur

            // constructeur //
            public ConnexionSql(string chaineConnection)
            {
                this.connection = new MySqlConnection(chaineConnection);
                this.connection.Open();
            }

            // execution d'une requete select
            public void reqSelect(string chaineRequete)
            {
                this.command = new MySqlCommand(chaineRequete, this.connection);
                this.reader = this.command.ExecuteReader();
                this.finCurseur = false;
                this.suivant();
            }

            // execution d'une requete update
            public void reqUpdate(string chaineRequete)
            {
                this.command = new MySqlCommand(chaineRequete, this.connection);
                this.command.ExecuteNonQuery();
                this.finCurseur = true;
            }

            // récupération d'un champ
            public Object champ(string nomChamp)
            {
                
                return this.reader[nomChamp];
                
            }

            // passage à la ligne suivante du curseur
            public void suivant()
            {
                if (!this.finCurseur)
                {
                    this.finCurseur = !this.reader.Read();
                }
            }

            // test de la fin du curseur
            public Boolean fin()
            {
                return this.finCurseur;
            }

            // fermeture de la connexion
            public void close()
            {
                this.connection.Close();
            }
        }

        private void photo_Click(object sender, EventArgs e)
        {
        }
       


        

        private void txtDurée_TextChanged(object sender, EventArgs e)
        {

        }

      

        //Fin de la classe ConnexionSql//  
    }
}

