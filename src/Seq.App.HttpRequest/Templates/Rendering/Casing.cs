﻿// Copyright Serilog Contributors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Seq.App.HttpRequest.Templates.Rendering
{
    static class Casing
    {
        /// <summary>
        /// Apply upper or lower casing to <paramref name="value"/> when <paramref name="format"/> is provided.
        /// Returns <paramref name="value"/> when no or invalid format provided.
        /// </summary>
        /// <param name="value">Provided string for formatting.</param>
        /// <param name="format">Format string.</param>
        /// <returns>The provided <paramref name="value"/> with formatting applied.</returns>
        public static string Format(string value, string? format = null)
        {
            switch (format)
            {
                case "u":
                    return value.ToUpperInvariant();
                case "w":
                    return value.ToLowerInvariant();
                default:
                    return value;
            }
        }
    }
}
