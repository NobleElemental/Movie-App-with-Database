namespace Movie
{
    partial class Users
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label releaseDateLabel;
            System.Windows.Forms.Label soldLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label ratingLabel;
            System.Windows.Forms.Label picture_PathLabel;
            this.database1DataSet = new Movie.Database1DataSet();
            this.movieTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieTTableAdapter = new Movie.Database1DataSetTableAdapters.MovieTTableAdapter();
            this.tableAdapterManager = new Movie.Database1DataSetTableAdapters.TableAdapterManager();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.soldTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.picture_PathTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.releaseDateTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            releaseDateLabel = new System.Windows.Forms.Label();
            soldLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ratingLabel = new System.Windows.Forms.Label();
            picture_PathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieTBindingSource
            // 
            this.movieTBindingSource.DataMember = "MovieT";
            this.movieTBindingSource.DataSource = this.database1DataSet;
            // 
            // movieTTableAdapter
            // 
            this.movieTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MovieTTableAdapter = this.movieTTableAdapter;
            this.tableAdapterManager.UpdateOrder = Movie.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(102, 29);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(183, 26);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(102, 55);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(39, 13);
            genreLabel.TabIndex = 3;
            genreLabel.Text = "Genre:";
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "Genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(183, 52);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.ReadOnly = true;
            this.genreTextBox.Size = new System.Drawing.Size(200, 20);
            this.genreTextBox.TabIndex = 4;
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(102, 82);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(75, 13);
            releaseDateLabel.TabIndex = 5;
            releaseDateLabel.Text = "Release Date:";
            // 
            // soldLabel
            // 
            soldLabel.AutoSize = true;
            soldLabel.Location = new System.Drawing.Point(102, 107);
            soldLabel.Name = "soldLabel";
            soldLabel.Size = new System.Drawing.Size(31, 13);
            soldLabel.TabIndex = 7;
            soldLabel.Text = "Sold:";
            // 
            // soldTextBox
            // 
            this.soldTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "Sold", true));
            this.soldTextBox.Location = new System.Drawing.Point(183, 104);
            this.soldTextBox.Name = "soldTextBox";
            this.soldTextBox.ReadOnly = true;
            this.soldTextBox.Size = new System.Drawing.Size(200, 20);
            this.soldTextBox.TabIndex = 8;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(102, 133);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 9;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(183, 130);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(200, 20);
            this.titleTextBox.TabIndex = 10;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(102, 159);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(183, 156);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(102, 185);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(41, 13);
            ratingLabel.TabIndex = 13;
            ratingLabel.Text = "Rating:";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(183, 182);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.ReadOnly = true;
            this.ratingTextBox.Size = new System.Drawing.Size(200, 20);
            this.ratingTextBox.TabIndex = 14;
            // 
            // picture_PathLabel
            // 
            picture_PathLabel.AutoSize = true;
            picture_PathLabel.Location = new System.Drawing.Point(102, 211);
            picture_PathLabel.Name = "picture_PathLabel";
            picture_PathLabel.Size = new System.Drawing.Size(68, 13);
            picture_PathLabel.TabIndex = 15;
            picture_PathLabel.Text = "Picture Path:";
            // 
            // picture_PathTextBox
            // 
            this.picture_PathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "Picture Path", true));
            this.picture_PathTextBox.Location = new System.Drawing.Point(183, 208);
            this.picture_PathTextBox.Name = "picture_PathTextBox";
            this.picture_PathTextBox.ReadOnly = true;
            this.picture_PathTextBox.Size = new System.Drawing.Size(200, 20);
            this.picture_PathTextBox.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // releaseDateTextBox
            // 
            this.releaseDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "ReleaseDate", true));
            this.releaseDateTextBox.Location = new System.Drawing.Point(183, 78);
            this.releaseDateTextBox.Name = "releaseDateTextBox";
            this.releaseDateTextBox.ReadOnly = true;
            this.releaseDateTextBox.Size = new System.Drawing.Size(200, 20);
            this.releaseDateTextBox.TabIndex = 21;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 343);
            this.Controls.Add(this.releaseDateTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(releaseDateLabel);
            this.Controls.Add(soldLabel);
            this.Controls.Add(this.soldTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(ratingLabel);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(picture_PathLabel);
            this.Controls.Add(this.picture_PathTextBox);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource movieTBindingSource;
        private Database1DataSetTableAdapters.MovieTTableAdapter movieTTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox soldTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox picture_PathTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox releaseDateTextBox;
    }
}