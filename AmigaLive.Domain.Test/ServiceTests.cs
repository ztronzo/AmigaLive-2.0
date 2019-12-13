using System.IO;
using AmigaLive.Domain.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmigaLive.Domain.Test
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void TestSettingsFilename_DefaultFilename()
        {
            var result = Service.GetSettingsFilename();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(string));
        }

        [TestMethod]
        public void TestLoadSettings_EmptyDto()
        {
            var result = Service.LoadSettings();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(SettingsDto));
            Assert.IsNull(result.GameList);
        }

        [TestMethod]
        public void TestSaveSettings_NoException()
        {
            var settings = new SettingsDto();
            var expectedFilename = Path.Combine(Directory.GetCurrentDirectory(), "Settings.json");

            Service.SaveSettings(settings);

            Assert.IsTrue(File.Exists(expectedFilename));
        }
    }
}