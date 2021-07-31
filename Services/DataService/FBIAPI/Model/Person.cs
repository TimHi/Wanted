using System;
using System.Collections.Generic;

namespace Services.DataService.FBIAPI.Model
{
#pragma warning disable IDE1006 // Naming Styles, disabled due to naming of JSON properties
    public class File
    {
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Image
    {
        public string large { get; set; }
        public string caption { get; set; }
        public string thumb { get; set; }
        public string original { get; set; }
    }

    public class Person
    {
        public IList<File> files { get; set; }
        public string age_range { get; set; }
        public string uid { get; set; }
        public string weight { get; set; }
        public object occupations { get; set; }
        public IList<string> field_offices { get; set; }
        public object locations { get; set; }
        public string reward_text { get; set; }
        public string hair { get; set; }
        public string ncic { get; set; }
        public IList<string> dates_of_birth_used { get; set; }
        public string caution { get; set; }
        public string nationality { get; set; }
        public int? age_min { get; set; }
        public int? age_max { get; set; }
        public string scars_and_marks { get; set; }
        public IList<string> subjects { get; set; }
        public IList<string> aliases { get; set; }
        public string race_raw { get; set; }
        public object suspects { get; set; }
        public DateTime publication { get; set; }
        public string title { get; set; }
        public IList<object> coordinates { get; set; }
        public string hair_raw { get; set; }
        public object languages { get; set; }
        public object complexion { get; set; }
        public object build { get; set; }
        public string details { get; set; }
        public string status { get; set; }
        public object legat_names { get; set; }
        public string eyes { get; set; }
        public string person_classification { get; set; }
        public string description { get; set; }
        public IList<Image> images { get; set; }
        public object possible_countries { get; set; }
        public int? weight_min { get; set; }
        public string additional_information { get; set; }
        public string remarks { get; set; }
        public string path { get; set; }
        public string sex { get; set; }
        public string eyes_raw { get; set; }
        public int? weight_max { get; set; }
        public int reward_min { get; set; }
        public string url { get; set; }
        public object possible_states { get; set; }
        public DateTime modified { get; set; }
        public int reward_max { get; set; }
        public string race { get; set; }
        public int? height_max { get; set; }
        public string place_of_birth { get; set; }
        public int? height_min { get; set; }
        public string warning_message { get; set; }
        public string @id { get; set; }
    }

    public class Example
    {
        public int total { get; set; }
        public IList<Person> items { get; set; }
        public int page { get; set; }
    }
#pragma warning restore IDE1006 // Naming Styles

}
