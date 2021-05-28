using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using MovieConnector;
using TMDbLib.Client;
using TMDbLib.Helpers;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.Movies;
using TMDbLib.Utilities;
using TMDbLib.Objects.Discover;
using Microsoft.Windows.Controls;
using System.Threading;
using System.IO;

namespace MovieDB
{
    public partial class MainWindow : Window
    {
        List<PopulairMovies.Movie> nowPlaying = null;
        MovieConnector.Movie currentMovie = null;
        static TMDbClient client = new TMDbClient("1e20d37d2fa2b6600f8a84c5893c9143");
        bool displayContent = false;
        private DBController dbController = new DBController();

        public DBController DbController
        {
            get { return dbController; }
        }
        

        public MainWindow()
        {
            InitializeComponent();
        }

        #region
        
        public SearchMovie findMovie(string name, string releaseYear)
        {
            try 
            {
                int rY = Int32.Parse(releaseYear);
                SearchContainer<SearchMovie> results = client.SearchMovieAsync(name, 0, false, rY).Result;
                return results.Results[0];
            }
            catch (Exception e)
            {
                textBoxSearch.Text = name;
                contentIsNotAvailable.Visibility = Visibility.Visible;
                return null;
            }
        }

        public SearchMovie findMovie(string name)
        {
            try
            {
                SearchContainer<SearchMovie> results = client.SearchMovieAsync(name, 0, false).Result;
                return results.Results[0];
            }
            catch (Exception e)
            {
                textBoxSearch.Text = name;
                contentIsNotAvailable.Visibility = Visibility.Visible;
                return null;
            }
        }

        private void searchMovie(string movie)
        {
            if (!gridSearch.IsVisible)
            {
                gridSearch.Visibility = Visibility.Visible;
                gridNowPlaying.Visibility = Visibility.Hidden;
                gridRecentReleases.Visibility = Visibility.Hidden;
                menuSearch.Foreground = new SolidColorBrush(Color.FromRgb(255, 153, 0));
                menuNowPlaying.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
                menuReleases.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
            }
            SearchMovie m;
            if (movie.Contains("_"))
            {
                string[] arr = movie.Split('_');
                m = findMovie(arr[0], arr[1]);
            }
            else
                m = findMovie(movie);
            clearListBoxMovCont();
            if (m != null)
                displayMovieContent(addMovieToDisplay(m));
        }
        #endregion

        #region
        
        private Image drawImage(string name, string posterPath, int height, int width, int[] margin, byte[] imageArray)
        {
            Image image = new Image();
            image.Name = "image" + name;
            image.HorizontalAlignment = HorizontalAlignment.Left;
            image.VerticalAlignment = VerticalAlignment.Top;
            BitmapImage logo = new BitmapImage();
            if (imageArray != null)
            {
                MemoryStream strmImg = new MemoryStream(imageArray);
                logo.BeginInit();
                logo.StreamSource = strmImg;
                //logo.DecodePixelWidth = 200;
                logo.EndInit();
            }
            else {
                logo.BeginInit();
                logo.UriSource = new Uri(posterPath);
                logo.EndInit();
            }
            image.Source = logo;
            if (height > 0)
                image.Height = height;
            if (width > 0)
                image.Width = width;
            image.Margin = new Thickness(margin[0], margin[1], margin[2], margin[3]);
            return image;
        }

        private TextBlock drawTextBlock(string name, string text, string foregroundColor, FontWeight fontWeight, int fontSize, int[] margin, int[] padding, int height, int width)
        {
            var bc = new BrushConverter();
            TextBlock textBlock = new TextBlock();
            textBlock.Name = "textBlock" + name;
            textBlock.HorizontalAlignment = HorizontalAlignment.Left;
            textBlock.VerticalAlignment = VerticalAlignment.Top;
            textBlock.TextWrapping = TextWrapping.Wrap;
            textBlock.Text = text;
            textBlock.Foreground = (Brush)bc.ConvertFrom(foregroundColor);
            if (fontWeight != FontWeights.Regular)
                textBlock.FontWeight = fontWeight;
            if (fontSize > 0)
                textBlock.FontSize = fontSize;
            if (margin != null)
                textBlock.Margin = new Thickness(margin[0], margin[1], margin[2], margin[3]);
            if (padding != null)
                textBlock.Padding = new Thickness(padding[0], padding[1], padding[2], padding[3]);
            if (width > 0)
                textBlock.Width = width;
            if (height > 0)
                textBlock.Height = height;
            return textBlock;
        }
        #endregion

        #region
       
        private void displayRecentReleases()
        {
            while (true)
            {
                if (displayContent)
                {
                    listBoxRecentReleases.Items.Clear();
                    menuReleases.Foreground = new SolidColorBrush(Color.FromRgb(255, 153, 0));
                    listBoxMovieContent.Visibility = Visibility.Hidden;
                    List<MovieConnector.Movie> movies = dbController.getAllMovies();
                    int numObj = 1;
                    List<WrapPanel> wrapPanelList = new List<WrapPanel>();
                    wrapPanelList.Add(new WrapPanel());
                    int i = 0;
                    if (movies == null || movies.Count == 0)
                    {
                        MessageBox.Show("No movies to display");
                        return;
                    }
                    else {
                        foreach (MovieConnector.Movie m in movies)
                        {
                            //Grid
                            Grid grid = new Grid();
                            grid.Margin = new Thickness(3);
                            grid.HorizontalAlignment = HorizontalAlignment.Left;
                            grid.VerticalAlignment = VerticalAlignment.Top;
                            grid.Height = 150;
                            grid.Width = 265;
                            var bc = new BrushConverter();
                            grid.Background = (Brush)bc.ConvertFrom("#FF212121");
                            //Images
                            int numImage = 1;
                            //Image1
                            grid.Children.Add(drawImage(numObj + "" + numImage++, "http://image.tmdb.org/t/p/w185/" + m.PosterPath, 68, 45, new int[] { 10, 10, 0, 0 }, m.Image));
                            //Image2
                            grid.Children.Add(drawImage(numObj + "" + numImage++, "pack://siteoforigin:,,,/files/ic_stars_white_48dp_2x.ico",
                                16, 16, new int[] { 69, 52, 0, 0 }, null));
                            //Image3
                            grid.Children.Add(drawImage(numObj + "" + numImage++, "pack://siteoforigin:,,,/files/ic_timer_white_48dp_2x.ico",
                                16, 16, new int[] { 137, 52, 0, 0 }, null));
                            //TextBlocks
                            int numTextBlock = 1;
                            string text = "";
                            //textBlock1
                            grid.Children.Add(drawTextBlock(numObj + "" + numTextBlock++, m.Title, "#FFE9E9E9", FontWeights.Bold, 16, new int[] { 60, 10, 0, 0 }, new int[] { 9, 0, 0, 0 }, 25, 170));
                            //textBlock2
                            string[] genres = m.Genre.Split(',');
                            text = "Genres: ";
                            if (genres.Length > 0)
                            {
                                if (genres.Length >= 2)
                                    text += genres[0] + ", " + genres[1];
                                else
                                {
                                    text += genres[0];
                                }
                            }
                            grid.Children.Add(drawTextBlock(numObj + "" + numTextBlock++, text, "#FFBCBCBC", FontWeights.Regular, -1, new int[] { 55, 31, 0, 0 }, new int[] { 13, 0, 0, 0 }, -1, 175));
                            //textBlock3
                            TextBlock textBlock = drawTextBlock(numObj + "" + numTextBlock++, "", "#FFE9E9E9", FontWeights.Bold, -1, new int[] { 90, 52, 0, 0 }, null, -1, -1);
                            Run run = new Run(m.VoteAverage.ToString());
                            run.Foreground = (Brush)bc.ConvertFrom("#FFBBBB57");
                            textBlock.Inlines.Add(run);
                            run = new Run("/10");
                            textBlock.Inlines.Add(run);
                            grid.Children.Add(textBlock);
                            //textBlock4
                            grid.Children.Add(drawTextBlock(numObj + "" + numTextBlock++, m.Runtime.ToString() + " min", "#FFE9E9E9", FontWeights.Bold, -1, new int[] { 158, 52, 0, 0 }, null, -1, -1));
                            //textBlock5
                            grid.Children.Add(drawTextBlock(numObj + "" + numTextBlock++, m.Overview, "#FFBCBCBC", FontWeights.Regular, -1, new int[] { 10, 83, 0, 0 }, new int[] { 13, 0, 0, 0 }, 34, 220));
                            //Button
                            Button button = new Button();
                            button.Name = "button_" + m.Id;
                            button.Click += movieGetContent_mouseDownHandler;
                            button.Content = "More >>";
                            button.HorizontalAlignment = HorizontalAlignment.Left;
                            button.VerticalAlignment = VerticalAlignment.Top;
                            button.Background = (Brush)bc.ConvertFrom("#FF3299BB");
                            button.Foreground = (Brush)bc.ConvertFrom("#FFE9E9E9");
                            button.FontWeight = FontWeights.Bold;
                            button.Width = 75;
                            button.Margin = new Thickness(155, 122, 0, 0);
                            grid.Children.Add(button);
                            wrapPanelList[i].Children.Add(grid);
                            if (wrapPanelList[i].Children.Count == 3)
                            {
                                listBoxRecentReleases.Items.Add(wrapPanelList[i]);
                                wrapPanelList.Add(new WrapPanel());
                                i++;
                            }
                        }
                        listBoxRecentReleases.Items.Add(wrapPanelList[i]);
                        break;
                    }
                }
                else
                {
                    Thread.Sleep(100);                    
                }
            }
        }

        private void displayMovieContent(MovieConnector.Movie m)
        {
            contentIsNotAvailable.Visibility = Visibility.Hidden;
            clearListBoxCast();
            int numObj = 2;
            if (m != null)
            {
                textBoxSearch.Text = m.Title;
                Grid grid = new Grid();
                grid.Height = 478;
                grid.Width = 844;
                var bc = new BrushConverter();
                grid.Background = (Brush)bc.ConvertFrom("#FF212121");
                GridSplitter gridSplitter = new GridSplitter();
                gridSplitter.HorizontalAlignment = HorizontalAlignment.Left;
                gridSplitter.VerticalAlignment = VerticalAlignment.Top;
                gridSplitter.Height = 430;
                gridSplitter.Width = 3;
                gridSplitter.Margin = new Thickness(252, 13, 0, 0);
                gridSplitter.Background = (Brush)bc.ConvertFrom("#FFBCBCBC");
                grid.Children.Add(gridSplitter);
                //Images
                int numImage = 1;
                //Image1
                grid.Children.Add(drawImage(numObj + "" + numImage++, "http://image.tmdb.org/t/p/w185/" + m.PosterPath, 301, 290, new int[] { 20, 15, 0, 0 }, m.Image));
                //Image2
                grid.Children.Add(drawImage(numObj + "" + numImage++, "pack://siteoforigin:,,,/files/ic_stars_white_48dp_2x.ico", 21, 21, new int[] { 295, 65, 0, 0 }, null));
                //Image3
                grid.Children.Add(drawImage(numObj + "" + numImage++, "pack://siteoforigin:,,,/files/ic_timer_white_48dp_2x.ico", 21, 21, new int[] { 390, 65, 0, 0 }, null));
                //TextBlocks
                int numTextBlock = 1;
                string text = "";
                //textBlock1
                grid.Children.Add(drawTextBlock(numObj + "" + numTextBlock++, m.Title + " (" + m.ReleaseDate.ToString("yyyy") + ")", "#FFE9E9E9", FontWeights.Bold, 18, new int[] { 288, 10, 0, 0 }, new int[] { 9, 0, 0, 0 }, 31, 551));
                //textBlock2
                text = "Genres: " + m.Genre;
                grid.Children.Add(drawTextBlock(numObj + "" + numTextBlock++, text, "#FFBCBCBC", FontWeights.Bold, 14, new int[] { 288, 42, 0, 0 }, new int[] { 9, 0, 0, 0 }, -1, -1));
                //textBlock3
                TextBlock textBlock = drawTextBlock(numObj + "" + numTextBlock++, "", "#FFE9E9E9", FontWeights.Bold, -1, new int[] { 325, 65, 0, 0 }, null, -1, -1);
                Run run = new Run(m.VoteAverage.ToString());
                run.Foreground = (Brush)bc.ConvertFrom("#FFBBBB57");
                textBlock.Inlines.Add(run);
                run = new Run("/10");
                textBlock.Inlines.Add(run);
                grid.Children.Add(textBlock);
                //textBlock4
                grid.Children.Add(drawTextBlock(numObj + "" + numTextBlock++, m.Runtime.ToString() + " min", "#FFE9E9E9", FontWeights.Bold, 14, new int[] { 410, 65, 0, 0 }, new int[] { 9, 0, 0, 0 }, -1, -1));
                //textBlock5
                grid.Children.Add(drawTextBlock(numObj + "" + numTextBlock++, "Release Date: (" + m.ReleaseDate.ToString("MMMM dd, yyyy") + ")", "#FFBCBCBC", FontWeights.Bold, 14, new int[] { 288, 90, 0, 0 }, new int[] { 9, 0, 0, 0 }, 170, 420));

                WrapPanel wrapPanel = new WrapPanel();
                wrapPanel.Width = 450;
                wrapPanel.Margin = new Thickness(200, 120, 0, 0);
                //textBlock6
                wrapPanel.Children.Add(drawTextBlock(numObj + "" + numTextBlock++, "Storyline: \n" + m.Overview + "\n\nCasts:", "#FFBCBCBC", FontWeights.Bold, 14, null, null, -1, 420));

                List<MovieConnector.Cast> casts;
                if (m.Casts == null)
                    casts = dbController.getAllCastsForMovie(m.Id);
                else
                    casts = m.Casts;

                if (casts.Count != 0)
                {
                    foreach (MovieConnector.Cast cast in casts)
                    {
                        Grid crewMember = new Grid();
                        crewMember.Width = 400;
                        crewMember.Height = 60;
                        crewMember.Children.Add(drawImage(numObj + "" + numImage++, "http://image.tmdb.org/t/p/w185/" + cast.ProfilePath, 60, -1, new int[] { 0, 10, 10, 0 }, cast.Image));
                        TextBlock crewName = new TextBlock();
                        crewName.MouseDown += new MouseButtonEventHandler(castName_mouseDownHandler);
                        crewName.MouseEnter += new MouseEventHandler(castName_mouseOverHandler);
                        crewName.MouseLeave += new MouseEventHandler(castName_mouseLeaveHandler);
                        crewName.Text = cast.Name;
                        crewName.Uid = m.Id + "_" + cast.Id.ToString();
                        crewName.Margin = new Thickness(80, 10, 0, 0);
                        crewName.Foreground = new SolidColorBrush(Color.FromRgb(50, 153, 187)); ;
                        crewName.FontWeight = FontWeights.Bold;
                        Label crewCharacter = new Label();
                        crewCharacter.Content = cast.Character;
                        crewCharacter.Margin = new Thickness(80, 25, 0, 0);
                        crewCharacter.Foreground = (Brush)bc.ConvertFrom("#FFBCBCBC");

                        crewMember.Children.Add(crewName);
                        crewMember.Children.Add(crewCharacter);
                        wrapPanel.Children.Add(crewMember);
                    }
                }


                grid.Children.Add(wrapPanel);
                
                listBoxMovieContent.Items.Add(grid);
            }
        }

        private void displayCastContent(string castUId)
        {
            MovieConnector.Cast cast = null;
            string[] arr = castUId.Split('_');
            if (dbController.checkIfCastInDatabase(Int32.Parse(arr[1])))
                cast = dbController.getCastContent(Int32.Parse(arr[1]));
            else
                cast = currentMovie.getCast(Int32.Parse(arr[1]));
            int numObj = 3;
            if (cast != null)
            {
                Grid grid = new Grid();
                grid.Height = 478;
                grid.Width = 844;
                var bc = new BrushConverter();
                grid.Background = (Brush)bc.ConvertFrom("#FF212121");
                GridSplitter gridSplitter = new GridSplitter();
                gridSplitter.HorizontalAlignment = HorizontalAlignment.Left;
                gridSplitter.VerticalAlignment = VerticalAlignment.Top;
                gridSplitter.Height = 430;
                gridSplitter.Width = 3;
                gridSplitter.Margin = new Thickness(252, 13, 0, 0);
                gridSplitter.Background = (Brush)bc.ConvertFrom("#FFBCBCBC");
                grid.Children.Add(gridSplitter);
                
                int numImage = 1;
                
                grid.Children.Add(drawImage(numObj + "" + numImage++, "http://image.tmdb.org/t/p/w185/" + cast.ProfilePath, 301, 290, new int[] { 20, 35, 0, 0 }, cast.Image));

              
                int numTextBlock = 1;
                string text = "";
               
                grid.Children.Add(drawTextBlock(numObj + "" + numTextBlock++, cast.Name, "#FFE9E9E9", FontWeights.Bold, 18, new int[] { 288, 10, 0, 0 }, new int[] { 9, 0, 0, 0 }, 31, 551));
               
                text += "Character: ";
                grid.Children.Add(drawTextBlock(numObj + "" + numTextBlock++, text + cast.Character, "#FFBCBCBC", FontWeights.Regular, 14, new int[] { 288, 40, 0, 0 }, new int[] { 9, 0, 0, 0 }, -1, -1));

              
                Button button = new Button();
                button.Name = "goBack_Button";
                button.Click += goBack_Button_Click;
                button.Content = "<Go Back";
                button.HorizontalAlignment = HorizontalAlignment.Left;
                button.VerticalAlignment = VerticalAlignment.Top;
                button.Background = (Brush)bc.ConvertFrom("#FF3299BB");
                button.Foreground = (Brush)bc.ConvertFrom("#FFE9E9E9");
                button.FontWeight = FontWeights.Bold;
                button.Width = 75;
                button.Height = 25;
                button.Margin = new Thickness(20, 5, 0, 0);
                grid.Children.Add(button);
               
                listBoxCastContent.Items.Add(grid);
            }
        }
        #endregion


        private TMDbLib.Objects.Movies.Movie getCasts(int movieId)
        {
            try {
                TMDbLib.Objects.Movies.Movie casts = client.GetMovieAsync(movieId, MovieMethods.Credits | MovieMethods.Videos).Result;
                return casts;
            }
            catch (AggregateException e)
            {
                throw e;
            }
        }

        #region
        
        private MovieConnector.Movie addMovieToDisplay(SearchMovie movie)
        {
            TMDbLib.Objects.Movies.Movie movie2 = client.GetMovieAsync(movie.Id).Result;
            List<string> ourGenres = new List<string>();

            List<MovieConnector.Cast> ourCasts = new List<MovieConnector.Cast>();

            foreach (Genre genre in movie2.Genres)
            {
                ourGenres.Add(genre.Name);
            }

            try
            {
                TMDbLib.Objects.Movies.Movie casts;  casts = getCasts(movie.Id);
                int castCount = casts.Credits.Cast.Capacity;
                if (castCount > 5)
                {
                    castCount = 5;
                }
                for (int i = 0; i < castCount; i++)
                {
                    ourCasts.Add(new MovieConnector.Cast(casts.Credits.Cast[i].Id, casts.Credits.Cast[i].Character, casts.Credits.Cast[i].Name, casts.Credits.Cast[i].ProfilePath));
                }
            }
            catch (Exception e) { }

            currentMovie = new MovieConnector.Movie(movie.Id, movie.Title, movie.Overview, movie.ReleaseDate.Value, movie.VoteAverage,
            movie.PosterPath, ourCasts, string.Join(",", ourGenres.ToArray()), movie2.Runtime.Value);

            return currentMovie;
        }


        private MovieConnector.Movie addMovieToDatabase(SearchMovie movie)
        {
            if (dbController.checkIfMovieInDatabase(movie.Id))
                currentMovie = dbController.getMovieContent(movie.Id);
            else
            {
                TMDbLib.Objects.Movies.Movie movie2 = client.GetMovieAsync(movie.Id).Result;
                List<Genre> genres = movie2.Genres;
                List<string> ourGenres = new List<string>();

                TMDbLib.Objects.Movies.Movie casts;

                foreach (Genre genre in genres)
                {
                    ourGenres.Add(genre.Name);
                }

                currentMovie = dbController.insertToMovie(movie.Id, movie.Title, movie.Overview, movie.ReleaseDate.Value, movie.VoteAverage,
                movie.PosterPath, string.Join(",", ourGenres.ToArray()), movie2.Runtime.Value);

                try
                {
                    casts = getCasts(movie.Id);
                    int castCount = casts.Credits.Cast.Capacity;
                    if (castCount > 5)
                    {
                        castCount = 5;
                    }
                    for (int i = 0; i < castCount; i++)
                    {
                        if (!dbController.checkIfCastInDatabase(casts.Credits.Cast[i].Id))
                        {
                            dbController.insertToCast(casts.Credits.Cast[i].Id, casts.Credits.Cast[i].Character, casts.Credits.Cast[i].Name, casts.Credits.Cast[i].ProfilePath);
                        }
                        dbController.insertCastToMovie(movie.Id, casts.Credits.Cast[i].Id);
                    }
                }
                catch (Exception e) { }
            }
            return currentMovie;
        }
        #endregion

    
        private static bool isPostalCode(string text)
        {
            Regex regex = new Regex(@"^[A-Za-z]\d[A-Za-z]\d[A-Za-z]\d$"); 
            return regex.IsMatch(text);
        }

        #region
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DiscoverMovie m = client.DiscoverMoviesAsync().IncludeVideoMovies().WhereReleaseDateIsAfter(DateTime.Now.AddDays(-7));
            SearchContainer<SearchMovie> recent = m.Query().Result;
          
            Thread thread = new Thread(() =>
            {
                foreach (SearchMovie movie in recent.Results)
                {
                    addMovieToDatabase(movie);
                }
                displayContent = true;
            });
            thread.Start();

            displayRecentReleases();
        }


        private void clearListBoxMovCont()
        {
            listBoxMovieContent.Items.Clear();

            gridSearch.Visibility = Visibility.Visible;
            gridNowPlaying.Visibility = Visibility.Hidden;
            gridRecentReleases.Visibility = Visibility.Hidden;
            menuSearch.Foreground = new SolidColorBrush(Color.FromRgb(255, 153, 0));
            menuNowPlaying.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
            menuReleases.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));

            listBoxMovieContent.Visibility = Visibility.Visible;
        }

      
        private void castName_mouseDownHandler(object sender, RoutedEventArgs e)
        {
            listBoxMovieContent.Visibility = Visibility.Hidden;
            listBoxCastContent.Visibility = Visibility.Visible;
            displayCastContent(((TextBlock)sender).Uid);
        }

        private void castName_mouseOverHandler(object sender, RoutedEventArgs e)
        {
            ((TextBlock)sender).Foreground = new SolidColorBrush(Color.FromRgb(255, 153, 0));
            ((TextBlock)sender).FontWeight = FontWeights.Normal;
        }
        private void castName_mouseLeaveHandler(object sender, RoutedEventArgs e)
        {
            ((TextBlock)sender).Foreground = new SolidColorBrush(Color.FromRgb(50, 153, 187));
            ((TextBlock)sender).FontWeight = FontWeights.Bold;
        }

       
        private void movieGetContent_mouseDownHandler(object sender, EventArgs e)
        {
            clearListBoxMovCont();

            Button buttonSender = (Button)sender;
            int movieId = Int32.Parse(buttonSender.Name.Substring(7));
            MovieConnector.Movie m = dbController.getMovieContent(movieId);
            displayMovieContent((m));
        }
       
        private void nowPlayingMovies_mouseOverHandler(object sender, RoutedEventArgs e)
        {
            ((TextBlock)sender).Foreground = new SolidColorBrush(Color.FromRgb(255, 153, 0));
            ((TextBlock)sender).FontWeight = FontWeights.Normal;
        }
        private void nowPlayingMovies_mouseLeaveHandler(object sender, RoutedEventArgs e)
        {
            ((TextBlock)sender).Foreground = new SolidColorBrush(Color.FromRgb(50, 153, 187));
            ((TextBlock)sender).FontWeight = FontWeights.Bold;
        }
        private void nowPlayingMovies_mouseDownHandler(object sender, RoutedEventArgs e)
        {
            searchMovie(((TextBlock)sender).Uid);
        }

        private void buttonGetNowPlaying_Click(object sender, RoutedEventArgs e)
        {
            if (isPostalCode(textBoxPostalCode.Text))
            {
                nowPlaying = PopulairMovies.getNowPlayingList(textBoxPostalCode.Text, ((ComboBoxItem)comboBoxRadius.SelectedItem).Content.ToString());
                if( nowPlaying != null )
                {
                    foreach (PopulairMovies.Movie movie in nowPlaying)
                    {
                        WrapPanel itm = new WrapPanel();
                        itm.Width = 840;
                        TextBlock title = new TextBlock();
                        title.Text = movie.title;
                        title.Uid = movie.title + "_" + movie.releaseYear;
                        title.TextWrapping = TextWrapping.Wrap;
                        title.FontSize = 18;
                        title.Width = 600;
                        title.Foreground = new SolidColorBrush(Color.FromRgb(50, 153, 187));
                        title.FontWeight = FontWeights.Bold;
                        title.HorizontalAlignment = HorizontalAlignment.Left;
                        title.VerticalAlignment = VerticalAlignment.Top;
                        title.MouseEnter += new MouseEventHandler(nowPlayingMovies_mouseOverHandler);
                        title.MouseLeave += new MouseEventHandler(nowPlayingMovies_mouseLeaveHandler);
                        title.MouseDown += new MouseButtonEventHandler(nowPlayingMovies_mouseDownHandler);
                        itm.Children.Add(title);
                        TextBlock genres = new TextBlock();
                        genres.Text = "Genres:    ";
                        genres.TextWrapping = TextWrapping.Wrap;
                        genres.FontSize = 9;
                        genres.Width = 240;
                        genres.HorizontalAlignment = HorizontalAlignment.Left;
                        genres.VerticalAlignment = VerticalAlignment.Top;
                        genres.Foreground = new SolidColorBrush(Color.FromRgb(233,233,233));
                        int genresCount = 0;
                        if ( movie.genres!= null)
                        {
                            if (movie.genres.Length > 5)
                            {
                                genresCount = 5;
                            }
                            else
                            {
                                genresCount = movie.genres.Length;
                            }
                        }
                        for (int i = 0; i < genresCount; i++)
                        {
                            genres.Text += movie.genres[i] + "    ";
                        }
                        itm.Children.Add(genres);
                        string currentTheatre = "";
                        int theatreId = -1;
                        List<WrapPanel> theatres = new List<WrapPanel>();
                        foreach (PopulairMovies.Showtimes show in movie.showtimes)
                        {
                            if (Regex.IsMatch(currentTheatre, show.theatre.name, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(1000)))
                            {
                                Label timeH = new Label();
                                timeH.Content = DateTime.ParseExact(show.dateTime, "yyyy-MM-ddTHH:mm", null).ToString("HH");
                                timeH.FontSize = 10;
                                timeH.Background = new SolidColorBrush(Color.FromRgb(188, 188, 188));
                                timeH.Foreground = new SolidColorBrush(Color.FromRgb(66, 66, 66));
                                timeH.Margin = new Thickness(2, 2, 0, 2);
                                timeH.HorizontalAlignment = HorizontalAlignment.Right;
                                timeH.VerticalAlignment = VerticalAlignment.Top;
                                theatres[theatreId].Children.Add(timeH);
                                Label timeM = new Label();
                                timeM.Content = DateTime.ParseExact(show.dateTime, "yyyy-MM-ddTHH:mm", null).ToString("mm");
                                timeM.FontSize = 10;
                                timeM.Background = new SolidColorBrush(Color.FromRgb(99, 99, 99));
                                timeM.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
                                timeM.Margin = new Thickness(0, 2, 2, 2);
                                timeM.HorizontalAlignment = HorizontalAlignment.Right;
                                timeM.VerticalAlignment = VerticalAlignment.Top;
                                theatres[theatreId].Children.Add(timeM);
                            }
                            else
                            {
                                currentTheatre = show.theatre.name;
                                theatreId++;
                                theatres.Add(new WrapPanel());
                                theatres[theatreId].Width = 240;
                                itm.Children.Add(theatres[theatreId]);
                                TextBlock theatreName = new TextBlock();
                                theatreName.Text = show.theatre.name;
                                theatreName.TextWrapping = TextWrapping.Wrap;
                                theatreName.FontSize = 14;
                                theatreName.Width = 240;
                                theatreName.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
                                theatreName.FontWeight = FontWeights.Bold;
                                theatreName.HorizontalAlignment = HorizontalAlignment.Center;
                                theatreName.VerticalAlignment = VerticalAlignment.Top;
                                theatres[theatreId].Children.Add(theatreName);
                                Label timeH = new Label();
                                timeH.Content = DateTime.ParseExact(show.dateTime, "yyyy-MM-ddTHH:mm", null).ToString("HH");
                                timeH.FontSize = 10;
                                timeH.Background = new SolidColorBrush(Color.FromRgb(188, 188, 188));
                                timeH.Foreground = new SolidColorBrush(Color.FromRgb(66, 66, 66));
                                timeH.Margin = new Thickness(2,2,0,2);
                                timeH.HorizontalAlignment = HorizontalAlignment.Right;
                                timeH.VerticalAlignment = VerticalAlignment.Top;
                                theatres[theatreId].Children.Add(timeH);
                                Label timeM = new Label();
                                timeM.Content = DateTime.ParseExact(show.dateTime, "yyyy-MM-ddTHH:mm", null).ToString("mm");
                                timeM.FontSize = 10;
                                timeM.Background = new SolidColorBrush(Color.FromRgb(99, 99, 99));
                                timeM.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
                                timeM.Margin = new Thickness(0, 2, 2, 2);
                                timeM.HorizontalAlignment = HorizontalAlignment.Right;
                                timeM.VerticalAlignment = VerticalAlignment.Top;
                                theatres[theatreId].Children.Add(timeM);
                            }
                            
                        }
                        listBoxNowPlaying.Items.Add(itm);
                    }
                }
                else
                {
                    MessageBox.Show("No theaters can be found in our data base next to this location!");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid postal code (with no spaces)");
            }
        }

       
        private void menuNowPlaying_Click(object sender, RoutedEventArgs e)
        {
            if (!gridNowPlaying.IsVisible)
            {
                gridNowPlaying.Visibility = Visibility.Visible;
                gridSearch.Visibility = Visibility.Hidden;
                gridRecentReleases.Visibility = Visibility.Hidden;
                gridAdminPanel.Visibility = Visibility.Hidden;
                menuNowPlaying.Foreground = new SolidColorBrush(Color.FromRgb(255, 153, 0));
                menuSearch.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
                menuReleases.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
                adminPanel.Foreground = new SolidColorBrush(Color.FromRgb(255, 233, 233));
            }
        }

        private void menuSearch_Click(object sender, RoutedEventArgs e)
        {
            if (!gridSearch.IsVisible)
            {
                gridSearch.Visibility = Visibility.Visible;
                gridNowPlaying.Visibility = Visibility.Hidden;
                gridRecentReleases.Visibility = Visibility.Hidden;
                gridAdminPanel.Visibility = Visibility.Hidden;
                menuSearch.Foreground = new SolidColorBrush(Color.FromRgb(255, 153, 0));
                menuNowPlaying.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
                menuReleases.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
                adminPanel.Foreground = new SolidColorBrush(Color.FromRgb(255, 233, 233));
            }
        }

        private void menuReleases_Click(object sender, RoutedEventArgs e)
        {
            if (!gridRecentReleases.IsVisible)
            {
                gridRecentReleases.Visibility = Visibility.Visible;
                gridNowPlaying.Visibility = Visibility.Hidden;
                gridSearch.Visibility = Visibility.Hidden;
                gridAdminPanel.Visibility = Visibility.Hidden;
                menuReleases.Foreground = new SolidColorBrush(Color.FromRgb(255, 153, 0));
                menuNowPlaying.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
                menuSearch.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
                adminPanel.Foreground = new SolidColorBrush(Color.FromRgb(255, 233, 233));
            }
        }

        private void adminPanel_Click(object sender, RoutedEventArgs e)
        {
            if (!gridAdminPanel.IsVisible)
            {
                gridAdminPanel.Visibility = Visibility.Visible;
                gridRecentReleases.Visibility = Visibility.Hidden;
                gridNowPlaying.Visibility = Visibility.Hidden;
                gridSearch.Visibility = Visibility.Hidden;
                adminPanel.Foreground = new SolidColorBrush(Color.FromRgb(255, 153, 0));
                menuReleases.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
                menuNowPlaying.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
                menuSearch.Foreground = new SolidColorBrush(Color.FromRgb(233, 233, 233));
            }
        }

        private void textBoxPostalCode_GotFocus(object sender, RoutedEventArgs e)
        {
            textBoxPostalCode.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            textBoxPostalCode.Foreground = new SolidColorBrush(Color.FromRgb(0,0,0));
        }

        private void textBoxPostalCode_LostFocus(object sender, RoutedEventArgs e)
        {
            textBoxPostalCode.Background = new SolidColorBrush(Color.FromRgb(233, 233, 233));
            textBoxPostalCode.Foreground = new SolidColorBrush(Color.FromRgb(66, 66, 66));
        }

        private void textBoxSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            textBoxSearch.Background = new SolidColorBrush(Color.FromRgb(233, 233, 233));
            textBoxSearch.Foreground = new SolidColorBrush(Color.FromRgb(66, 66, 66));
        }

        private void textBoxSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            textBoxSearch.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            textBoxSearch.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        private void buttonSearch_Click(object sender, RoutedEventArgs e)
        {
            
        }
        

        private void textBoxSearch_TextChanged(object sender, RoutedEventArgs e)
        {
            try
            {
                SearchContainer<SearchMovie> results = client.SearchMovieAsync(((AutoCompleteBox)sender).Text).Result;
                List<string> listOfMovies = new List<string>();
                foreach (SearchMovie m in results.Results)
                {
                    listOfMovies.Add(m.Title);
                }
               
            }
            catch (Exception er)
            {}
        }

        private void clearListBoxCast()
        {
            listBoxCastContent.Items.Clear();
            listBoxMovieContent.Visibility = Visibility.Visible;
            listBoxCastContent.Visibility = Visibility.Hidden;
        }

        private void goBack_Button_Click(object sender, RoutedEventArgs e)
        {
            clearListBoxCast();
        }
        #endregion

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxUsername.Text == "majid" && passwordBox.Password == "majid")
            {
                textBoxUsername.Text = "";
                passwordBox.Password = "";
                labelError.Visibility = Visibility.Hidden;
                gridAdminPanel.Visibility = Visibility.Hidden;
                new Form1().Show();
                this.Hide();
            }
            else
            {
                labelError.Visibility = Visibility.Visible;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            textBoxUsername.Text = "";
            passwordBox.Password = "";
        }
    }
}
