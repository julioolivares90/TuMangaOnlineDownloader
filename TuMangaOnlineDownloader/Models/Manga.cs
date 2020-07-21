using System;
using System.Collections.Generic;
using System.Text;

namespace TuMangaOnlineDownloader.Models
{
    public class Manga
    {
        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public string Demografia { get; set; }

        public double Score { get; set; }

        public string Description { get; set; }

        public string []Generos { get; set; }

        public string  Estado { get; set; }

        public string[] Capitulos { get; set; }
    }
}
