using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Serialization;
using System;
using System.Xml;

namespace TouchstoneClient
{
  public  class TouchstoneClientSent
    {
        //Single test scrip
        //static string FHIR_EndPoint = "http://touchstone.aegis.net:49917/fhir4-0-1/";

        //Test Suite endpoint
        static string FHIR_EndPoint = "http://touchstone.aegis.net:53114/fhir4-0-1/";

        FhirClient client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint);

        public TouchstoneClientSent()
        {
            //Add individual USER_KEY
            client.RequestHeaders.Add("USER_KEY", "[ENTER USERKEY]");
        }
        public string Send(string filePath)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            string xmlcontents = doc.InnerXml;

            var parser = new FhirXmlParser();

            try
            {
                var parsedPatient = parser.Parse<Bundle>(xmlcontents);

                var result = client.Create<Bundle>(parsedPatient).ToString();
                // Console.WriteLine("" + result.Id);
                Console.WriteLine("Working - send");
                return "ok";
            }
            catch (FormatException fe)
            {
                // error message
                Console.WriteLine("error" + fe);
                return "fail";
            }
        }
    }
}
