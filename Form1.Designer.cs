namespace Dashboard_Cassa___Ordini
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAggiungi = new Button();
            buttonRimuovi = new Button();
            buttonEmettiScontrino = new Button();
            listBoxRiepilogo = new ListBox();
            textBoxOggetto = new TextBox();
            textBoxPrezzo = new TextBox();
            textBoxQuantita = new TextBox();
            lblDescrizioneArticolo = new Label();
            lblPrezzo = new Label();
            lblQuantità = new Label();
            lblRiepilogoCarrello = new Label();
            labelImportoCassa = new Label();
            lblTotaleDovutoAllaCassa = new Label();
            SuspendLayout();
            // 
            // buttonAggiungi
            // 
            buttonAggiungi.Location = new Point(68, 229);
            buttonAggiungi.Name = "buttonAggiungi";
            buttonAggiungi.Size = new Size(190, 50);
            buttonAggiungi.TabIndex = 0;
            buttonAggiungi.Text = "+ Aggiungi Voce";
            buttonAggiungi.UseVisualStyleBackColor = true;
            buttonAggiungi.Click += buttonAggiungi_Click;
            // 
            // buttonRimuovi
            // 
            buttonRimuovi.Location = new Point(68, 285);
            buttonRimuovi.Name = "buttonRimuovi";
            buttonRimuovi.Size = new Size(190, 52);
            buttonRimuovi.TabIndex = 1;
            buttonRimuovi.Text = "Rimuovi Selezionato";
            buttonRimuovi.UseVisualStyleBackColor = true;
            buttonRimuovi.Click += buttonRimuovi_Click;
            // 
            // buttonEmettiScontrino
            // 
            buttonEmettiScontrino.Location = new Point(503, 351);
            buttonEmettiScontrino.Name = "buttonEmettiScontrino";
            buttonEmettiScontrino.Size = new Size(189, 54);
            buttonEmettiScontrino.TabIndex = 2;
            buttonEmettiScontrino.Text = "Emetti Scontrino";
            buttonEmettiScontrino.UseVisualStyleBackColor = true;
            
            // 
            // listBoxRiepilogo
            // 
            listBoxRiepilogo.FormattingEnabled = true;
            listBoxRiepilogo.Location = new Point(503, 70);
            listBoxRiepilogo.Name = "listBoxRiepilogo";
            listBoxRiepilogo.Size = new Size(285, 224);
            listBoxRiepilogo.TabIndex = 3;
            // 
            // textBoxOggetto
            // 
            textBoxOggetto.Location = new Point(68, 70);
            textBoxOggetto.Name = "textBoxOggetto";
            textBoxOggetto.Size = new Size(125, 27);
            textBoxOggetto.TabIndex = 4;
            // 
            // textBoxPrezzo
            // 
            textBoxPrezzo.Location = new Point(68, 131);
            textBoxPrezzo.Name = "textBoxPrezzo";
            textBoxPrezzo.Size = new Size(125, 27);
            textBoxPrezzo.TabIndex = 5;
            // 
            // textBoxQuantita
            // 
            textBoxQuantita.Location = new Point(68, 196);
            textBoxQuantita.Name = "textBoxQuantita";
            textBoxQuantita.Size = new Size(125, 27);
            textBoxQuantita.TabIndex = 6;
            // 
            // lblDescrizioneArticolo
            // 
            lblDescrizioneArticolo.AutoSize = true;
            lblDescrizioneArticolo.Location = new Point(68, 47);
            lblDescrizioneArticolo.Name = "lblDescrizioneArticolo";
            lblDescrizioneArticolo.Size = new Size(146, 20);
            lblDescrizioneArticolo.TabIndex = 7;
            lblDescrizioneArticolo.Text = "Descrizione Articolo:";
            // 
            // lblPrezzo
            // 
            lblPrezzo.AutoSize = true;
            lblPrezzo.Location = new Point(68, 108);
            lblPrezzo.Name = "lblPrezzo";
            lblPrezzo.Size = new Size(78, 20);
            lblPrezzo.TabIndex = 8;
            lblPrezzo.Text = "Prezzo (€):";
            // 
            // lblQuantità
            // 
            lblQuantità.AutoSize = true;
            lblQuantità.Location = new Point(68, 173);
            lblQuantità.Name = "lblQuantità";
            lblQuantità.Size = new Size(69, 20);
            lblQuantità.TabIndex = 9;
            lblQuantità.Text = "Quantità:";
            // 
            // lblRiepilogoCarrello
            // 
            lblRiepilogoCarrello.AutoSize = true;
            lblRiepilogoCarrello.Location = new Point(503, 47);
            lblRiepilogoCarrello.Name = "lblRiepilogoCarrello";
            lblRiepilogoCarrello.Size = new Size(194, 20);
            lblRiepilogoCarrello.TabIndex = 10;
            lblRiepilogoCarrello.Text = "Riepilogo Carrello (ListBox):";
            // 
            // labelImportoCassa
            // 
            labelImportoCassa.AutoSize = true;
            labelImportoCassa.BackColor = SystemColors.ButtonHighlight;
            labelImportoCassa.BorderStyle = BorderStyle.FixedSingle;
            labelImportoCassa.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelImportoCassa.ForeColor = Color.YellowGreen;
            labelImportoCassa.Location = new Point(286, 371);
            labelImportoCassa.Name = "labelImportoCassa";
            labelImportoCassa.Size = new Size(2, 27);
            labelImportoCassa.TabIndex = 11;
            // 
            // lblTotaleDovutoAllaCassa
            // 
            lblTotaleDovutoAllaCassa.AutoSize = true;
            lblTotaleDovutoAllaCassa.Location = new Point(286, 351);
            lblTotaleDovutoAllaCassa.Name = "lblTotaleDovutoAllaCassa";
            lblTotaleDovutoAllaCassa.Size = new Size(211, 20);
            lblTotaleDovutoAllaCassa.TabIndex = 12;
            lblTotaleDovutoAllaCassa.Text = "TOTALE DOVUTO ALLA CASSA:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotaleDovutoAllaCassa);
            Controls.Add(labelImportoCassa);
            Controls.Add(lblRiepilogoCarrello);
            Controls.Add(lblQuantità);
            Controls.Add(lblPrezzo);
            Controls.Add(lblDescrizioneArticolo);
            Controls.Add(textBoxQuantita);
            Controls.Add(textBoxPrezzo);
            Controls.Add(textBoxOggetto);
            Controls.Add(listBoxRiepilogo);
            Controls.Add(buttonEmettiScontrino);
            Controls.Add(buttonRimuovi);
            Controls.Add(buttonAggiungi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAggiungi;
        private Button buttonRimuovi;
        private Button buttonEmettiScontrino;
        private ListBox listBoxRiepilogo;
        private TextBox textBoxOggetto;
        private TextBox textBoxPrezzo;
        private TextBox textBoxQuantita;
        private Label lblDescrizioneArticolo;
        private Label lblPrezzo;
        private Label lblQuantità;
        private Label lblRiepilogoCarrello;
        private Label labelImportoCassa;
        private Label lblTotaleDovutoAllaCassa;
    }
}
