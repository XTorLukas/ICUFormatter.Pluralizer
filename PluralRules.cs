// Copyright (c) 2024 Lukáš Laštůvka
// Licensed under the Apache-2.0 License. See the LICENSE.

namespace ICUFormatter.Pluralizer
{
    /// <summary>
    /// Class containing plural rules for various languages.
    /// </summary>
    public static class PluralRules
    {
        /// <summary>
        /// Dictionary mapping language codes to their respective plural rule functions.
        /// Each function takes a double value representing the number and returns the appropriate plural rule.
        /// </summary>
        public static readonly FrozenDictionary<string, Func<double, PluralRuleType>> PluralRuleCondition = new Dictionary<string, Func<double, PluralRuleType>>()
        {
            { "af", n => PluralRuleType.Other },
            { "am", n => PluralRuleType.Other },
            { "ar", n => n == 0
                    ? PluralRuleType.Zero
                    : n == 1
                    ? PluralRuleType.One
                    : n == 2
                    ? PluralRuleType.Two
                    : n % 100000 is >= 3 and <= 10 ? PluralRuleType.Few : n % 100000 is >= 11 and <= 99999 ? PluralRuleType.Many : PluralRuleType.Other},
            { "as", n => PluralRuleType.Other },
            { "az", n => PluralRuleType.Other },
            { "be", n => n % 10 == 1 && n % 100 != 11
        ? PluralRuleType.One
        : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20)
        ? PluralRuleType.Few
        : n % 10 == 0 || (n % 10 >= 5 && n % 10 <= 9) || (n % 100 >= 11 && n % 100 <= 99999) ? PluralRuleType.Many : PluralRuleType.Other},
            { "bg", n => PluralRuleType.Other },
            { "bn", n => PluralRuleType.Other },
            { "br", n => n > 1 ? PluralRuleType.Other : PluralRuleType.One},
            { "bs", n => n % 10 == 1 && n % 100 != 11
                    ? PluralRuleType.One
                    : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? PluralRuleType.Few : PluralRuleType.Other},
            { "ca", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "cs", n => n == 1 ? PluralRuleType.One : n is >= 2 and <= 4 ? PluralRuleType.Few : PluralRuleType.Other},
            { "cy", n => n == 0
                    ? PluralRuleType.Zero
                    : n == 1 ? PluralRuleType.One : n == 2 ? PluralRuleType.Two : n == 3 ? PluralRuleType.Few : n == 6 ? PluralRuleType.Many : PluralRuleType.Other},
            { "da", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "de", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "dz", n => PluralRuleType.Other },
            { "el", n => PluralRuleType.Other },
            { "en", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "eo", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "es", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "et", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "eu", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "fa", n => PluralRuleType.Other },
            { "fi", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "fil", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "fo", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "fr", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "fur", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "fy", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "ga", n => n == 1
                    ? PluralRuleType.One
                    : n == 2 ? PluralRuleType.Two : n is >= 3 and <= 6 ? PluralRuleType.Few : n is >= 7 and <= 10 ? PluralRuleType.Many : PluralRuleType.Other},
            { "gl", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "gu", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "gv", n => n == 1 ? PluralRuleType.One : n == 2 ? PluralRuleType.Two : n is 3 or 4 ? PluralRuleType.Few : n == 5 ? PluralRuleType.Many : PluralRuleType.Other},
            { "ha", n => PluralRuleType.Other },
            { "he", n => n == 1 ? PluralRuleType.One : n == 2 ? PluralRuleType.Two : n is >= 3 and <= 10 ? PluralRuleType.Many : PluralRuleType.Other},
            { "hi", n => n is 0 or 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "hr", n => n % 10 == 1 && n % 100 != 11
                    ? PluralRuleType.One
                    : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? PluralRuleType.Few : PluralRuleType.Other},
            { "hu", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "hy", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "id", n => PluralRuleType.Other },
            { "ig", n => PluralRuleType.Other },
            { "is", n => n % 10 != 1 || n % 100 == 11 ? PluralRuleType.Other : PluralRuleType.One},
            { "it", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "iu", n => n == 1
                    ? PluralRuleType.One
                    : n == 2 ? PluralRuleType.Two : n is 3 or 4 or 6 ? PluralRuleType.Few : n is 7 or 8 ? PluralRuleType.Many : PluralRuleType.Other},
            { "ja", n => PluralRuleType.Other },
            { "jgo", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "jmc", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "jv", n => PluralRuleType.Other },
            { "ka", n => PluralRuleType.Other },
            { "kab", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : n == 2 ? PluralRuleType.Two : PluralRuleType.Other},
            { "kaj", n => PluralRuleType.Other },
            { "kcg", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "kde", n => PluralRuleType.Other },
            { "kea", n => PluralRuleType.Other },
            { "kk", n => PluralRuleType.Other },
            { "kkj", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "kl", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "kn", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "ko", n => PluralRuleType.Other },
            { "ks", n => PluralRuleType.Other },
            { "ksb", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "ksh", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "ku", n => PluralRuleType.Other },
            { "kw", n => n == 1 ? PluralRuleType.One : n == 2 ? PluralRuleType.Two : n == 3 ? PluralRuleType.Few : n == 4 ? PluralRuleType.Many : PluralRuleType.Other},
            { "ky", n => PluralRuleType.Other },
            { "lag", n => n == 0 ? PluralRuleType.Zero : n is (0 or 1)and not 0 ? PluralRuleType.One : PluralRuleType.Other},
            { "lb", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "lg", n => PluralRuleType.Other },
            { "ln", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "lt", n => n % 10 == 1 && (n % 100 < 11 || n % 100 > 19)
                    ? PluralRuleType.One
                    : n % 10 >= 2 && n % 10 <= 9 && (n % 100 < 11 || n % 100 > 19) ? PluralRuleType.Few : PluralRuleType.Other},
            { "lv", n => n % 10 == 0 || (n % 100 >= 11 && n % 100 <= 19) ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "mas", n => PluralRuleType.Other },
            { "mg", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "mgo", n => n is 1 or 2 ? PluralRuleType.One : PluralRuleType.Other},
            { "mk", n => n % 10 == 1 && n != 11 ? PluralRuleType.One : PluralRuleType.Other},
            { "ml", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "mn", n => n % 10 == 1 && n % 100 != 11 ? PluralRuleType.One : PluralRuleType.Other},
            { "mo", n => n == 1 ? PluralRuleType.One : n == 0 || (n % 100 >= 1 && n % 100 <= 19) ? PluralRuleType.Few : PluralRuleType.Other},
            { "mr", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "ms", n => PluralRuleType.Other },
            { "mt", n => n == 1
                    ? PluralRuleType.One
                    : n == 0 || (n % 100 > 1 && n % 100 < 11) ? PluralRuleType.Few : n % 100 is > 10 and < 20 ? PluralRuleType.Many : PluralRuleType.Other},
            { "my", n => PluralRuleType.Other },
            { "nah", n => PluralRuleType.Other },
            { "naq", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "nb", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "nd", n => PluralRuleType.Other },
            { "ne", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "nl", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "nn", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "nnh", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "no", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "nqo", n => PluralRuleType.Other },
            { "nr", n => PluralRuleType.Other },
            { "nso", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "ny", n => PluralRuleType.Other },
            { "nyn", n => PluralRuleType.Other },
            { "om", n => PluralRuleType.Other },
            { "or", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "os", n => PluralRuleType.Other },
            { "pa", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "pap", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "pl", n => n == 1 ? PluralRuleType.One : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 12 || n % 100 > 14) ? PluralRuleType.Few : PluralRuleType.Other},
            { "prg", n => n % 10 == 1 && n % 100 != 11
                    ? PluralRuleType.One
                    : n % 10 >= 2 && n % 10 <= 9 && (n % 100 < 10 || n % 100 >= 20) ? PluralRuleType.Few : PluralRuleType.Other},
            { "ps", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "pt", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "pt_PT", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "rm", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "ro", n => n == 1 ? PluralRuleType.One : n == 0 || (n % 100 > 0 && n % 100 < 20) ? PluralRuleType.Few : PluralRuleType.Other},
            { "rof", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "root", n => PluralRuleType.Other },
            { "ru", n => n % 10 == 1 && n % 100 != 11
                    ? PluralRuleType.One
                    : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? PluralRuleType.Few : PluralRuleType.Other},
            { "rwk", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "sah", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "saq", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "sat", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "sbp", n => PluralRuleType.Other },
            { "sd", n => PluralRuleType.Other },
            { "se", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "seh", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "ses", n => PluralRuleType.Other },
            { "sg", n => PluralRuleType.Other },
            { "sh", n => n % 10 == 1 && n % 100 != 11
                    ? PluralRuleType.One
                    : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? PluralRuleType.Few : PluralRuleType.Other},
            { "shi", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : n is >= 2 and <= 10 ? PluralRuleType.Few : PluralRuleType.Other},
            { "si", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "sk", n => n == 1 ? PluralRuleType.One : n is >= 2 and <= 4 ? PluralRuleType.Few : PluralRuleType.Other},
            { "sl", n => n % 100 == 1 ? PluralRuleType.One : n % 100 == 2 ? PluralRuleType.Two : n % 100 is >= 3 and <= 4 ? PluralRuleType.Few : PluralRuleType.Other},
            { "sma", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "smi", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "smj", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "smn", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "sms", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "sn", n => PluralRuleType.Other },
            { "so", n => PluralRuleType.Other },
            { "sq", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "sr", n => n % 10 == 1 && n % 100 != 11
                    ? PluralRuleType.One
                    : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? PluralRuleType.Few : PluralRuleType.Other},
            { "ss", n => PluralRuleType.Other },
            { "ssy", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "st", n => PluralRuleType.Other },
            { "sv", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "sw", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "syr", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "ta", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "te", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "teo", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "th", n => PluralRuleType.Other },
            { "ti", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "tig", n => n == 0 ? PluralRuleType.Zero : n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "tk", n => PluralRuleType.Other },
            { "tl", n => n is 1 or 2 ? PluralRuleType.One : PluralRuleType.Other},
            { "tn", n => PluralRuleType.Other },
            { "to", n => PluralRuleType.Other },
            { "tr", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "ts", n => PluralRuleType.Other },
            { "tzm", n => n is 0 or 1 or 11 or 2 or 12 ? PluralRuleType.One : PluralRuleType.Other},
            { "ug", n => PluralRuleType.Other },
            { "uk", n => n % 10 == 1 && n % 100 != 11
                    ? PluralRuleType.One
                    : n % 10 >= 2 && n % 10 <= 4 && (n % 100 < 10 || n % 100 >= 20) ? PluralRuleType.Few : PluralRuleType.Other},
            { "ur", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "uz", n => PluralRuleType.Other },
            { "ve", n => PluralRuleType.Other },
            { "vi", n => PluralRuleType.Other },
            { "vo", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "vun", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "wa", n => n == 0
                    ? PluralRuleType.Zero
                    : n == 1
                    ? PluralRuleType.One
                    : n == 2 ? PluralRuleType.Two : n == 3 ? PluralRuleType.Few : n is 4 or 5 or (>= 6 and <= 8)? PluralRuleType.Many : PluralRuleType.Other},
            { "wae", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "wo", n => PluralRuleType.Other },
            { "xh", n => PluralRuleType.Other },
            { "xog", n => PluralRuleType.Other },
            { "yi", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "yo", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
            { "yue", n => PluralRuleType.Other },
            { "zh", n => PluralRuleType.Other },
            { "zu", n => n == 1 ? PluralRuleType.One : PluralRuleType.Other},
        }.ToFrozenDictionary();
    }
}
