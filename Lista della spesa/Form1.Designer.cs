namespace Lista_della_spesa
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
            pnl_BottoniAlti = new Panel();
            txt_QuantitaProdotto = new TextBox();
            txt_CostoProdotto = new TextBox();
            txt_NomeProdotto = new TextBox();
            btn_Rimuovi = new Button();
            btn_Aggiungi = new Button();
            lbl_TitoloBottoniAlti = new Label();
            lst_ListaDellaSpesa = new ListBox();
            pnl_BottoniAlti.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_BottoniAlti
            // 
            pnl_BottoniAlti.Controls.Add(txt_QuantitaProdotto);
            pnl_BottoniAlti.Controls.Add(txt_CostoProdotto);
            pnl_BottoniAlti.Controls.Add(txt_NomeProdotto);
            pnl_BottoniAlti.Controls.Add(btn_Rimuovi);
            pnl_BottoniAlti.Controls.Add(btn_Aggiungi);
            pnl_BottoniAlti.Location = new Point(12, 37);
            pnl_BottoniAlti.Name = "pnl_BottoniAlti";
            pnl_BottoniAlti.Size = new Size(776, 104);
            pnl_BottoniAlti.TabIndex = 0;
            // 
            // txt_QuantitaProdotto
            // 
            txt_QuantitaProdotto.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_QuantitaProdotto.Location = new Point(322, 43);
            txt_QuantitaProdotto.Name = "txt_QuantitaProdotto";
            txt_QuantitaProdotto.PlaceholderText = "Quantità prodotto";
            txt_QuantitaProdotto.Size = new Size(125, 22);
            txt_QuantitaProdotto.TabIndex = 1;
            // 
            // txt_CostoProdotto
            // 
            txt_CostoProdotto.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_CostoProdotto.Location = new Point(173, 43);
            txt_CostoProdotto.Name = "txt_CostoProdotto";
            txt_CostoProdotto.PlaceholderText = "Costo prodotto";
            txt_CostoProdotto.Size = new Size(125, 22);
            txt_CostoProdotto.TabIndex = 1;
            // 
            // txt_NomeProdotto
            // 
            txt_NomeProdotto.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_NomeProdotto.Location = new Point(22, 43);
            txt_NomeProdotto.Name = "txt_NomeProdotto";
            txt_NomeProdotto.PlaceholderText = "Nome prodotto";
            txt_NomeProdotto.Size = new Size(125, 22);
            txt_NomeProdotto.TabIndex = 1;
            // 
            // btn_Rimuovi
            // 
            btn_Rimuovi.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Rimuovi.Location = new Point(651, 33);
            btn_Rimuovi.Name = "btn_Rimuovi";
            btn_Rimuovi.Size = new Size(103, 39);
            btn_Rimuovi.TabIndex = 0;
            btn_Rimuovi.Text = "RIMUOVI";
            btn_Rimuovi.UseVisualStyleBackColor = true;
            btn_Rimuovi.Click += btn_Rimuovi_Click;
            // 
            // btn_Aggiungi
            // 
            btn_Aggiungi.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Aggiungi.Location = new Point(513, 32);
            btn_Aggiungi.Name = "btn_Aggiungi";
            btn_Aggiungi.Size = new Size(103, 39);
            btn_Aggiungi.TabIndex = 0;
            btn_Aggiungi.Text = "AGGIUNGI";
            btn_Aggiungi.UseVisualStyleBackColor = true;
            btn_Aggiungi.Click += btn_Aggiungi_Click;
            // 
            // lbl_TitoloBottoniAlti
            // 
            lbl_TitoloBottoniAlti.AutoSize = true;
            lbl_TitoloBottoniAlti.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TitoloBottoniAlti.Location = new Point(12, 19);
            lbl_TitoloBottoniAlti.Name = "lbl_TitoloBottoniAlti";
            lbl_TitoloBottoniAlti.Size = new Size(152, 18);
            lbl_TitoloBottoniAlti.TabIndex = 1;
            lbl_TitoloBottoniAlti.Text = "Seleziona una funzione";
            // 
            // lst_ListaDellaSpesa
            // 
            lst_ListaDellaSpesa.FormattingEnabled = true;
            lst_ListaDellaSpesa.ItemHeight = 15;
            lst_ListaDellaSpesa.Location = new Point(12, 147);
            lst_ListaDellaSpesa.Name = "lst_ListaDellaSpesa";
            lst_ListaDellaSpesa.Size = new Size(776, 274);
            lst_ListaDellaSpesa.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lst_ListaDellaSpesa);
            Controls.Add(lbl_TitoloBottoniAlti);
            Controls.Add(pnl_BottoniAlti);
            Name = "Form1";
            Text = "Lista della spesa";
            Load += Form1_Load;
            pnl_BottoniAlti.ResumeLayout(false);
            pnl_BottoniAlti.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_BottoniAlti;
        private Button btn_Aggiungi;
        private Label lbl_TitoloBottoniAlti;
        private TextBox txt_QuantitaProdotto;
        private TextBox txt_CostoProdotto;
        private TextBox txt_NomeProdotto;
        private Button btn_Rimuovi;
        private ListBox lst_ListaDellaSpesa;
    }
}
