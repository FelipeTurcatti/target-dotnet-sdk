#pragma warning disable SA1636
/*
 * The MIT License (MIT)
 * Copyright (c) 2016 nager.at
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
namespace Adobe.Target.Client.Util.DomainParser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class UriNormalizer
    {
        public List<string> PartlyNormalizeDomainAndExtractFullyNormalizedParts(string domain, out string partlyNormalizedDomain)
        {
            partlyNormalizedDomain = null;

            if (string.IsNullOrEmpty(domain))
            {
                return null;
            }

            if (!domain.Contains("https://"))
            {
                domain = string.Concat("https://", domain);
            }

            if (!Uri.TryCreate(domain, UriKind.RelativeOrAbsolute, out Uri uri))
            {
                throw new ParseException("Cannot parse domain to an uri");
            }

            partlyNormalizedDomain = uri.Host;
            var normalizedHost = uri.GetComponents(UriComponents.NormalizedHost, UriFormat.UriEscaped);

            return normalizedHost
                .Split('.')
                .Reverse()
                .ToList();
        }
    }
}
#pragma warning restore SA1636
