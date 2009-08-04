/*
* IImmutableDictionary.cs is part of functional-dotnet project
* 
* Copyright (c) 2008-2009 Alexey Romanov
* All rights reserved.
*
* This source file is available under The New BSD License.
* See license.txt file for more information.
* 
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND 
* CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, 
* INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF 
* MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
*/

using System;
using System.Collections.Generic;
using FP.Core;

namespace FP.Collections.Persistent {
    /// <summary>
    /// Represents an immutable collection of key/value pairs.
    /// </summary>
    /// <typeparam name="TKey">The type of keys.</typeparam>
    /// <typeparam name="TValue">The type of values.</typeparam>
    /// <typeparam name="TDictionary">The type of the dictionary.</typeparam>
    /// <seealso cref="System.Collections.Generic.IDictionary{TKey,TValue}"/>
    public interface IDictionary<TKey, TValue, TDictionary> : ICollection<Tuple<TKey, TValue>>
        where TDictionary : IDictionary<TKey, TValue, TDictionary> {
        /// <summary>
        /// Gets the number of elements in the dictionary.
        /// </summary>
        /// <value>The count.</value>
        int Count { get; }

        /// <summary>
        /// Looks up the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <value><see cref="Optional.Some{T}"/><c>(value)</c> if the
        /// dictionary contains the specified key and associates <c>value</c>
        /// to it and <see cref="Optional.None{T}"/> otherwise.</value>
        Optional<TValue> this[TKey key] { get; }

        /// <summary>
        /// Adds the specified key with the specified value.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="combiner">
        /// The function to be called if the given key is already present. The
        /// argument is the value currently associated with the key, the result is the value
        /// to be used in the new dictionary.
        /// </param>
        /// <returns>
        /// The resulting dictionary.
        /// </returns>
        TDictionary Add(TKey key, TValue value, Func<TValue, TValue> combiner);

        /// <summary>
        /// Adds the specified key with the specified value. If the key is
        /// already present, replaces the current value.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The resulting dictionary.
        /// </returns>
        TDictionary Add(TKey key, TValue value);

        /// <summary>
        /// Removes the specified key and the associated value. If the
        /// dictionary doesn't contain this key, it is returned unchanged.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>The resulting dictionary.</returns>
        TDictionary Remove(TKey key);

        /// <summary>
        /// Updates the specified key with the given function. If the dictionary
        /// doesn't contain the key, it is returned unchanged; if 
        /// <code>updater(key, currentValue)</code> returns <code>None</code>, the key is removed;
        /// if it returns <code>Some(newValue)</code>, the current value is replaced with newValue.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="updater">The updating function.</param>
        /// <returns>The resulting dictionary.</returns>
        TDictionary Update(TKey key, Func<TKey, TValue, Optional<TValue>> updater);

        /// <summary>
        /// Updates the specified key with the given function.  If the
        /// dictionary doesn't contain the key, <code>updater(key, None)</code>
        /// is called to provide the new value; if it does, 
        /// <code>updater(key, Some(currentValue))</code> is. If the call
        /// returns <code>None</code>, the key is removed; if it returns 
        /// <code>Some(newValue)</code>, the key is associated with newValue.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="updater">The updating function.</param>
        /// <returns>The resulting dictionary.</returns>
        TDictionary Update(TKey key, Func<TKey, Optional<TValue>, Optional<TValue>> updater);

        /// <summary>
        /// Adds the specified key with the specified value.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <param name="combiner">
        /// The function to be called if the given key is already present. The
        /// arguments are the key, the current value, and the added value. The
        /// result is inserted in place of the current value.
        /// </param>
        /// <returns>
        /// The resulting dictionary.
        /// </returns>
        Tuple<TDictionary, Optional<TValue>> LookupAndUpdate(
            TKey key, TValue value, Func<TKey, Optional<TValue>, TValue, Optional<TValue>> combiner);

        /// <summary>
        /// Gets the keys. Doesn't guarantee anything about the order in which they are yielded.
        /// </summary>
        /// <value>The keys.</value>
        IEnumerable<TKey> Keys { get; }

        /// <summary>
        /// Gets the values. Doesn't guarantee anything about the order in which they are yielded.
        /// </summary>
        /// <value>The values.</value>
        IEnumerable<TValue> Values { get; }
    }
}