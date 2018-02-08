using System.Collections.Generic;
using System;

namespace CdOrganizer.Models
{
    public class Cd
    {
        private string _title;
        private string _artist;
        private static List<Cd> _myCds = new List<Cd> {};

        public Cd (string title, string artist)
        {
            _title = title;
            _artist = artist;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetArtist()
        {
            return _artist;
        }

        public static List<Cd> GetAll()
        {
            return _myCds;
        }

        public void Save()
        {
            _myCds.Add(this);
        }

    }
}
