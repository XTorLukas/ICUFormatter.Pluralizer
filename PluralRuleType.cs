// Copyright (c) 2024 Lukáš Laštůvka
// Licensed under the Apache-2.0 License. See the LICENSE.

namespace ICUFormatter.Pluralizer
{
    /// <summary>
    /// Enumeration representing different plural rules.
    /// </summary>
    public enum PluralRuleType
    {
        /// <summary>
        /// The default plural rule when no specific rule applies.
        /// </summary>
        Other = 0,

        /// <summary>
        /// Plural rule for the quantity zero.
        /// </summary>
        Zero,

        /// <summary>
        /// Plural rule for the quantity one.
        /// </summary>
        One,

        /// <summary>
        /// Plural rule for the quantity two.
        /// </summary>
        Two,

        /// <summary>
        /// Plural rule for a few quantities.
        /// </summary>
        Few,

        /// <summary>
        /// Plural rule for many quantities.
        /// </summary>
        Many
    }
}
