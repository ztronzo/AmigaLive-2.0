using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using AmigaLive.Domain.DTO;

namespace AmigaLive.Domain
{
    public class Service
    {
        private const string NetPlaySettingsFile = "AmigaLive.json";
        private const string SettingsFile = "Settings.json";
        private bool _isLinux = RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
        private bool _isMac = RuntimeInformation.IsOSPlatform(OSPlatform.OSX);
        private bool _isWindows = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        public static SettingsDto LoadSettings()
        {
            var result = new SettingsDto();
            var filename = GetSettingsFilename();
            if (!File.Exists(filename)) return result;

            var jsonString = File.ReadAllText(filename);
            result = JsonSerializer.Deserialize<SettingsDto>(jsonString);
            return result;
        }

        public static void SaveSettings(SettingsDto settings)
        {
            var filename = GetSettingsFilename();
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(settings, options);
            try
            {
                File.WriteAllText(filename, jsonString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static string GetSettingsFilename()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), SettingsFile);
        }
    }
}