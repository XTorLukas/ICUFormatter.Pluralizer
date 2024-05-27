// Copyright (c) 2024 Lukáš Laštůvka
// Licensed under the Apache-2.0 License. See the LICENSE.

namespace ICUFormatter.Pluralizer
{
    /// <summary>
    /// A class representing a pluralizer that can convert plural rules to their corresponding enum values.
    /// </summary>
    public class @Pluralizer : PluralizerBase<PluralRuleType>
    {
        // Static frozen dictionary to store plural rules and their corresponding enum values.
        private static readonly FrozenDictionary<string, PluralRuleType> _rules = new Dictionary<string, PluralRuleType>(StringComparer.InvariantCultureIgnoreCase)
        {
            ["other"] = PluralRuleType.Other,
            ["zero"] = PluralRuleType.Zero,
            ["one"] = PluralRuleType.One,
            ["two"] = PluralRuleType.Two,
            ["few"] = PluralRuleType.Few,
            ["many"] = PluralRuleType.Many,
        }.ToFrozenDictionary();

        /// <summary>
        /// Initializes a new instance of the <see cref="Pluralizer"/> class.
        /// </summary>
        /// <param name="culture">The culture for which the plural rules should be applied. Defaults to <b>en</b>.</param>
        public @Pluralizer(string culture = "en")
        {
            if (string.IsNullOrEmpty(culture))
                return;

            if (PluralRules.PluralRuleCondition.TryGetValue(culture, out var condition))
                Condition = condition;
        }

        /// <inheritdoc />
        protected override Func<double, PluralRuleType> Condition { get; } = n => PluralRuleType.Other;

        /// <inheritdoc />
        public override PluralRuleType Get(double value) => Condition(value);

        /// <inheritdoc cref="PluralizerBase{TEnum}.Convert(string, FrozenDictionary{string, TEnum})"/>
        public PluralRuleType Convert(string value) => base.Convert(value, _rules);

        /// <inheritdoc cref="PluralizerBase{TEnum}.Convert(TEnum, FrozenDictionary{string, TEnum})"/>
        public ReadOnlySpan<char> Convert(PluralRuleType value) => base.Convert(value, _rules);
    }
}
