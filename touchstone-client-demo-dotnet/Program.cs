using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using System;

namespace touchstone_client_demo_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            var pat = new Patient();
            pat.Name.Add(HumanName.ForFamily("Nancy Ann")
                    .WithGiven("Berggren"));
            pat.Id = "424";
            var id = new Identifier();
            id.System = "http://medcom.dk/cpr";
            id.Value = "2512489996";
            pat.Identifier.Add(id);

            //TS endpoint - returned a body with contentType text/html
            string FHIR_EndPoint = "http://touchstone.aegis.net:49917/fhir4-0-1/";

            var client = new Hl7.Fhir.Rest.FhirClient(FHIR_EndPoint);
            client.RequestHeaders.Add("USER_KEY", "[ENTER USERKEY]");


            client.Settings.PreferredFormat = ResourceFormat.Json;
            client.Create<Patient>(pat);

            Console.WriteLine("Patient created");
        }
    }
}
