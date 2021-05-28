using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class Form1 : Form
    {
        private MainWindow mainWindow;
        private DBController dbController;
        private FileInfo fi;
        List<MovieConnector.Cast> casts = new List<MovieConnector.Cast>();
        int addOrEdit = 0;
        public Form1()
        {
            InitializeComponent();
            mainWindow = new MainWindow();
            dbController = mainWindow.DbController;
        }
        
        private int updateOrInsertCasts(int addOrEdit2)
        {
            int error = 0;
            int movieId = 0;
            try
            {
                movieId = Int32.Parse(idTextBox.Text);
            }
            catch (Exception a)
            {
                MessageBox.Show("Id should be numeric for movie.");
                return 1;
            }
            for (int i = 0; i < 5;)
            {
                i++;
                string character = "", name = "";
                int castId = 0;
                byte[] image = null;
                if (this.Controls.ContainsKey("idText" + i.ToString()))
                {
                    TextBox idText = this.Controls["idText" + i.ToString()] as TextBox;
                    if (idText != null)
                    {
                        try
                        {
                            if (idText.Text != "")
                                castId = Int32.Parse(idText.Text);
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("Id should be numeric for cast " + i);
                            error = 1;
                        }
                    }
                }
                if (this.Controls.ContainsKey("characterText" + i.ToString()))
                {
                    TextBox characterText = this.Controls["characterText" + i.ToString()] as TextBox;
                    if (characterText != null)
                    {
                        character = characterText.Text;
                    }
                }
                if (this.Controls.ContainsKey("nameText" + i.ToString()))
                {
                    TextBox nameText = this.Controls["nameText" + i.ToString()] as TextBox;
                    if (nameText != null)
                    {
                        name = nameText.Text;
                    }
                }
                if (this.Controls.ContainsKey("pictureBox" + i.ToString()))
                {
                    PictureBox pictureBox = this.Controls["pictureBox" + i.ToString()] as PictureBox;
                    if (pictureBox != null)
                    {
                        MemoryStream ms = new MemoryStream();
                        if (pictureBox.Image != null)
                        {
                            pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            image = ms.GetBuffer();
                        }
                    }
                }
                if (castId != 0)
                {
                    if (character.Length > 0 && name.Length > 0 && image != null)
                    {
                        bool checkInDatabase = dbController.checkIfCastInDatabase(castId);
                        if (addOrEdit2 == 1)
                        {
                            if (checkInDatabase)
                            {
                                MessageBox.Show("Cast " + i + " with this Id is already exist");
                                error = 1;
                            }
                            else
                            {
                                dbController.insertToCast(castId, character, name, image);
                                dbController.insertCastToMovie(movieId, castId);
                            }
                        }
                        else if (addOrEdit2 == 0)
                        {
                            if (checkInDatabase)
                            {
                                dbController.updateCast(castId, character, name, image);
                            }
                            else
                            {
                                dbController.insertToCast(castId, character, name, image);
                                dbController.insertCastToMovie(movieId, castId);
                            }
                        }
                        
                    }
                }
            }
            return error;
        }

        private void movieBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            int error = 0;
            if (validateAllFields())
            {
                MessageBox.Show("Please fill all fields for movie information.");
                return;
            }
            if (addOrEdit == 0)
            {
                error = updateOrInsertCasts(addOrEdit);
            }
            else if (addOrEdit == 1)
            {
                int movieId = 0;
                try
                {
                    movieId = Int32.Parse(idTextBox.Text);
                }
                catch (Exception a)
                {
                    MessageBox.Show("Id should be numeric for movie.");
                    error = 1;
                }
                if (dbController.checkIfMovieInDatabase(movieId))
                {
                    MessageBox.Show("Movie with the same ID already exists.");
                    error = 1;
                }
                else
                {
                    error = updateOrInsertCasts(addOrEdit);
                    addOrEdit = 0;
                    idTextBox.ReadOnly = true;
                }
            }
            if (error == 0)
            {
                this.Validate();
                this.movieBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.movieDBDataSet);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            // TODO: This line of code loads data into the 'movieDBDataSet.movie' table. You can move, or remove it, as needed.
            this.movieTableAdapter.Fill(this.movieDBDataSet.movie);
            fillCastsAdmin();
        }

        private void goBackButtonAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            this.mainWindow.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainWindow.Show();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            try {
                browseImage();
                imgLocationTextBox.Text = openFileDialog1.FileName;
                imagePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception w) { }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure you wanna delete?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    this.movieBindingSource.RemoveCurrent();
                    this.Validate();
                    this.movieBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.movieDBDataSet);
                    fillCastsAdmin();
                }
                catch (Exception q)
                {
                    MessageBox.Show("No movie to delete.");
                }
            }       
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            fillCastsAdmin();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            fillCastsAdmin();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            fillCastsAdmin();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            fillCastsAdmin();
        }

        private void browseCast_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try {
                switch (btn.Name)
                {
                    case "browseCast1":
                        browseImage();
                        pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                        break;
                    case "browseCast2":
                        browseImage();
                        pictureBox2.Image = Image.FromFile(openFileDialog1.FileName);
                        break;
                    case "browseCast3":
                        browseImage();
                        pictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
                        break;
                    case "browseCast4":
                        browseImage();
                        pictureBox4.Image = Image.FromFile(openFileDialog1.FileName);
                        break;
                    case "browseCast5":
                        browseImage();
                        pictureBox5.Image = Image.FromFile(openFileDialog1.FileName);
                        break;
                }
            }
            catch (Exception er)
            {

            }
        }

        private void setAllCastsForMovie()
        {
            try {
                casts = dbController.getAllCastsForMovie(Int32.Parse(((DataRowView)movieBindingSource.Current).Row["id"].ToString()));
            }
            catch (Exception t)
            {}
        }

        private void fillCastsAdmin()
        {
            setAllCastsForMovie();
            if (casts.Count == 0)
            {
                clearAllCasts(0, 5);
                return;
            }
            int j = casts.Count;
            for (int i = 0; i < casts.Count;)
            {
                MovieConnector.Cast cast = casts[i++];
                if (this.Controls.ContainsKey("idText" + i.ToString()))
                {
                    TextBox idText = this.Controls["idText" + i.ToString()] as TextBox;
                    if (idText != null)
                    {
                        idText.Text = cast.Id.ToString();
                    }
                }
                if (this.Controls.ContainsKey("characterText" + i.ToString()))
                {
                    TextBox characterText = this.Controls["characterText" + i.ToString()] as TextBox;
                    if (characterText != null)
                    {
                        characterText.Text = cast.Character;
                    }
                }
                if (this.Controls.ContainsKey("nameText" + i.ToString()))
                {
                    TextBox nameText = this.Controls["nameText" + i.ToString()] as TextBox;
                    if (nameText != null)
                    {
                        nameText.Text = cast.Name;
                    }
                }
                if (this.Controls.ContainsKey("pictureBox" + i.ToString()))
                {
                    PictureBox pictureBox = this.Controls["pictureBox" + i.ToString()] as PictureBox;
                    if (pictureBox != null)
                    {
                        MemoryStream strmImg = new MemoryStream(cast.Image);
                        pictureBox.Image = new Bitmap(strmImg);
                    }
                }
            }
            clearAllCasts(j, 5);
        }

        private void browseImage()
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            clearAllCasts(0, 5);
            addOrEdit = 1;
            idTextBox.ReadOnly = false;
        }

        private void clearAllCasts(int start, int end)
        {
            for (int i = start; i < end;)
            {
                i++;
                if (this.Controls.ContainsKey("idText" + i.ToString()))
                {
                    TextBox idText = this.Controls["idText" + i.ToString()] as TextBox;
                    if (idText != null)
                    {
                        idText.Text = "";
                    }
                }
                if (this.Controls.ContainsKey("characterText" + i.ToString()))
                {
                    TextBox characterText = this.Controls["characterText" + i.ToString()] as TextBox;
                    if (characterText != null)
                    {
                        characterText.Text = "";
                    }
                }
                if (this.Controls.ContainsKey("nameText" + i.ToString()))
                {
                    TextBox nameText = this.Controls["nameText" + i.ToString()] as TextBox;
                    if (nameText != null)
                    {
                        nameText.Text = "";
                    }
                }
                if (this.Controls.ContainsKey("pictureBox" + i.ToString()))
                {
                    PictureBox pictureBox = this.Controls["pictureBox" + i.ToString()] as PictureBox;
                    if (pictureBox != null)
                    {
                        pictureBox.Image = null;
                    }
                }
            }
        }

        private bool validateAllFields()
        {
            bool check = false;
            if (idTextBox.Text == "" || idText1 == null)
                check = true;
            if (titleTextBox.Text == "" || titleTextBox == null)
                check = true;
            if (overviewTextBox.Text == "" || overviewTextBox == null)
                check = true;
            if (releaseDateDateTimePicker.Text == "" || releaseDateDateTimePicker == null)
                check = true;
            if (voteAverageTextBox.Text == "" || voteAverageTextBox == null)
                check = true;
            if (imagePictureBox.Image == null)
                check = true;
            if (genreTextBox.Text == "" || genreTextBox == null)
                check = true;
            if (runtimeTextBox.Text == "" || runtimeTextBox == null)
                check = true;
            return check; 
        }
    }
}
