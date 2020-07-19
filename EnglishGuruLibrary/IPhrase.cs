using System.Collections.Generic;

namespace EnglishGuruLibrary
{
    public interface IPhrase
    {
        Dictionary<Language, string> Translations { get; set; }
        Dictionary<Language, string> ContextSentences { get; set; }
    }
}
