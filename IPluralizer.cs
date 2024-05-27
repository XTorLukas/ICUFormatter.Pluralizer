// Copyright (c) 2024 Lukáš Laštůvka
// Licensed under the Apache-2.0 License. See the LICENSE.

namespace ICUFormatter.Pluralizer
{
    /// <summary>
    /// Represents a pluralizer for a specific enum type.
    /// </summary>
    /// <typeparam name="TEnum">The enum type for which the pluralizer is defined.</typeparam>
    public interface IPluralizer<TEnum>
    {
        /// <summary>
        /// Gets the enum value based on the given double value.
        /// </summary>
        /// <param name="value">The double value to determine the enum value.</param>
        /// <returns>The enum value corresponding to the given double value.</returns>
        TEnum Get(double value);
    }
}
