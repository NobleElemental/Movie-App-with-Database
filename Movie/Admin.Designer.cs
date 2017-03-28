namespace Movie
{
    partial class Admin
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
            this.releaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.soldTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.picture_PathTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.releaseDateTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            iDLabel.Location = new System.Drawing.Point(23, 68);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(104, 65);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.ReadOnly = true;
            this.iDTextBox.Size = new System.Drawing.Size(200, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(23, 94);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(39, 13);
            genreLabel.TabIndex = 3;
            genreLabel.Text = "Genre:";
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "Genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(104, 91);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.ReadOnly = true;
            this.genreTextBox.Size = new System.Drawing.Size(200, 20);
            this.genreTextBox.TabIndex = 4;
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(23, 121);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(75, 13);
            releaseDateLabel.TabIndex = 5;
            releaseDateLabel.Text = "Release Date:";
            // 
            // releaseDateDateTimePicker
            // 
            this.releaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.movieTBindingSource, "ReleaseDate", true));
            this.releaseDateDateTimePicker.Location = new System.Drawing.Point(104, 117);
            this.releaseDateDateTimePicker.Name = "releaseDateDateTimePicker";
            this.releaseDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.releaseDateDateTimePicker.TabIndex = 6;
            // 
            // soldLabel
            // 
            soldLabel.AutoSize = true;
            soldLabel.Location = new System.Drawing.Point(23, 146);
            soldLabel.Name = "soldLabel";
            soldLabel.Size = new System.Drawing.Size(31, 13);
            soldLabel.TabIndex = 7;
            soldLabel.Text = "Sold:";
            // 
            // soldTextBox
            // 
            this.soldTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "Sold", true));
            this.soldTextBox.Location = new System.Drawing.Point(104, 143);
            this.soldTextBox.Name = "soldTextBox";
            this.soldTextBox.ReadOnly = true;
            this.soldTextBox.Size = new System.Drawing.Size(200, 20);
            this.soldTextBox.TabIndex = 8;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(23, 172);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 9;
            titleLabel.Text = "Title:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(104, 169);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(200, 20);
            this.titleTextBox.TabIndex = 10;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(23, 198);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(104, 195);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // ratingLabel
            // 
            ratingLabel.AutoSize = true;
            ratingLabel.Location = new System.Drawing.Point(23, 224);
            ratingLabel.Name = "ratingLabel";
            ratingLabel.Size = new System.Drawing.Size(41, 13);
            ratingLabel.TabIndex = 13;
            ratingLabel.Text = "Rating:";
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "Rating", true));
            this.ratingTextBox.Location = new System.Drawing.Point(104, 221);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.ReadOnly = true;
            this.ratingTextBox.Size = new System.Drawing.Size(200, 20);
            this.ratingTextBox.TabIndex = 14;
            // 
            // picture_PathLabel
            // 
            picture_PathLabel.AutoSize = true;
            picture_PathLabel.Location = new System.Drawing.Point(23, 250);
            picture_PathLabel.Name = "picture_PathLabel";
            picture_PathLabel.Size = new System.Drawing.Size(68, 13);
            picture_PathLabel.TabIndex = 15;
            picture_PathLabel.Text = "Picture Path:";
            // 
            // picture_PathTextBox
            // 
            this.picture_PathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "Picture Path", true));
            this.picture_PathTextBox.Location = new System.Drawing.Point(104, 247);
            this.picture_PathTextBox.Name = "picture_PathTextBox";
            this.picture_PathTextBox.ReadOnly = true;
            this.picture_PathTextBox.Size = new System.Drawing.Size(200, 20);
            this.picture_PathTextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Previous";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(434, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // releaseDateTextBox
            // 
            this.releaseDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieTBindingSource, "ReleaseDate", true));
            this.releaseDateTextBox.Location = new System.Drawing.Point(104, 117);
            this.releaseDateTextBox.Name = "releaseDateTextBox";
            this.releaseDateTextBox.ReadOnly = true;
            this.releaseDateTextBox.Size = new System.Drawing.Size(200, 20);
            this.releaseDateTextBox.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(434, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(353, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 22;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(493, 198);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 201);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Genre:";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.releaseDateTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(releaseDateLabel);
            this.Controls.Add(this.releaseDateDateTimePicker);
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
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
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
        private System.Windows.Forms.DateTimePicker releaseDateDateTimePicker;
        private System.Windows.Forms.TextBox soldTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.TextBox picture_PathTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox releaseDateTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}