using StockIt_2.services.GestionProduit;

namespace StockIt_2.view.user_controls
{
    partial class uc_bon
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            fadresse = new TextBox();
            facture = new TextBox();
            bl = new TextBox();
            ftel = new TextBox();
            nis = new TextBox();
            nif = new TextBox();
            ai = new TextBox();
            rc = new TextBox();
            fprenom = new TextBox();
            fnom = new TextBox();
            tadresse = new TextBox();
            ttel = new TextBox();
            matricule = new TextBox();
            label14 = new Label();
            tprenom = new TextBox();
            tnom = new TextBox();
            label17 = new Label();
            label18 = new Label();
            button3 = new Button();
            prix_unitaire = new TextBox();
            label22 = new Label();
            poids = new TextBox();
            nombre = new TextBox();
            cout_transport = new TextBox();
            imprimer = new Button();
            label26 = new Label();
            crc = new TextBox();
            cadresse = new TextBox();
            cai = new TextBox();
            cnif = new TextBox();
            cnis = new TextBox();
            ajouter_produit = new Button();
            combo = new ComboBox();
            gestionProduitBindingSource = new BindingSource(components);
            button4 = new Button();
            total_ttc = new Label();
            total_tpv = new Label();
            total_general = new Label();
            coords_email = new TextBox();
            coords_tel = new TextBox();
            kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel15 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel14 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            choisir_fournisseur = new Krypton.Toolkit.KryptonButton();
            panel_header_fournisseur = new Panel();
            panel_header_transporteur = new Panel();
            button1 = new Krypton.Toolkit.KryptonButton();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel23 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel22 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel21 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel20 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel19 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel18 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel17 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel16 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel30 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel29 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel28 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel27 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel26 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel25 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel24 = new Krypton.Toolkit.KryptonLabel();
            panel_header_coords = new Panel();
            panel_header_command = new Panel();
            ((System.ComponentModel.ISupportInitialize)gestionProduitBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            panel_header_fournisseur.SuspendLayout();
            panel_header_transporteur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            panel_header_coords.SuspendLayout();
            panel_header_command.SuspendLayout();
            SuspendLayout();
            // 
            // fadresse
            // 
            fadresse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            fadresse.Location = new Point(140, 91);
            fadresse.Name = "fadresse";
            fadresse.Size = new Size(727, 31);
            fadresse.TabIndex = 66;
            // 
            // facture
            // 
            facture.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            facture.Location = new Point(140, 490);
            facture.Name = "facture";
            facture.Size = new Size(302, 31);
            facture.TabIndex = 64;
            // 
            // bl
            // 
            bl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            bl.Location = new Point(140, 430);
            bl.Name = "bl";
            bl.Size = new Size(302, 31);
            bl.TabIndex = 62;
            // 
            // ftel
            // 
            ftel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ftel.Location = new Point(140, 374);
            ftel.Name = "ftel";
            ftel.Size = new Size(302, 31);
            ftel.TabIndex = 60;
            // 
            // nis
            // 
            nis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nis.Location = new Point(140, 318);
            nis.Name = "nis";
            nis.Size = new Size(302, 31);
            nis.TabIndex = 58;
            // 
            // nif
            // 
            nif.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nif.Location = new Point(140, 259);
            nif.Name = "nif";
            nif.Size = new Size(302, 31);
            nif.TabIndex = 56;
            // 
            // ai
            // 
            ai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ai.Location = new Point(140, 202);
            ai.Name = "ai";
            ai.Size = new Size(302, 31);
            ai.TabIndex = 54;
            // 
            // rc
            // 
            rc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rc.Location = new Point(140, 145);
            rc.Name = "rc";
            rc.Size = new Size(302, 31);
            rc.TabIndex = 52;
            // 
            // fprenom
            // 
            fprenom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            fprenom.Location = new Point(569, 42);
            fprenom.Name = "fprenom";
            fprenom.Size = new Size(298, 31);
            fprenom.TabIndex = 50;
            // 
            // fnom
            // 
            fnom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            fnom.Location = new Point(140, 42);
            fnom.Name = "fnom";
            fnom.Size = new Size(298, 31);
            fnom.TabIndex = 48;
            // 
            // tadresse
            // 
            tadresse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tadresse.Location = new Point(140, 63);
            tadresse.Name = "tadresse";
            tadresse.Size = new Size(744, 31);
            tadresse.TabIndex = 77;
            // 
            // ttel
            // 
            ttel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ttel.Location = new Point(140, 169);
            ttel.Name = "ttel";
            ttel.Size = new Size(302, 31);
            ttel.TabIndex = 75;
            // 
            // matricule
            // 
            matricule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            matricule.Location = new Point(140, 116);
            matricule.Name = "matricule";
            matricule.Size = new Size(302, 31);
            matricule.TabIndex = 73;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label14.Location = new Point(3, 9);
            label14.Name = "label14";
            label14.Size = new Size(290, 32);
            label14.TabIndex = 71;
            label14.Text = "Ajouter un transporteur";
            // 
            // tprenom
            // 
            tprenom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tprenom.Location = new Point(569, 13);
            tprenom.Name = "tprenom";
            tprenom.Size = new Size(315, 31);
            tprenom.TabIndex = 70;
            // 
            // tnom
            // 
            tnom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tnom.Location = new Point(140, 13);
            tnom.Name = "tnom";
            tnom.Size = new Size(302, 31);
            tnom.TabIndex = 68;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(275, 32);
            label17.TabIndex = 78;
            label17.Text = "Ajouter un fournisseur";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F);
            label18.Location = new Point(86, 20);
            label18.Name = "label18";
            label18.Size = new Size(403, 32);
            label18.TabIndex = 79;
            label18.Text = "Accueil/Achats/Créer un bon d'achat";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(31, 19);
            button3.Name = "button3";
            button3.Size = new Size(43, 34);
            button3.TabIndex = 83;
            button3.Text = "<";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // prix_unitaire
            // 
            prix_unitaire.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            prix_unitaire.Location = new Point(223, 121);
            prix_unitaire.Name = "prix_unitaire";
            prix_unitaire.Size = new Size(124, 31);
            prix_unitaire.TabIndex = 94;
            prix_unitaire.TextChanged += prix_unitaire_TextChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label22.Location = new Point(3, 0);
            label22.Name = "label22";
            label22.Size = new Size(158, 32);
            label22.TabIndex = 88;
            label22.Text = "Commande: ";
            // 
            // poids
            // 
            poids.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            poids.Location = new Point(223, 88);
            poids.Name = "poids";
            poids.Size = new Size(124, 31);
            poids.TabIndex = 87;
            poids.TextChanged += poids_TextChanged;
            // 
            // nombre
            // 
            nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nombre.Location = new Point(223, 51);
            nombre.Name = "nombre";
            nombre.Size = new Size(124, 31);
            nombre.TabIndex = 85;
            nombre.TextChanged += nombre_TextChanged;
            // 
            // cout_transport
            // 
            cout_transport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cout_transport.Location = new Point(223, 158);
            cout_transport.Name = "cout_transport";
            cout_transport.Size = new Size(124, 31);
            cout_transport.TabIndex = 99;
            cout_transport.TextChanged += tpv_TextChanged;
            // 
            // imprimer
            // 
            imprimer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imprimer.Font = new Font("Segoe UI", 10F);
            imprimer.Location = new Point(444, 1819);
            imprimer.Name = "imprimer";
            imprimer.Size = new Size(338, 56);
            imprimer.TabIndex = 100;
            imprimer.Text = "Imprimer";
            imprimer.UseVisualStyleBackColor = true;
            imprimer.Click += imprimer_Click;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label26.Location = new Point(3, 3);
            label26.Name = "label26";
            label26.Size = new Size(180, 32);
            label26.TabIndex = 103;
            label26.Text = "Coordonnées :";
            // 
            // crc
            // 
            crc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            crc.Location = new Point(156, 106);
            crc.Name = "crc";
            crc.Size = new Size(450, 31);
            crc.TabIndex = 102;
            // 
            // cadresse
            // 
            cadresse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cadresse.Location = new Point(156, 150);
            cadresse.Name = "cadresse";
            cadresse.Size = new Size(450, 31);
            cadresse.TabIndex = 105;
            // 
            // cai
            // 
            cai.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cai.Location = new Point(156, 194);
            cai.Name = "cai";
            cai.Size = new Size(450, 31);
            cai.TabIndex = 107;
            // 
            // cnif
            // 
            cnif.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cnif.Location = new Point(156, 237);
            cnif.Name = "cnif";
            cnif.Size = new Size(450, 31);
            cnif.TabIndex = 109;
            // 
            // cnis
            // 
            cnis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            cnis.Location = new Point(156, 280);
            cnis.Name = "cnis";
            cnis.Size = new Size(450, 31);
            cnis.TabIndex = 111;
            // 
            // ajouter_produit
            // 
            ajouter_produit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            ajouter_produit.Location = new Point(471, 10);
            ajouter_produit.Name = "ajouter_produit";
            ajouter_produit.Size = new Size(199, 33);
            ajouter_produit.TabIndex = 112;
            ajouter_produit.Text = "Ajouter produit";
            ajouter_produit.UseVisualStyleBackColor = true;
            ajouter_produit.Click += ajouter_produit_Click;
            // 
            // combo
            // 
            combo.AllowDrop = true;
            combo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            combo.FormattingEnabled = true;
            combo.Location = new Point(145, 10);
            combo.Name = "combo";
            combo.Size = new Size(320, 33);
            combo.TabIndex = 113;
            // 
            // gestionProduitBindingSource
            // 
            gestionProduitBindingSource.DataSource = typeof(GestionProduit);
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F);
            button4.Location = new Point(615, 0);
            button4.Name = "button4";
            button4.Size = new Size(275, 41);
            button4.TabIndex = 115;
            button4.Text = "Enregistrer les modifications";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // total_ttc
            // 
            total_ttc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            total_ttc.AutoSize = true;
            total_ttc.Font = new Font("Segoe UI", 12F);
            total_ttc.Location = new Point(433, 118);
            total_ttc.Name = "total_ttc";
            total_ttc.Size = new Size(27, 32);
            total_ttc.TabIndex = 117;
            total_ttc.Text = "0";
            // 
            // total_tpv
            // 
            total_tpv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            total_tpv.AutoSize = true;
            total_tpv.Font = new Font("Segoe UI", 12F);
            total_tpv.Location = new Point(433, 155);
            total_tpv.Name = "total_tpv";
            total_tpv.Size = new Size(27, 32);
            total_tpv.TabIndex = 118;
            total_tpv.Text = "0";
            // 
            // total_general
            // 
            total_general.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            total_general.AutoSize = true;
            total_general.Font = new Font("Segoe UI", 12F);
            total_general.Location = new Point(433, 195);
            total_general.Name = "total_general";
            total_general.Size = new Size(27, 32);
            total_general.TabIndex = 119;
            total_general.Text = "0";
            // 
            // coords_email
            // 
            coords_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            coords_email.Location = new Point(156, 61);
            coords_email.Name = "coords_email";
            coords_email.Size = new Size(450, 31);
            coords_email.TabIndex = 121;
            // 
            // coords_tel
            // 
            coords_tel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            coords_tel.Location = new Point(156, 17);
            coords_tel.Name = "coords_tel";
            coords_tel.Size = new Size(450, 31);
            coords_tel.TabIndex = 123;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonLabel10);
            kryptonPanel1.Controls.Add(kryptonLabel9);
            kryptonPanel1.Controls.Add(kryptonLabel8);
            kryptonPanel1.Controls.Add(kryptonLabel7);
            kryptonPanel1.Controls.Add(kryptonLabel6);
            kryptonPanel1.Controls.Add(kryptonLabel5);
            kryptonPanel1.Controls.Add(kryptonLabel4);
            kryptonPanel1.Controls.Add(kryptonLabel3);
            kryptonPanel1.Controls.Add(kryptonLabel2);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Controls.Add(fnom);
            kryptonPanel1.Controls.Add(fprenom);
            kryptonPanel1.Controls.Add(fadresse);
            kryptonPanel1.Controls.Add(rc);
            kryptonPanel1.Controls.Add(ai);
            kryptonPanel1.Controls.Add(nif);
            kryptonPanel1.Controls.Add(nis);
            kryptonPanel1.Controls.Add(ftel);
            kryptonPanel1.Controls.Add(bl);
            kryptonPanel1.Controls.Add(facture);
            kryptonPanel1.Location = new Point(176, 113);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.HeaderForm;
            kryptonPanel1.Size = new Size(893, 544);
            kryptonPanel1.TabIndex = 124;
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel10.Location = new Point(13, 492);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(123, 29);
            kryptonLabel10.TabIndex = 74;
            kryptonLabel10.Values.Text = "N° FACTURE :";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel9.Location = new Point(13, 432);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(62, 29);
            kryptonLabel9.TabIndex = 73;
            kryptonLabel9.Values.Text = "N°BL :";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel8.Location = new Point(13, 376);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(49, 29);
            kryptonLabel8.TabIndex = 72;
            kryptonLabel8.Values.Text = "TEL :";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel7.Location = new Point(13, 320);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(50, 29);
            kryptonLabel7.TabIndex = 71;
            kryptonLabel7.Values.Text = "NIS :";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel6.Location = new Point(13, 261);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(49, 29);
            kryptonLabel6.TabIndex = 70;
            kryptonLabel6.Values.Text = "NIF :";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel5.Location = new Point(13, 204);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(38, 29);
            kryptonLabel5.TabIndex = 69;
            kryptonLabel5.Values.Text = "AI :";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel4.Location = new Point(13, 145);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(44, 29);
            kryptonLabel4.TabIndex = 68;
            kryptonLabel4.Values.Text = "RC :";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel3.Location = new Point(13, 93);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(86, 29);
            kryptonLabel3.TabIndex = 67;
            kryptonLabel3.Values.Text = "Adresse :";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel2.Location = new Point(476, 44);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(85, 29);
            kryptonLabel2.TabIndex = 51;
            kryptonLabel2.Values.Text = "Prénom :";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel1.Location = new Point(13, 44);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(62, 29);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Nom :";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonLabel15);
            kryptonPanel2.Controls.Add(kryptonLabel14);
            kryptonPanel2.Controls.Add(kryptonLabel13);
            kryptonPanel2.Controls.Add(kryptonLabel11);
            kryptonPanel2.Controls.Add(kryptonLabel12);
            kryptonPanel2.Controls.Add(tnom);
            kryptonPanel2.Controls.Add(tprenom);
            kryptonPanel2.Controls.Add(tadresse);
            kryptonPanel2.Controls.Add(matricule);
            kryptonPanel2.Controls.Add(ttel);
            kryptonPanel2.Location = new Point(176, 740);
            kryptonPanel2.Margin = new Padding(50, 3, 50, 3);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(893, 248);
            kryptonPanel2.TabIndex = 125;
            // 
            // kryptonLabel15
            // 
            kryptonLabel15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel15.Location = new Point(13, 118);
            kryptonLabel15.Name = "kryptonLabel15";
            kryptonLabel15.Size = new Size(98, 29);
            kryptonLabel15.TabIndex = 80;
            kryptonLabel15.Values.Text = "Matricule :";
            // 
            // kryptonLabel14
            // 
            kryptonLabel14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel14.Location = new Point(14, 171);
            kryptonLabel14.Name = "kryptonLabel14";
            kryptonLabel14.Size = new Size(49, 29);
            kryptonLabel14.TabIndex = 79;
            kryptonLabel14.Values.Text = "TEL :";
            // 
            // kryptonLabel13
            // 
            kryptonLabel13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel13.Location = new Point(13, 65);
            kryptonLabel13.Name = "kryptonLabel13";
            kryptonLabel13.Size = new Size(86, 29);
            kryptonLabel13.TabIndex = 78;
            kryptonLabel13.Values.Text = "Adresse :";
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel11.Location = new Point(476, 15);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new Size(85, 29);
            kryptonLabel11.TabIndex = 70;
            kryptonLabel11.Values.Text = "Prénom :";
            // 
            // kryptonLabel12
            // 
            kryptonLabel12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel12.Location = new Point(13, 15);
            kryptonLabel12.Name = "kryptonLabel12";
            kryptonLabel12.Size = new Size(62, 29);
            kryptonLabel12.TabIndex = 69;
            kryptonLabel12.Values.Text = "Nom :";
            // 
            // choisir_fournisseur
            // 
            choisir_fournisseur.Location = new Point(615, 3);
            choisir_fournisseur.Name = "choisir_fournisseur";
            choisir_fournisseur.Size = new Size(275, 38);
            choisir_fournisseur.TabIndex = 126;
            choisir_fournisseur.Values.DropDownArrowColor = Color.Empty;
            choisir_fournisseur.Values.Text = "Choisir un fournisseur";
            choisir_fournisseur.Click += choisir_fournisseur_Click;
            // 
            // panel_header_fournisseur
            // 
            panel_header_fournisseur.AutoSize = true;
            panel_header_fournisseur.Controls.Add(label17);
            panel_header_fournisseur.Controls.Add(choisir_fournisseur);
            panel_header_fournisseur.Location = new Point(176, 64);
            panel_header_fournisseur.Name = "panel_header_fournisseur";
            panel_header_fournisseur.Size = new Size(893, 44);
            panel_header_fournisseur.TabIndex = 127;
            // 
            // panel_header_transporteur
            // 
            panel_header_transporteur.Controls.Add(button1);
            panel_header_transporteur.Controls.Add(label14);
            panel_header_transporteur.Location = new Point(176, 685);
            panel_header_transporteur.Name = "panel_header_transporteur";
            panel_header_transporteur.Size = new Size(893, 49);
            panel_header_transporteur.TabIndex = 128;
            // 
            // button1
            // 
            button1.Location = new Point(615, 5);
            button1.Name = "button1";
            button1.Size = new Size(275, 41);
            button1.TabIndex = 129;
            button1.Values.DropDownArrowColor = Color.Empty;
            button1.Values.Text = "Choisir un transporteur";
            button1.Click += button1_Click;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(kryptonLabel23);
            kryptonPanel3.Controls.Add(kryptonLabel22);
            kryptonPanel3.Controls.Add(kryptonLabel21);
            kryptonPanel3.Controls.Add(kryptonLabel20);
            kryptonPanel3.Controls.Add(kryptonLabel19);
            kryptonPanel3.Controls.Add(kryptonLabel18);
            kryptonPanel3.Controls.Add(kryptonLabel17);
            kryptonPanel3.Controls.Add(kryptonLabel16);
            kryptonPanel3.Controls.Add(combo);
            kryptonPanel3.Controls.Add(ajouter_produit);
            kryptonPanel3.Controls.Add(total_general);
            kryptonPanel3.Controls.Add(nombre);
            kryptonPanel3.Controls.Add(poids);
            kryptonPanel3.Controls.Add(prix_unitaire);
            kryptonPanel3.Controls.Add(total_tpv);
            kryptonPanel3.Controls.Add(total_ttc);
            kryptonPanel3.Controls.Add(cout_transport);
            kryptonPanel3.Location = new Point(176, 1072);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(893, 299);
            kryptonPanel3.TabIndex = 130;
            // 
            // kryptonLabel23
            // 
            kryptonLabel23.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel23.Location = new Point(365, 195);
            kryptonLabel23.Name = "kryptonLabel23";
            kryptonLabel23.Size = new Size(44, 29);
            kryptonLabel23.TabIndex = 121;
            kryptonLabel23.Values.Text = "TG :";
            // 
            // kryptonLabel22
            // 
            kryptonLabel22.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel22.Location = new Point(365, 160);
            kryptonLabel22.Name = "kryptonLabel22";
            kryptonLabel22.Size = new Size(62, 29);
            kryptonLabel22.TabIndex = 120;
            kryptonLabel22.Values.Text = "Total :";
            // 
            // kryptonLabel21
            // 
            kryptonLabel21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel21.Location = new Point(365, 121);
            kryptonLabel21.Name = "kryptonLabel21";
            kryptonLabel21.Size = new Size(62, 29);
            kryptonLabel21.TabIndex = 119;
            kryptonLabel21.Values.Text = "Total :";
            // 
            // kryptonLabel20
            // 
            kryptonLabel20.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel20.Location = new Point(3, 160);
            kryptonLabel20.Name = "kryptonLabel20";
            kryptonLabel20.Size = new Size(214, 29);
            kryptonLabel20.TabIndex = 118;
            kryptonLabel20.Values.Text = "Coût transport par unité:";
            // 
            // kryptonLabel19
            // 
            kryptonLabel19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel19.Location = new Point(3, 121);
            kryptonLabel19.Name = "kryptonLabel19";
            kryptonLabel19.Size = new Size(130, 29);
            kryptonLabel19.TabIndex = 117;
            kryptonLabel19.Values.Text = "Prix par unité :";
            // 
            // kryptonLabel18
            // 
            kryptonLabel18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel18.Location = new Point(3, 86);
            kryptonLabel18.Name = "kryptonLabel18";
            kryptonLabel18.Size = new Size(137, 29);
            kryptonLabel18.TabIndex = 116;
            kryptonLabel18.Values.Text = "Poids (en Kgs) :";
            // 
            // kryptonLabel17
            // 
            kryptonLabel17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel17.Location = new Point(3, 51);
            kryptonLabel17.Name = "kryptonLabel17";
            kryptonLabel17.Size = new Size(89, 29);
            kryptonLabel17.TabIndex = 115;
            kryptonLabel17.Values.Text = "Nombre :";
            // 
            // kryptonLabel16
            // 
            kryptonLabel16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel16.Location = new Point(3, 14);
            kryptonLabel16.Name = "kryptonLabel16";
            kryptonLabel16.Size = new Size(120, 29);
            kryptonLabel16.TabIndex = 114;
            kryptonLabel16.Values.Text = "Désignation :";
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(kryptonLabel30);
            kryptonPanel4.Controls.Add(kryptonLabel29);
            kryptonPanel4.Controls.Add(kryptonLabel28);
            kryptonPanel4.Controls.Add(kryptonLabel27);
            kryptonPanel4.Controls.Add(kryptonLabel26);
            kryptonPanel4.Controls.Add(kryptonLabel25);
            kryptonPanel4.Controls.Add(kryptonLabel24);
            kryptonPanel4.Controls.Add(coords_tel);
            kryptonPanel4.Controls.Add(coords_email);
            kryptonPanel4.Controls.Add(crc);
            kryptonPanel4.Controls.Add(cadresse);
            kryptonPanel4.Controls.Add(cai);
            kryptonPanel4.Controls.Add(cnif);
            kryptonPanel4.Controls.Add(cnis);
            kryptonPanel4.Location = new Point(176, 1468);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(893, 345);
            kryptonPanel4.TabIndex = 131;
            // 
            // kryptonLabel30
            // 
            kryptonLabel30.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel30.Location = new Point(11, 235);
            kryptonLabel30.Name = "kryptonLabel30";
            kryptonLabel30.Size = new Size(49, 29);
            kryptonLabel30.TabIndex = 128;
            kryptonLabel30.Values.Text = "NIF :";
            // 
            // kryptonLabel29
            // 
            kryptonLabel29.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel29.Location = new Point(11, 194);
            kryptonLabel29.Name = "kryptonLabel29";
            kryptonLabel29.Size = new Size(38, 29);
            kryptonLabel29.TabIndex = 127;
            kryptonLabel29.Values.Text = "AI :";
            // 
            // kryptonLabel28
            // 
            kryptonLabel28.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel28.Location = new Point(11, 282);
            kryptonLabel28.Name = "kryptonLabel28";
            kryptonLabel28.Size = new Size(50, 29);
            kryptonLabel28.TabIndex = 127;
            kryptonLabel28.Values.Text = "NIS :";
            // 
            // kryptonLabel27
            // 
            kryptonLabel27.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel27.Location = new Point(11, 150);
            kryptonLabel27.Name = "kryptonLabel27";
            kryptonLabel27.Size = new Size(86, 29);
            kryptonLabel27.TabIndex = 126;
            kryptonLabel27.Values.Text = "Adresse :";
            // 
            // kryptonLabel26
            // 
            kryptonLabel26.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel26.Location = new Point(11, 106);
            kryptonLabel26.Name = "kryptonLabel26";
            kryptonLabel26.Size = new Size(44, 29);
            kryptonLabel26.TabIndex = 125;
            kryptonLabel26.Values.Text = "RC :";
            // 
            // kryptonLabel25
            // 
            kryptonLabel25.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel25.Location = new Point(11, 61);
            kryptonLabel25.Name = "kryptonLabel25";
            kryptonLabel25.Size = new Size(65, 29);
            kryptonLabel25.TabIndex = 124;
            kryptonLabel25.Values.Text = "Email :";
            // 
            // kryptonLabel24
            // 
            kryptonLabel24.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            kryptonLabel24.Location = new Point(11, 17);
            kryptonLabel24.Name = "kryptonLabel24";
            kryptonLabel24.Size = new Size(45, 29);
            kryptonLabel24.TabIndex = 0;
            kryptonLabel24.Values.Text = "Tel :";
            // 
            // panel_header_coords
            // 
            panel_header_coords.Controls.Add(button4);
            panel_header_coords.Controls.Add(label26);
            panel_header_coords.Location = new Point(176, 1419);
            panel_header_coords.Name = "panel_header_coords";
            panel_header_coords.Size = new Size(893, 43);
            panel_header_coords.TabIndex = 133;
            // 
            // panel_header_command
            // 
            panel_header_command.Controls.Add(label22);
            panel_header_command.Location = new Point(176, 1025);
            panel_header_command.Name = "panel_header_command";
            panel_header_command.Size = new Size(893, 41);
            panel_header_command.TabIndex = 134;
            // 
            // uc_bon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel_header_command);
            Controls.Add(panel_header_coords);
            Controls.Add(kryptonPanel4);
            Controls.Add(kryptonPanel3);
            Controls.Add(panel_header_transporteur);
            Controls.Add(panel_header_fournisseur);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Controls.Add(imprimer);
            Controls.Add(button3);
            Controls.Add(label18);
            Name = "uc_bon";
            Size = new Size(1252, 2103);
            Load += uc_bon_Load;
            Resize += uc_bon_Resize;
            ((System.ComponentModel.ISupportInitialize)gestionProduitBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            panel_header_fournisseur.ResumeLayout(false);
            panel_header_fournisseur.PerformLayout();
            panel_header_transporteur.ResumeLayout(false);
            panel_header_transporteur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            kryptonPanel4.PerformLayout();
            panel_header_coords.ResumeLayout(false);
            panel_header_coords.PerformLayout();
            panel_header_command.ResumeLayout(false);
            panel_header_command.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fadresse;
        private TextBox facture;
        private TextBox bl;
        private TextBox ftel;
        private TextBox nis;
        private TextBox nif;
        private TextBox ai;
        private TextBox rc;
        private TextBox fprenom;
        private TextBox fnom;
        private TextBox tadresse;
        private TextBox ttel;
        private TextBox matricule;
        private Label label14;
        private TextBox tprenom;
        private TextBox tnom;
        private Label label17;
        private Label label18;
        private Button button3;
        private TextBox prix_unitaire;
        private Label label22;
        private TextBox poids;
        private TextBox nombre;
        private TextBox designation;
        private TextBox cout_transport;
        private Button imprimer;
        private Label label26;
        private TextBox crc;
        private TextBox cadresse;
        private TextBox cai;
        private TextBox cnif;
        private TextBox cnis;
        private Button ajouter_produit;
        private ComboBox combo;
        private BindingSource gestionProduitBindingSource;
        private Button button4;
        private Label total_ttc;
        private Label total_tpv;
        private Label total_general;
        private TextBox coords_email;
        private TextBox coords_tel;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel15;
        private Krypton.Toolkit.KryptonLabel kryptonLabel14;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonButton choisir_fournisseur;
        private Panel panel_header_fournisseur;
        private Panel panel_header_transporteur;
        private Krypton.Toolkit.KryptonButton button1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel18;
        private Krypton.Toolkit.KryptonLabel kryptonLabel17;
        private Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private Krypton.Toolkit.KryptonLabel kryptonLabel23;
        private Krypton.Toolkit.KryptonLabel kryptonLabel22;
        private Krypton.Toolkit.KryptonLabel kryptonLabel21;
        private Krypton.Toolkit.KryptonLabel kryptonLabel20;
        private Krypton.Toolkit.KryptonLabel kryptonLabel19;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel30;
        private Krypton.Toolkit.KryptonLabel kryptonLabel29;
        private Krypton.Toolkit.KryptonLabel kryptonLabel28;
        private Krypton.Toolkit.KryptonLabel kryptonLabel27;
        private Krypton.Toolkit.KryptonLabel kryptonLabel26;
        private Krypton.Toolkit.KryptonLabel kryptonLabel25;
        private Krypton.Toolkit.KryptonLabel kryptonLabel24;
        private Panel panel_header_coords;
        private Panel panel_header_command;
    }
}
