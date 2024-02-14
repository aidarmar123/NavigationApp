using CacheAppMaui.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheAppMaui.Service
{
    public static class DataManager
    {
        public static readonly string WordImportPath = "words.json";
        public static string WordCachePath { get => Path.Combine(FileSystem.Current.AppDataDirectory, "copyWords.json"); }

        private static List<Word> words;

        public static List<Word> Words
        {
            get
            {
                if (words == null)
                {
                    words = GetData<List<Word>>(WordCachePath);
                }
                return words;
            }
            set
            {
                words = value;
                SetData(WordCachePath, words);
            }
        }

        private static void SetData<T>(string wordCachePath, T words)
        {
            var jsonData = JsonConvert.SerializeObject(words);
            File.WriteAllText(wordCachePath, jsonData);
        }

        private static T GetData<T>(string wordCachePath)
        {
            var data = JsonConvert.DeserializeObject<T>(File.ReadAllText(wordCachePath));
            return data;
        }

        public static async void InitDataPath(string outpput, string source)
        {
            if (!File.Exists(outpput))
            {
                var file = File.Create(outpput);
                file.Close();
                File.WriteAllText(outpput, await ReadAsset(source));
            }
        }

        private static async Task<string> ReadAsset(string source)
        {
            using(var stream = await FileSystem.OpenAppPackageFileAsync(source))
            {
                using(var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
