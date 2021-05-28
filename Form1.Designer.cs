namespace MovieDB
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label overviewLabel;
            System.Windows.Forms.Label releaseDateLabel;
            System.Windows.Forms.Label voteAverageLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label genreLabel;
            System.Windows.Forms.Label runtimeLabel;
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.movieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.movieDBDataSet = new MovieDB.movieDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.movieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.overviewTextBox = new System.Windows.Forms.TextBox();
            this.releaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.voteAverageTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.runtimeTextBox = new System.Windows.Forms.TextBox();
            this.characterText1 = new System.Windows.Forms.TextBox();
            this.nameText1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.goBackButtonAdmin = new System.Windows.Forms.Button();
            this.imgLocationTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.browseCast1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.browseCast2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.characterText2 = new System.Windows.Forms.TextBox();
            this.nameText2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.browseCast3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.characterText3 = new System.Windows.Forms.TextBox();
            this.nameText3 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.browseCast4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.characterText4 = new System.Windows.Forms.TextBox();
            this.nameText4 = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.browseCast5 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.characterText5 = new System.Windows.Forms.TextBox();
            this.nameText5 = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.movieTableAdapter = new MovieDB.movieDBDataSetTableAdapters.movieTableAdapter();
            this.tableAdapterManager = new MovieDB.movieDBDataSetTableAdapters.TableAdapterManager();
            this.label18 = new System.Windows.Forms.Label();
            this.idText1 = new System.Windows.Forms.TextBox();
            this.idText2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.idText3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.idText4 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.idText5 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            overviewLabel = new System.Windows.Forms.Label();
            releaseDateLabel = new System.Windows.Forms.Label();
            voteAverageLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            runtimeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).BeginInit();
            this.movieBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(27, 150);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(71, 26);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // overviewLabel
            // 
            overviewLabel.AutoSize = true;
            overviewLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            overviewLabel.Location = new System.Drawing.Point(27, 182);
            overviewLabel.Name = "overviewLabel";
            overviewLabel.Size = new System.Drawing.Size(124, 26);
            overviewLabel.TabIndex = 5;
            overviewLabel.Text = "Overview:";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            releaseDateLabel.Location = new System.Drawing.Point(28, 301);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(164, 26);
            releaseDateLabel.TabIndex = 7;
            releaseDateLabel.Text = "Release Date:";
            // 
            // voteAverageLabel
            // 
            voteAverageLabel.AutoSize = true;
            voteAverageLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            voteAverageLabel.Location = new System.Drawing.Point(28, 337);
            voteAverageLabel.Name = "voteAverageLabel";
            voteAverageLabel.Size = new System.Drawing.Size(172, 26);
            voteAverageLabel.TabIndex = 9;
            voteAverageLabel.Text = "Vote Average:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            imageLabel.Location = new System.Drawing.Point(29, 374);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(90, 26);
            imageLabel.TabIndex = 11;
            imageLabel.Text = "Image:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            genreLabel.Location = new System.Drawing.Point(30, 692);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(98, 26);
            genreLabel.TabIndex = 13;
            genreLabel.Text = "Genres:";
            // 
            // runtimeLabel
            // 
            runtimeLabel.AutoSize = true;
            runtimeLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            runtimeLabel.Location = new System.Drawing.Point(32, 729);
            runtimeLabel.Name = "runtimeLabel";
            runtimeLabel.Size = new System.Drawing.Size(118, 26);
            runtimeLabel.TabIndex = 15;
            runtimeLabel.Text = "Runtime:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            idLabel.Location = new System.Drawing.Point(29, 115);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(42, 26);
            idLabel.TabIndex = 64;
            idLabel.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 26);
            this.label3.TabIndex = 31;
            this.label3.Text = "Character:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 26);
            this.label4.TabIndex = 32;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            this.label5.Location = new System.Drawing.Point(494, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "Image:";
            // 
            // movieBindingNavigator
            // 
            this.movieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.movieBindingNavigator.BindingSource = this.movieBindingSource;
            this.movieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.movieBindingNavigator.DeleteItem = null;
            this.movieBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.movieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.movieBindingNavigatorSaveItem});
            this.movieBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.movieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.movieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.movieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.movieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.movieBindingNavigator.Name = "movieBindingNavigator";
            this.movieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.movieBindingNavigator.Size = new System.Drawing.Size(886, 31);
            this.movieBindingNavigator.TabIndex = 0;
            this.movieBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "movie";
            this.movieBindingSource.DataSource = this.movieDBDataSet;
            // 
            // movieDBDataSet
            // 
            this.movieDBDataSet.DataSetName = "movieDBDataSet";
            this.movieDBDataSet.Locale = new System.Globalization.CultureInfo("ru-RU");
            this.movieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // movieBindingNavigatorSaveItem
            // 
            this.movieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.movieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("movieBindingNavigatorSaveItem.Image")));
            this.movieBindingNavigatorSaveItem.Name = "movieBindingNavigatorSaveItem";
            this.movieBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.movieBindingNavigatorSaveItem.Text = "Save Data";
            this.movieBindingNavigatorSaveItem.Click += new System.EventHandler(this.movieBindingNavigatorSaveItem_Click_1);
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "title", true));
            this.titleTextBox.Location = new System.Drawing.Point(198, 147);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(267, 26);
            this.titleTextBox.TabIndex = 4;
            // 
            // overviewTextBox
            // 
            this.overviewTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "overview", true));
            this.overviewTextBox.Location = new System.Drawing.Point(198, 179);
            this.overviewTextBox.Multiline = true;
            this.overviewTextBox.Name = "overviewTextBox";
            this.overviewTextBox.Size = new System.Drawing.Size(267, 107);
            this.overviewTextBox.TabIndex = 6;
            // 
            // releaseDateDateTimePicker
            // 
            this.releaseDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.movieBindingSource, "releaseDate", true));
            this.releaseDateDateTimePicker.Location = new System.Drawing.Point(198, 301);
            this.releaseDateDateTimePicker.Name = "releaseDateDateTimePicker";
            this.releaseDateDateTimePicker.Size = new System.Drawing.Size(267, 26);
            this.releaseDateDateTimePicker.TabIndex = 8;
            // 
            // voteAverageTextBox
            // 
            this.voteAverageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "voteAverage", true));
            this.voteAverageTextBox.Location = new System.Drawing.Point(198, 337);
            this.voteAverageTextBox.Name = "voteAverageTextBox";
            this.voteAverageTextBox.Size = new System.Drawing.Size(267, 26);
            this.voteAverageTextBox.TabIndex = 10;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.movieBindingSource, "image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(198, 374);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(267, 268);
            this.imagePictureBox.TabIndex = 12;
            this.imagePictureBox.TabStop = false;
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(198, 692);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(267, 26);
            this.genreTextBox.TabIndex = 14;
            // 
            // runtimeTextBox
            // 
            this.runtimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "runtime", true));
            this.runtimeTextBox.Location = new System.Drawing.Point(198, 729);
            this.runtimeTextBox.Name = "runtimeTextBox";
            this.runtimeTextBox.Size = new System.Drawing.Size(267, 26);
            this.runtimeTextBox.TabIndex = 16;
            // 
            // characterText1
            // 
            this.characterText1.Location = new System.Drawing.Point(643, 147);
            this.characterText1.Name = "characterText1";
            this.characterText1.Size = new System.Drawing.Size(109, 26);
            this.characterText1.TabIndex = 20;
            // 
            // nameText1
            // 
            this.nameText1.Location = new System.Drawing.Point(643, 179);
            this.nameText1.Name = "nameText1";
            this.nameText1.Size = new System.Drawing.Size(109, 26);
            this.nameText1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Movie Information:";
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8F);
            this.browseButton.Location = new System.Drawing.Point(350, 648);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(115, 32);
            this.browseButton.TabIndex = 26;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // goBackButtonAdmin
            // 
            this.goBackButtonAdmin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.goBackButtonAdmin.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8F);
            this.goBackButtonAdmin.Location = new System.Drawing.Point(31, 34);
            this.goBackButtonAdmin.Name = "goBackButtonAdmin";
            this.goBackButtonAdmin.Size = new System.Drawing.Size(108, 35);
            this.goBackButtonAdmin.TabIndex = 28;
            this.goBackButtonAdmin.Text = "Go Back";
            this.goBackButtonAdmin.UseVisualStyleBackColor = false;
            this.goBackButtonAdmin.Click += new System.EventHandler(this.goBackButtonAdmin_Click);
            // 
            // imgLocationTextBox
            // 
            this.imgLocationTextBox.Location = new System.Drawing.Point(198, 648);
            this.imgLocationTextBox.Name = "imgLocationTextBox";
            this.imgLocationTextBox.Size = new System.Drawing.Size(146, 26);
            this.imgLocationTextBox.TabIndex = 29;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 31);
            this.label2.TabIndex = 30;
            this.label2.Text = "Casts Information:";
            // 
            // browseCast1
            // 
            this.browseCast1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8F);
            this.browseCast1.Location = new System.Drawing.Point(643, 211);
            this.browseCast1.Name = "browseCast1";
            this.browseCast1.Size = new System.Drawing.Size(109, 32);
            this.browseCast1.TabIndex = 35;
            this.browseCast1.Text = "Browse...";
            this.browseCast1.UseVisualStyleBackColor = true;
            this.browseCast1.Click += new System.EventHandler(this.browseCast_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(758, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(758, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // browseCast2
            // 
            this.browseCast2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8F);
            this.browseCast2.Location = new System.Drawing.Point(643, 351);
            this.browseCast2.Name = "browseCast2";
            this.browseCast2.Size = new System.Drawing.Size(109, 32);
            this.browseCast2.TabIndex = 42;
            this.browseCast2.Text = "Browse...";
            this.browseCast2.UseVisualStyleBackColor = true;
            this.browseCast2.Click += new System.EventHandler(this.browseCast_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            this.label6.Location = new System.Drawing.Point(494, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 26);
            this.label6.TabIndex = 41;
            this.label6.Text = "Image:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(494, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 26);
            this.label7.TabIndex = 40;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(494, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 26);
            this.label8.TabIndex = 39;
            this.label8.Text = "Character:";
            // 
            // characterText2
            // 
            this.characterText2.Location = new System.Drawing.Point(643, 287);
            this.characterText2.Name = "characterText2";
            this.characterText2.Size = new System.Drawing.Size(109, 26);
            this.characterText2.TabIndex = 37;
            // 
            // nameText2
            // 
            this.nameText2.Location = new System.Drawing.Point(643, 319);
            this.nameText2.Name = "nameText2";
            this.nameText2.Size = new System.Drawing.Size(109, 26);
            this.nameText2.TabIndex = 38;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(758, 399);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(105, 128);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // browseCast3
            // 
            this.browseCast3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8F);
            this.browseCast3.Location = new System.Drawing.Point(643, 495);
            this.browseCast3.Name = "browseCast3";
            this.browseCast3.Size = new System.Drawing.Size(109, 32);
            this.browseCast3.TabIndex = 49;
            this.browseCast3.Text = "Browse...";
            this.browseCast3.UseVisualStyleBackColor = true;
            this.browseCast3.Click += new System.EventHandler(this.browseCast_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            this.label9.Location = new System.Drawing.Point(494, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 26);
            this.label9.TabIndex = 48;
            this.label9.Text = "Image:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(494, 463);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 26);
            this.label10.TabIndex = 47;
            this.label10.Text = "Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(494, 434);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 26);
            this.label11.TabIndex = 46;
            this.label11.Text = "Character:";
            // 
            // characterText3
            // 
            this.characterText3.Location = new System.Drawing.Point(643, 431);
            this.characterText3.Name = "characterText3";
            this.characterText3.Size = new System.Drawing.Size(109, 26);
            this.characterText3.TabIndex = 44;
            // 
            // nameText3
            // 
            this.nameText3.Location = new System.Drawing.Point(643, 463);
            this.nameText3.Name = "nameText3";
            this.nameText3.Size = new System.Drawing.Size(109, 26);
            this.nameText3.TabIndex = 45;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(758, 542);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(105, 128);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 57;
            this.pictureBox4.TabStop = false;
            // 
            // browseCast4
            // 
            this.browseCast4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8F);
            this.browseCast4.Location = new System.Drawing.Point(643, 638);
            this.browseCast4.Name = "browseCast4";
            this.browseCast4.Size = new System.Drawing.Size(109, 32);
            this.browseCast4.TabIndex = 56;
            this.browseCast4.Text = "Browse...";
            this.browseCast4.UseVisualStyleBackColor = true;
            this.browseCast4.Click += new System.EventHandler(this.browseCast_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            this.label12.Location = new System.Drawing.Point(494, 638);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 26);
            this.label12.TabIndex = 55;
            this.label12.Text = "Image:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(494, 606);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 26);
            this.label13.TabIndex = 54;
            this.label13.Text = "Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(494, 577);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 26);
            this.label14.TabIndex = 53;
            this.label14.Text = "Character:";
            // 
            // characterText4
            // 
            this.characterText4.Location = new System.Drawing.Point(643, 574);
            this.characterText4.Name = "characterText4";
            this.characterText4.Size = new System.Drawing.Size(109, 26);
            this.characterText4.TabIndex = 51;
            // 
            // nameText4
            // 
            this.nameText4.Location = new System.Drawing.Point(643, 606);
            this.nameText4.Name = "nameText4";
            this.nameText4.Size = new System.Drawing.Size(109, 26);
            this.nameText4.TabIndex = 52;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(758, 686);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(105, 128);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 64;
            this.pictureBox5.TabStop = false;
            // 
            // browseCast5
            // 
            this.browseCast5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8F);
            this.browseCast5.Location = new System.Drawing.Point(643, 782);
            this.browseCast5.Name = "browseCast5";
            this.browseCast5.Size = new System.Drawing.Size(109, 32);
            this.browseCast5.TabIndex = 63;
            this.browseCast5.Text = "Browse...";
            this.browseCast5.UseVisualStyleBackColor = true;
            this.browseCast5.Click += new System.EventHandler(this.browseCast_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F);
            this.label15.Location = new System.Drawing.Point(494, 782);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 26);
            this.label15.TabIndex = 62;
            this.label15.Text = "Image:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(494, 750);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 26);
            this.label16.TabIndex = 61;
            this.label16.Text = "Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(494, 721);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 26);
            this.label17.TabIndex = 60;
            this.label17.Text = "Character:";
            // 
            // characterText5
            // 
            this.characterText5.Location = new System.Drawing.Point(643, 718);
            this.characterText5.Name = "characterText5";
            this.characterText5.Size = new System.Drawing.Size(109, 26);
            this.characterText5.TabIndex = 58;
            // 
            // nameText5
            // 
            this.nameText5.Location = new System.Drawing.Point(643, 750);
            this.nameText5.Name = "nameText5";
            this.nameText5.Size = new System.Drawing.Size(109, 26);
            this.nameText5.TabIndex = 59;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(198, 115);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(267, 26);
            this.idTextBox.TabIndex = 65;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.castTableAdapter = null;
            this.tableAdapterManager.movieCastTableAdapter = null;
            this.tableAdapterManager.movieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.UpdateOrder = MovieDB.movieDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(494, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 26);
            this.label18.TabIndex = 66;
            this.label18.Text = "Id:";
            // 
            // idText1
            // 
            this.idText1.Location = new System.Drawing.Point(643, 115);
            this.idText1.Name = "idText1";
            this.idText1.Size = new System.Drawing.Size(109, 26);
            this.idText1.TabIndex = 67;
            // 
            // idText2
            // 
            this.idText2.Location = new System.Drawing.Point(643, 255);
            this.idText2.Name = "idText2";
            this.idText2.Size = new System.Drawing.Size(109, 26);
            this.idText2.TabIndex = 69;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(494, 255);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 26);
            this.label19.TabIndex = 68;
            this.label19.Text = "Id:";
            // 
            // idText3
            // 
            this.idText3.Location = new System.Drawing.Point(643, 399);
            this.idText3.Name = "idText3";
            this.idText3.Size = new System.Drawing.Size(109, 26);
            this.idText3.TabIndex = 71;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(494, 399);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 26);
            this.label20.TabIndex = 70;
            this.label20.Text = "Id:";
            // 
            // idText4
            // 
            this.idText4.Location = new System.Drawing.Point(643, 542);
            this.idText4.Name = "idText4";
            this.idText4.Size = new System.Drawing.Size(109, 26);
            this.idText4.TabIndex = 73;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(494, 542);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(42, 26);
            this.label21.TabIndex = 72;
            this.label21.Text = "Id:";
            // 
            // idText5
            // 
            this.idText5.Location = new System.Drawing.Point(643, 686);
            this.idText5.Name = "idText5";
            this.idText5.Size = new System.Drawing.Size(109, 26);
            this.idText5.TabIndex = 75;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(494, 686);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(42, 26);
            this.label22.TabIndex = 74;
            this.label22.Text = "Id:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(886, 826);
            this.Controls.Add(this.idText5);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.idText4);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.idText3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.idText2);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.idText1);
            this.Controls.Add(this.label18);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.browseCast5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.characterText5);
            this.Controls.Add(this.nameText5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.browseCast4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.characterText4);
            this.Controls.Add(this.nameText4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.browseCast3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.characterText3);
            this.Controls.Add(this.nameText3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.browseCast2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.characterText2);
            this.Controls.Add(this.nameText2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.browseCast1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgLocationTextBox);
            this.Controls.Add(this.goBackButtonAdmin);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.characterText1);
            this.Controls.Add(this.nameText1);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(overviewLabel);
            this.Controls.Add(this.overviewTextBox);
            this.Controls.Add(releaseDateLabel);
            this.Controls.Add(this.releaseDateDateTimePicker);
            this.Controls.Add(voteAverageLabel);
            this.Controls.Add(this.voteAverageTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(runtimeLabel);
            this.Controls.Add(this.runtimeTextBox);
            this.Controls.Add(this.movieBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Admin Panel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).EndInit();
            this.movieBindingNavigator.ResumeLayout(false);
            this.movieBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private movieDBDataSet movieDBDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private movieDBDataSetTableAdapters.movieTableAdapter movieTableAdapter;
        private movieDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator movieBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton movieBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox overviewTextBox;
        private System.Windows.Forms.DateTimePicker releaseDateDateTimePicker;
        private System.Windows.Forms.TextBox voteAverageTextBox;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox runtimeTextBox;
        private System.Windows.Forms.TextBox characterText1;
        private System.Windows.Forms.TextBox nameText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button goBackButtonAdmin;
        private System.Windows.Forms.TextBox imgLocationTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseCast1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button browseCast2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox characterText2;
        private System.Windows.Forms.TextBox nameText2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button browseCast3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox characterText3;
        private System.Windows.Forms.TextBox nameText3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button browseCast4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox characterText4;
        private System.Windows.Forms.TextBox nameText4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button browseCast5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox characterText5;
        private System.Windows.Forms.TextBox nameText5;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox idText1;
        private System.Windows.Forms.TextBox idText2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox idText3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox idText4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox idText5;
        private System.Windows.Forms.Label label22;
    }
}