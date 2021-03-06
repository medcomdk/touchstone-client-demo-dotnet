using TouchstoneClient;
using Xunit;

namespace TestTouchstoneTester
{
    public class Test_UF_H_V_17
    {
        [Fact]
        public void UF_H_V_17_ok()
        {
            TouchstoneClientSent touchstoneClient = new TouchstoneClientSent();

            Assert.Equal("ok", touchstoneClient.Send(@"https://raw.githubusercontent.com/MedComAnders/FHIRSandbox/master/FHIR4-0-1/401-Hospitalnotification/send/Userstory/_reference/resources/HospitalNotificationMessage-STAA-UF_H_V_7.xml"));
            Assert.Equal("ok", touchstoneClient.Send(@"https://raw.githubusercontent.com/MedComAnders/FHIRSandbox/master/FHIR4-0-1/401-Hospitalnotification/send/Userstory/_reference/resources/HospitalNotificationMessage-STIN-UF_H_V_17.xml"));

        }

    }
}
