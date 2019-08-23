using System;
using System.Collections.Generic;
using System.Text;

namespace Azure.Ai.Language.TextAnalytics
{
    public struct UnknownLanguageDocument
    {
        public string CountryHint { get; set; }

        public string Id { get; set; }

        public string Text { get; set; }
    }
}
