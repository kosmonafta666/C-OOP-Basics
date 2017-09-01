namespace Online_Radio_Database
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class InvalidSongException : Exception
    {
        private const string Message = "Invalid song.";

        public InvalidSongException()
            : base(Message)
        {
        }

        public InvalidSongException(string message)
            : base(message)
        {
        }
    }

    public class InvalidArtistNameException : InvalidSongException
    {
        private const string Message = "Artist name should be between 3 and 20 symbols.";

        public InvalidArtistNameException()
            : base(Message)
        {
        }

        public InvalidArtistNameException(string message)
            : base(message)
        {
        }
    }

    public class InvalidSongNameException : InvalidSongException
    {
        private const string Message = "Song name should be between 3 and 30 symbols.";

        public InvalidSongNameException()
            : base(Message)
        {
        }

        public InvalidSongNameException(string message)
            : base(message)
        {
        }
    }

    public class InvalidSongLengthException : InvalidSongException
    {
        private const string Message = "Invalid song length.";

        public InvalidSongLengthException()
            : base(Message)
        {
        }

        public InvalidSongLengthException(string message)
            : base(message)
        {
        }
    }

    public class InvalidSongMinutesException : InvalidSongLengthException
    {
        private const string Message = "Song minutes should be between 0 and 14.";

        public InvalidSongMinutesException()
            : base(Message)
        {
        }

        public InvalidSongMinutesException(string message)
            : base(message)
        {
        }
    }

    public class InvalidSongSecondsException : InvalidSongLengthException
    {
        private const string Message = "Song seconds should be between 0 and 59.";

        public InvalidSongSecondsException()
            : base(Message)
        {
        }

        public InvalidSongSecondsException(string message)
            : base(message)
        {
        }
    }

    public class Song
    {
        private int seconds;

        private int minutes;

        private string artistName;

        private string songName;

        public int Seconds
        {
            get { return this.seconds; }

            set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }

                this.seconds = value;
            }
        }

        public int Minutes
        {
            get { return this.minutes; }

            set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }

                this.minutes = value;
            }
        }

        public string ArtistName
        {
            get { return this.artistName; }

            set
            {
                if (value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }

                this.artistName = value;
            }
        }

        public string SongName
        {
            get { return this.songName; }

            set
            {
                if (value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }

                this.songName = value;
            }
        }

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            this.ArtistName = artistName;
            this.SongName = songName;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
    }

    public class OnlineRadioDatabase
    {
        public static void Main(string[] args)
        {
            //list for songs;
            var songs = new List<Song>();

            //var for number of songs;
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                //var for command;
                var command = Console.ReadLine()
                    .ToLower()
                    .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                //var for artist;
                var artist = command[0];
                //var for song;
                var song = command[1];

                try
                {
                    //var for splitted command for minutes and seconds;
                    var time = command[2]
                        .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    //var for minutes;
                    var minutes = time[0];
                    //var for seconds;
                    var seconds = time[1];

                    //var for song object;
                    var currentSong = new Song(artist, song, minutes, seconds);

                    //add current song to songs list;
                    songs.Add(currentSong);

                    Console.WriteLine("Song added.");
                }
                catch (InvalidSongException error)
                {
                    Console.WriteLine(error.Message);
                }
                catch (Exception fex)
                {
                    Console.WriteLine("Invalid song length.");
                }
            }//end of for loop;

            //print the number of songs;
            Console.WriteLine("Songs added: {0}", songs.Count);

            //var for total minutes of all songs;
            var totalMinutes = songs.Sum(x => x.Minutes);
            //var for total seconds of all songs;
            var totalSeconds = songs.Sum(x => x.Seconds);
            //add total munites to total seconds;
            totalSeconds += totalMinutes * 60;

            //var for munutes to print;
            var finalMinutes = totalSeconds / 60;
            //var for seconds to print;
            var finalSeconds = totalSeconds % 60;
            //var for hours to print;
            var finalHours = finalMinutes / 60;

            finalMinutes %= 60;

            //print total time of all songs;
            Console.WriteLine("Playlist length: {0}h {1}m {2}s", finalHours, finalMinutes, finalSeconds);
        }
    }
}
