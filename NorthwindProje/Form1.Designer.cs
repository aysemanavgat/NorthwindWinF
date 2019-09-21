namespace NorthwindProje
{
    partial class Form1
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
            this.gbkat = new System.Windows.Forms.GroupBox();
            this.lcat = new System.Windows.Forms.Label();
            this.cmkatlist = new System.Windows.Forms.ComboBox();
            this.gbsearch = new System.Windows.Forms.GroupBox();
            this.lsearch = new System.Windows.Forms.Label();
            this.dgProduct = new System.Windows.Forms.DataGridView();
            this.tproduct = new System.Windows.Forms.TextBox();
            this.gbkat.SuspendLayout();
            this.gbsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbkat
            // 
            this.gbkat.Controls.Add(this.cmkatlist);
            this.gbkat.Controls.Add(this.lcat);
            this.gbkat.Location = new System.Drawing.Point(12, 12);
            this.gbkat.Name = "gbkat";
            this.gbkat.Size = new System.Drawing.Size(568, 54);
            this.gbkat.TabIndex = 0;
            this.gbkat.TabStop = false;
            this.gbkat.Text = "Kategoriye Göre Listele";
            // 
            // lcat
            // 
            this.lcat.AutoSize = true;
            this.lcat.Location = new System.Drawing.Point(18, 20);
            this.lcat.Name = "lcat";
            this.lcat.Size = new System.Drawing.Size(46, 13);
            this.lcat.TabIndex = 0;
            this.lcat.Text = "Kategori";
            // 
            // cmkatlist
            // 
            this.cmkatlist.FormattingEnabled = true;
            this.cmkatlist.Location = new System.Drawing.Point(70, 17);
            this.cmkatlist.Name = "cmkatlist";
            this.cmkatlist.Size = new System.Drawing.Size(160, 21);
            this.cmkatlist.TabIndex = 1;
            this.cmkatlist.SelectedIndexChanged += new System.EventHandler(this.cmkatlist_SelectedIndexChanged);
            // 
            // gbsearch
            // 
            this.gbsearch.Controls.Add(this.tproduct);
            this.gbsearch.Controls.Add(this.lsearch);
            this.gbsearch.Location = new System.Drawing.Point(12, 72);
            this.gbsearch.Name = "gbsearch";
            this.gbsearch.Size = new System.Drawing.Size(568, 54);
            this.gbsearch.TabIndex = 1;
            this.gbsearch.TabStop = false;
            this.gbsearch.Text = "Ürün İsmine Göre Ara";
            // 
            // lsearch
            // 
            this.lsearch.AutoSize = true;
            this.lsearch.Location = new System.Drawing.Point(18, 20);
            this.lsearch.Name = "lsearch";
            this.lsearch.Size = new System.Drawing.Size(23, 13);
            this.lsearch.TabIndex = 0;
            this.lsearch.Text = "Ara";
            // 
            // dgProduct
            // 
            this.dgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduct.Location = new System.Drawing.Point(12, 132);
            this.dgProduct.Name = "dgProduct";
            this.dgProduct.Size = new System.Drawing.Size(543, 219);
            this.dgProduct.TabIndex = 2;
            // 
            // tproduct
            // 
            this.tproduct.Location = new System.Drawing.Point(70, 20);
            this.tproduct.Name = "tproduct";
            this.tproduct.Size = new System.Drawing.Size(160, 20);
            this.tproduct.TabIndex = 1;
            this.tproduct.TextChanged += new System.EventHandler(this.tproduct_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.dgProduct);
            this.Controls.Add(this.gbsearch);
            this.Controls.Add(this.gbkat);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbkat.ResumeLayout(false);
            this.gbkat.PerformLayout();
            this.gbsearch.ResumeLayout(false);
            this.gbsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbkat;
        private System.Windows.Forms.ComboBox cmkatlist;
        private System.Windows.Forms.Label lcat;
        private System.Windows.Forms.GroupBox gbsearch;
        private System.Windows.Forms.Label lsearch;
        private System.Windows.Forms.DataGridView dgProduct;
        private System.Windows.Forms.TextBox tproduct;
    }
}

