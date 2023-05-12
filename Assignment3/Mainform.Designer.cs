namespace Assignment3
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            this.btnGetInformation = new System.Windows.Forms.Button();
            this.btnInsertData = new System.Windows.Forms.Button();
            this.mySmallListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cardDataSet = new Assignment3.CardDataSet();
            this.cardDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtboxShow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetInformation
            // 
            this.btnGetInformation.Location = new System.Drawing.Point(32, 43);
            this.btnGetInformation.Name = "btnGetInformation";
            this.btnGetInformation.Size = new System.Drawing.Size(194, 39);
            this.btnGetInformation.TabIndex = 0;
            this.btnGetInformation.Text = "Get Infromation";
            this.btnGetInformation.UseVisualStyleBackColor = true;
            this.btnGetInformation.Click += new System.EventHandler(this.btnGetInformation_Click);
            // 
            // btnInsertData
            // 
            this.btnInsertData.Location = new System.Drawing.Point(32, 102);
            this.btnInsertData.Name = "btnInsertData";
            this.btnInsertData.Size = new System.Drawing.Size(194, 39);
            this.btnInsertData.TabIndex = 1;
            this.btnInsertData.Text = " Insert More Data";
            this.btnInsertData.UseVisualStyleBackColor = true;
            this.btnInsertData.Click += new System.EventHandler(this.btnInsertData_Click);
            // 
            // mySmallListView
            // 
            this.mySmallListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.mySmallListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.mySmallListView.FullRowSelect = true;
            this.mySmallListView.GridLines = true;
            this.mySmallListView.HideSelection = false;
            this.mySmallListView.Location = new System.Drawing.Point(303, 43);
            this.mySmallListView.Name = "mySmallListView";
            this.mySmallListView.Size = new System.Drawing.Size(476, 132);
            this.mySmallListView.TabIndex = 4;
            this.mySmallListView.UseCompatibleStateImageBehavior = false;
            this.mySmallListView.View = System.Windows.Forms.View.Details;
            this.mySmallListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mySmallListView_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PlayerName";
            this.columnHeader2.Width = 99;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Team";
            // 
            // cardDataSet
            // 
            this.cardDataSet.DataSetName = "CardDataSet";
            this.cardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardDataSetBindingSource
            // 
            this.cardDataSetBindingSource.DataSource = this.cardDataSet;
            this.cardDataSetBindingSource.Position = 0;
            // 
            // cardDataSetBindingSource1
            // 
            this.cardDataSetBindingSource1.DataSource = this.cardDataSet;
            this.cardDataSetBindingSource1.Position = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(441, 222);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(249, 200);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // txtboxShow
            // 
            this.txtboxShow.Location = new System.Drawing.Point(12, 222);
            this.txtboxShow.Multiline = true;
            this.txtboxShow.Name = "txtboxShow";
            this.txtboxShow.Size = new System.Drawing.Size(386, 200);
            this.txtboxShow.TabIndex = 8;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxShow);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.mySmallListView);
            this.Controls.Add(this.btnInsertData);
            this.Controls.Add(this.btnGetInformation);
            this.Name = "Mainform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetInformation;
        private System.Windows.Forms.Button btnInsertData;
        private System.Windows.Forms.ListView mySmallListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private CardDataSet cardDataSet;
        private System.Windows.Forms.BindingSource cardDataSetBindingSource;
        private System.Windows.Forms.BindingSource cardDataSetBindingSource1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtboxShow;
    }
}

