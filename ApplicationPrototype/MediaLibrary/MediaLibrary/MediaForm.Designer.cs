namespace MediaLibrary
{
    partial class MediaForm
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbudget = new System.Windows.Forms.TextBox();
            this.txtgenre = new System.Windows.Forms.TextBox();
            this.btnbudget = new System.Windows.Forms.Button();
            this.btngenre = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btnpublishyear = new System.Windows.Forms.Button();
            this.txtpublishyear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(578, 92);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1048, 504);
            this.dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By Budget";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search By Genre";
            // 
            // txtbudget
            // 
            this.txtbudget.Location = new System.Drawing.Point(40, 137);
            this.txtbudget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbudget.Name = "txtbudget";
            this.txtbudget.Size = new System.Drawing.Size(370, 31);
            this.txtbudget.TabIndex = 3;
            this.txtbudget.TextChanged += new System.EventHandler(this.txtpublishyear_TextChanged);
            // 
            // txtgenre
            // 
            this.txtgenre.Location = new System.Drawing.Point(40, 262);
            this.txtgenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtgenre.Name = "txtgenre";
            this.txtgenre.Size = new System.Drawing.Size(370, 31);
            this.txtgenre.TabIndex = 4;
            // 
            // btnbudget
            // 
            this.btnbudget.Location = new System.Drawing.Point(446, 137);
            this.btnbudget.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnbudget.Name = "btnbudget";
            this.btnbudget.Size = new System.Drawing.Size(112, 37);
            this.btnbudget.TabIndex = 5;
            this.btnbudget.Text = "Search";
            this.btnbudget.UseVisualStyleBackColor = true;
            this.btnbudget.Click += new System.EventHandler(this.btnbudget_Click);
            // 
            // btngenre
            // 
            this.btngenre.Location = new System.Drawing.Point(446, 262);
            this.btngenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btngenre.Name = "btngenre";
            this.btngenre.Size = new System.Drawing.Size(112, 37);
            this.btngenre.TabIndex = 6;
            this.btngenre.Text = "Search";
            this.btngenre.UseVisualStyleBackColor = true;
            this.btngenre.Click += new System.EventHandler(this.btngenre_Click);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(886, 615);
            this.btnload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(372, 67);
            this.btnload.TabIndex = 7;
            this.btnload.Text = "Load Data";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnpublishyear
            // 
            this.btnpublishyear.Location = new System.Drawing.Point(448, 383);
            this.btnpublishyear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpublishyear.Name = "btnpublishyear";
            this.btnpublishyear.Size = new System.Drawing.Size(112, 37);
            this.btnpublishyear.TabIndex = 10;
            this.btnpublishyear.Text = "Search";
            this.btnpublishyear.UseVisualStyleBackColor = true;
            this.btnpublishyear.Click += new System.EventHandler(this.btnpublishyear_Click);
            // 
            // txtpublishyear
            // 
            this.txtpublishyear.Location = new System.Drawing.Point(42, 383);
            this.txtpublishyear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpublishyear.Name = "txtpublishyear";
            this.txtpublishyear.Size = new System.Drawing.Size(370, 31);
            this.txtpublishyear.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 350);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search By Publish Year";
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(1474, 23);
            this.btnclose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(150, 44);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1648, 704);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnpublishyear);
            this.Controls.Add(this.txtpublishyear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btngenre);
            this.Controls.Add(this.btnbudget);
            this.Controls.Add(this.txtgenre);
            this.Controls.Add(this.txtbudget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MediaForm";
            this.Text = "MediaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbudget;
        private System.Windows.Forms.TextBox txtgenre;
        private System.Windows.Forms.Button btnbudget;
        private System.Windows.Forms.Button btngenre;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btnpublishyear;
        private System.Windows.Forms.TextBox txtpublishyear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclose;
    }
}