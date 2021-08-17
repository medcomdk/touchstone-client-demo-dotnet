using TouchstoneClient;
using Xunit;

namespace TestTouchstoneTester
{
    public class Test_UF_H_V_20
    {
        [Fact]
        public void UF_H_V_20_ok()
        {
            TouchstoneClientSent touchstoneClient = new TouchstoneClientSent();

            Assert.Equal("ok", touchstoneClient.Send(@"https://raw.githubusercontent.com/MedComAnders/FHIRSandbox/master/FHIR4-0-1/401-Hospitalnotification/send/Userstory/_reference/resources/HospitalNotificationMessage-STIN-UF_H_V_20.xml"));
            Assert.Equal("ok", touchstoneClient.Send(@"https://raw.githubusercontent.com/MedComAnders/FHIRSandbox/master/FHIR4-0-1/401-Hospitalnotification/send/Userstory/_reference/resources/HospitalNotificationMessage-STOR-UF_H_V_20.xml"));
            Assert.Equal("ok", touchstoneClient.Send(@"https://raw.githubusercontent.com/MedComAnders/FHIRSandbox/master/FHIR4-0-1/401-Hospitalnotification/send/Userstory/_reference/resources/HospitalNotificationMessage-SLOR-UF_H_V_20.xml"));
            Assert.Equal("ok", touchstoneClient.Send(@"https://raw.githubusercontent.com/MedComAnders/FHIRSandbox/master/FHIR4-0-1/401-Hospitalnotification/send/Userstory/_reference/resources/HospitalNotificationMessage-MORS-UF_H_V_20.xml"));

        }

    }
}
