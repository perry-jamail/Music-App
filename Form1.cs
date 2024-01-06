namespace DatabaseSQLMusicApp
{
    public partial class Form1 : Form
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();

        List<Album> albums = new List<Album>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // connect the list to the grid view control
            albumBindingSource.DataSource = albumsDAO.getAllAlbums();

            dataGridView1.DataSource = albumBindingSource;

            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/7/70/Weezer_-_Blue_Album.png");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // connect the list to the grid view control
            albumBindingSource.DataSource = albumsDAO.searchTitles
                (textBox1.Text);

            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowClicked = dataGridView.CurrentRow.Index;

            String imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

            pictureBox1.Load(imageURL);

            //Deleted
            AlbumsDAO albumsDAO = new AlbumsDAO();

            //tracksBindingSource.DataSource = albums[rowClicked].Cells[4].Value.ToString();
            tracksBindingSource.DataSource = albumsDAO.getTracksForAlbum((int)dataGridView.Rows[rowClicked].Cells[0].Value);

            dataGridView2.DataSource = tracksBindingSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Album album = new Album
            {
                AlbumName = txt_album.Text,
                ArtistName = txt_artist.Text,
                Year = Int32.Parse(txt_year.Text),
                ImageURL = txt_imageURL.Text,
                Description = txt_description.Text
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addOneAlbum(album);
            MessageBox.Show(result + " new row(s) inserted");
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowClicked = dataGridView.CurrentRow.Index;

            String videoURL = dataGridView.Rows[rowClicked].Cells[3].Value.ToString();

            webView21.Source = new Uri(videoURL);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView2.CurrentRow.Index;
            MessageBox.Show("You clicked row " + rowClicked);
            int trackID = (int)dataGridView2.Rows[rowClicked].Cells[0].Value;
            MessageBox.Show("ID of track " + trackID);

            AlbumsDAO albumsDao = new AlbumsDAO();

            int result = albumsDao.deleteTrack(trackID);

            MessageBox.Show("Result " + result);

            dataGridView2.DataSource = null;
            albums = albumsDao.getAllAlbums();
        }
    }
}