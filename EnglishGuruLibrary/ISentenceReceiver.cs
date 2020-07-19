using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishGuruLibrary
{
    public interface ISentenceReceiver
    {
        List<IPhrase> GetSentences(string phrase);
    }
}
