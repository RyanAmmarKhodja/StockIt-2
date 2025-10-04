namespace StockIt_2.view.forms
{
    partial class gerer_fournisseur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            four_grid = new DataGridView();
            supprimer = new Button();
            modifier = new Button();
            confirmer = new Button();
            ((System.ComponentModel.ISupportInitialize)four_grid).BeginInit();
            SuspendLayout();
            // 
            // four_grid
            // 
            four_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            four_grid.Location = new Point(3, 12);
            four_grid.Name = "four_grid";
            four_grid.RowHeadersWidth = 62;
            four_grid.Size = new Size(1115, 524);
            four_grid.TabIndex = 1;
            // 
            // supprimer
            // 
            supprimer.Location = new Point(12, 542);
            supprimer.Name = "supprimer";
            supprimer.Size = new Size(174, 34);
            supprimer.TabIndex = 2;
            supprimer.Text = "Supprimer";
            supprimer.UseVisualStyleBackColor = true;
            // 
            // modifier
            // 
            modifier.Location = new Point(192, 542);
            modifier.Name = "modifier";
            modifier.Size = new Size(174, 34);
            modifier.TabIndex = 3;
            modifier.Text = "Modifier";
            modifier.UseVisualStyleBackColor = true;
            //modifier.Click += modifier_Click;
            // 
            // confirmer
            // 
            confirmer.Location = new Point(927, 542);
            confirmer.Name = "confirmer";
            confirmer.Size = new Size(191, 34);
            confirmer.TabIndex = 4;
            confirmer.Text = "Confirmer";
            confirmer.UseVisualStyleBackColor = true;
            // 
            // gerer_fournisseur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 602);
            Controls.Add(confirmer);
            Controls.Add(modifier);
            Controls.Add(supprimer);
            Controls.Add(four_grid);
            Name = "gerer_fournisseur";
            Text = "gerer_fournisseur";
            //Load += gerer_fournisseur_Load;
            ((System.ComponentModel.ISupportInitialize)four_grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView four_grid;
        private Button supprimer;
        private Button modifier;
        private Button confirmer;
    }
}