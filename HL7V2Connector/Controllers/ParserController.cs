#region Information

// Solution:  HL7V2Connector
// HL7V2Connector
// File:  ParserController.cs
// 
// Created: 09/06/2017 : 3:28 PM
// 
// Modified By: Howard Edidin
// Modified:  11/05/2017 : 12:39 PM

#endregion

#region Information

// Solution:  HL7V2Connector
// HL7V2Connector
// File:  ParserController.cs
// 
// Created: 09/06/2017 : 3:28 PM
// 
// Modified By: Howard Edidin
// Modified:  11/05/2017 : 10:41 AM

#endregion

namespace HL7V2Connector.Controllers
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using Models;
    using Swashbuckle.Swagger.Annotations;
    using TRex.Metadata;

    public class ParserController : ApiController
    {
        [HttpPost]
        [Metadata("ConvertToXml", "Converts HL7 v2.x string to HL7 v2.x XML string")]
        [SwaggerOperation("ConvertToXml")]
        [SwaggerResponse(HttpStatusCode.BadRequest, "Input is not an HL7 v2.x file ")]
        public HttpResponseMessage ConvertToXml(
            [FromBody] [Metadata("HL7 Flat File string", "Must have all 'carriage returns and linefeeds' escaped. \r\n  Must be a single line of text")] string hl7)
        {
            

            var parse = new Parser();

            var response = new HttpResponseMessage();

            var xDocument = parse.Parse(hl7);

            if (xDocument == null)
            {
                response.StatusCode = HttpStatusCode.BadRequest;
                response.Content = new StringContent("Input is not an HL7 v2.x file");
                return response;
            }


            var xmlDocument = xDocument.ToXmlDocument();

            response.StatusCode = HttpStatusCode.OK;
            response.Content = new StringContent(xmlDocument.InnerXml);


            return response;
        }
    }
}