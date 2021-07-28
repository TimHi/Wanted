using System;
namespace Services.DataService.FBIAPI.Model
{
    public class Person
    {
        public Person(string[] files = null, string age_range = null, string uid = null, string weight = null, string[] occupations = null,
            string[] field_offices = null, string[] locations = null, string reward_text = null, string hair = null, string ncic = null,
            string[] dates_of_birth_used = null, string caution = null, string nationality = null, string age_min = null, string age_max = null,
            string[] scars_and_marks = null, string[] subjects = null, string[] aliases = null, string race_raw = null, string[] suspects = null,
            string publication = null, string title = null, string[] coordinates = null, string hair_raw = null, string languages = null,
            string complexion = null, string build = null, string details = null, string status = null, string legal_names = null,
            string eyes = null, string person_classification = null, string description = null, string[] images = null,
            string possible_countries = null, string weight_min = null, string additional_information = null, string remarks = null,
            string path = null, string sex = null, string eyes_raw = null, string weight_max = null, string reward_min = null,
            string url = null, string possible_states = null, string modified = null, string reward_max = null, string race = null,
            string height_max = null, string place_of_birth = null, string height_min = null, string warning_message = null, string id = null)
        {
            this.files = files ?? null;
            this.age_range = age_range ?? null;
            this.uid = uid ?? null;
            this.weight = weight ?? null;
            this.occupations = occupations ?? null;
            this.field_offices = field_offices ?? null;
            this.locations = locations ?? null;
            this.reward_text = reward_text ?? null;
            this.hair = hair ?? null;
            this.ncic = ncic ?? null;
            this.dates_of_birth_used = dates_of_birth_used ?? null;
            this.caution = caution ?? null;
            this.nationality = nationality ?? null;
            this.age_min = age_min ?? null;
            this.age_max = age_max ?? null;
            this.scars_and_marks = scars_and_marks ?? null;
            this.subjects = subjects ?? null;
            this.aliases = aliases ?? null;
            this.race_raw = race_raw ?? null;
            this.suspects = suspects ?? null;
            this.publication = publication ?? null;
            this.title = title ?? null;
            this.coordinates = coordinates ?? null;
            this.hair_raw = hair_raw ?? null;
            this.languages = languages ?? null;
            this.complexion = complexion ?? null;
            this.build = build ?? null;
            this.details = details ?? null;
            this.status = status ?? null;
            this.legal_names = legal_names ?? null;
            this.eyes = eyes ?? null;
            this.person_classification = person_classification ?? null;
            this.description = description ?? null;
            this.images = images ?? null;
            this.possible_countries = possible_countries ?? null;
            this.weight_min = weight_min ?? null;
            this.additional_information = additional_information ?? null;
            this.remarks = remarks ?? null;
            this.path = path ?? null;
            this.sex = sex ?? null;
            this.eyes_raw = eyes_raw ?? null;
            this.weight_max = weight_max ?? null;
            this.reward_min = reward_min ?? null;
            this.url = url ?? null;
            this.possible_states = possible_states ?? null;
            this.modified = modified ?? null;
            this.reward_max = reward_max ?? null;
            this.race = race ?? null;
            this.height_max = height_max ?? null;
            this.place_of_birth = place_of_birth ?? null;
            this.height_min = height_min ?? null;
            this.warning_message = warning_message ?? null;
            this.id = id ?? null;
        }
#pragma warning disable IDE1006 // Naming Styles, disabled due to naming of JSON properties
        public string[] files { get; set; }
        public string age_range { get; set; }
        public string uid { get; set; }
        public string weight { get; set; }
        public string[] occupations { get; set; }
        public string[] field_offices { get; set; }
        public string[] locations { get; set; }
        public string reward_text { get; set; }
        public string hair { get; set; }
        public string ncic { get; set; }
        public string[] dates_of_birth_used { get; set; }
        public string caution { get; set; }
        public string nationality { get; set; }
        public string age_min { get; set; }
        public string age_max { get; set; }
        public string[] scars_and_marks { get; set; }
        public string[] subjects { get; set; }
        public string[] aliases { get; set; }
        public string race_raw { get; set; }
        public string[] suspects { get; set; }
        public string publication { get; set; }
        public string title { get; set; }
        public string[] coordinates { get; set; }
        public string hair_raw { get; set; }
        public string languages { get; set; }
        public string complexion { get; set; }
        public string build { get; set; }
        public string details { get; set; }
        public string status { get; set; }
        public string legal_names { get; set; }
        public string eyes { get; set; }
        public string person_classification { get; set; }
        public string description { get; set; }
        public string[] images { get; set; }
        public string possible_countries { get; set; }
        public string weight_min { get; set; }
        public string additional_information { get; set; }
        public string remarks { get; set; }
        public string path { get; set; }
        public string sex { get; set; }
        public string eyes_raw { get; set; }
        public string weight_max { get; set; }
        public string reward_min { get; set; }
        public string url { get; set; }
        public string possible_states { get; set; }
        public string modified { get; set; }
        public string reward_max { get; set; }
        public string race { get; set; }
        public string height_max { get; set; }
        public string place_of_birth { get; set; }
        public string height_min { get; set; }
        public string warning_message { get; set; }
        public string @id { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }
}
