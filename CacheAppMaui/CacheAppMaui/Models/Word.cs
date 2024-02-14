﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheAppMaui.Models
{

    public class Word
    {
        public string word { get; set; }
        public string phonetic { get; set; }
        public string testNumber { get; set; }
        public Phonetic[] phonetics { get; set; }
        public Meaning[] meanings { get; set; }
        public License license { get; set; }
        public string[] sourceUrls { get; set; }
    }

    public class License
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Phonetic
    {
        public string text { get; set; }
        public string audio { get; set; }
        public string sourceUrl { get; set; }
        public License1 license { get; set; }
    }

    public class License1
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Meaning
    {
        public string partOfSpeech { get; set; }
        public Definition[] definitions { get; set; }
        public string[] synonyms { get; set; }
        public object[] antonyms { get; set; }
    }

    public class Definition
    {
        public string definition { get; set; }
        public string[] synonyms { get; set; }
        public object[] antonyms { get; set; }
        public string example { get; set; }
    }


}
