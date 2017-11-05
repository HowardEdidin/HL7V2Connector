/* 
 * MIT License

* Copyright 2017 Howard S. Edidn

* Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

* The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
* 
 */




namespace HL7Version2xParser
{
    using System.Xml;
    using System.Xml.Linq;

    public static class DocumentExtensions
    {
        /// <summary>
        /// To the XML document.
        /// </summary>
        /// <param name="xDocument">The x document.</param>
        /// <returns></returns>
        public static XmlDocument ToXmlDocument(this XDocument xDocument)
        {
            var xmlDocument = new XmlDocument();
            using (var xmlReader = xDocument.CreateReader())
            {
                xmlDocument.Load(xmlReader);
            }

            var xDeclaration = xDocument.Declaration;
            if (xDeclaration == null) return xmlDocument;
            var xmlDeclaration = xmlDocument.CreateXmlDeclaration(
                xDeclaration.Version,
                xDeclaration.Encoding,
                xDeclaration.Standalone);

            xmlDocument.InsertBefore(xmlDeclaration, xmlDocument.FirstChild);


            return xmlDocument;
        }


        /// <summary>
        /// To the x document.
        /// </summary>
        /// <param name="xmlDocument">The XML document.</param>
        /// <returns></returns>
        public static XDocument ToXDocument(this XmlDocument xmlDocument)
        {
            using (var nodeReader = new XmlNodeReader(xmlDocument))
            {
                nodeReader.MoveToContent();
                return XDocument.Load(nodeReader);
            }
        }
    }
}