using TouchstoneClient;
using Xunit;

namespace TestTouchstoneTester
{
    public class Test_UF_H_V_11
    {
        [Fact]
        public void UF_H_V_11_ok()
        {
            TouchstoneClientSent touchstoneClient = new TouchstoneClientSent();

            Assert.Equal("ok", touchstoneClient.Send(@"https://raw.githubusercontent.com/MedComAnders/FHIRSandbox/master/FHIR4-0-1/401-Hospitalnotification/send/Userstory/_reference/resources/HospitalNotificationMessage-STIN-UF_H_V_10.xml"));
            Assert.Equal("ok", touchstoneClient.Send(@"https://raw.githubusercontent.com/MedComAnders/FHIRSandbox/master/FHIR4-0-1/401-Hospitalnotification/send/Userstory/_reference/resources/HospitalNotificationMessage-STOR-UF_H_V_10.xml"));
            Assert.Equal("ok", touchstoneClient.Send(@"https://raw.githubusercontent.com/MedComAnders/FHIRSandbox/master/FHIR4-0-1/401-Hospitalnotification/send/Userstory/_reference/resources/HospitalNotificationMessage-SLHJ-UF_H_V_10.xml"));




        }

    }
}
