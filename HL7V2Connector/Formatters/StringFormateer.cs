/* 
 * MIT License

* Copyright 2017 Howard S. Edidn

* Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

* The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
* 
 */

#region Information

// Solution:  HL7V2Connector
// HL7V2Connector
// File:  StringFormateer.cs
// 
// Created: 09/06/2017 : 4:42 PM
// 
// Modified By: Howard Edidin
// Modified:  11/05/2017 : 10:35 AM

#endregion

namespace HL7V2Connector.Formatters
{
    using System;
    using System.Net.Http.Formatting;
    using System.Net.Http.Headers;

    /// <inheritdoc />
    /// <summary>
    /// </summary>
    /// <seealso cref="T:System.Net.Http.Formatting.MediaTypeFormatter" />
    public class StringFormateer : MediaTypeFormatter
    {
        /// <inheritdoc />
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:HL7V2Connector.Formatters.StringFormateer" /> class.
        /// </summary>
        public StringFormateer()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/xml"));
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/plain"));
        }


        #region Overrides of MediaTypeFormatter

        public override bool CanReadType(Type type)
        {
            return true;
        }

        public override bool CanWriteType(Type type)
        {
            return true;
        }

        #endregion
    }
}