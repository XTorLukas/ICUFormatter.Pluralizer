// Copyright (c) 2024 Lukáš Laštůvka
// Licensed under the Apache-2.0 License. See the LICENSE.

namespace ICUFormatter.Pluralizer
{
    /// <summary>
    /// Abstract base class for pluralizers. It implements the <see cref="IPluralizer{TEnum}"/> interface and provides common functionality.
    /// </summary>
    /// <typeparam name="TEnum">The type of enum to be pluralized.</typeparam>
    public abstract class PluralizerBase<TEnum> : IPluralizer<TEnum> where TEnum : Enum
    {
        /// <summary>
        /// Gets the condition function that determines the plural form based on the input value.
        /// </summary>
        protected abstract Func<double, TEnum> Condition { get; }

        /// <summary>
        /// Converts a given enum value to its corresponding string representation based on the provided rules.
        /// </summary>
        /// <param name="value">The enum value to convert.</param>
        /// <param name="rules">The rules dictionary that maps string representations to enum values.</param>
        /// <returns>The string representation of the enum value.</returns>
        public virtual string Convert(TEnum value, FrozenDictionary<string, TEnum> rules) =>
            rules.FirstOrDefault(r => r.Value.Equals(value)).Key;

        /// <summary>
        /// Converts a given string representation to its corresponding enum value based on the provided rules.
        /// </summary>
        /// <param name="value">The string representation to convert.</param>
        /// <param name="rules">The rules dictionary that maps string representations to enum values.</param>
        /// <returns>The enum value corresponding to the string representation.</returns>
        public virtual TEnum Convert(string value, FrozenDictionary<string, TEnum> rules) =>
            rules.TryGetValue(value, out var result) ? result : (TEnum)Enum.Parse(typeof(TEnum), "0".AsSpan());

        /// <summary>
        /// Gets the plural form of the enum based on the input value.
        /// </summary>
        /// <param name="value">The input value to determine the plural form.</param>
        /// <returns>The plural form of the enum.</returns>
        public abstract TEnum Get(double value);
    }
}