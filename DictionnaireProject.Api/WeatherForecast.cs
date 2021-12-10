namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Temperatures
    {
        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("phonetic", NullValueHandling = NullValueHandling.Ignore)]
        public string Phonetic { get; set; }

        [JsonProperty("phonetics")]
        public Phonetic[] Phonetics { get; set; }

        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public string Origin { get; set; }

        [JsonProperty("meanings")]
        public Meaning[] Meanings { get; set; }
    }

    public partial class Meaning
    {
        [JsonProperty("partOfSpeech")]
        public string PartOfSpeech { get; set; }

        [JsonProperty("definitions")]
        public Definition[] Definitions { get; set; }
    }

    public partial class Definition
    {
        [JsonProperty("definition")]
        public string DefinitionDefinition { get; set; }

        [JsonProperty("example", NullValueHandling = NullValueHandling.Ignore)]
        public string Example { get; set; }

        [JsonProperty("synonyms")]
        public object[] Synonyms { get; set; }

        [JsonProperty("antonyms")]
        public object[] Antonyms { get; set; }
    }

    public partial class Phonetic
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public string Audio { get; set; }
    }
}
