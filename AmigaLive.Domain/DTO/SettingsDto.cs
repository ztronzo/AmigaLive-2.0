using System.Collections.Generic;

namespace AmigaLive.Domain.DTO
{
    public class SettingsDto
    {
        public string Server { get; set; }
        public string IrcServer { get; set; }
        public string ServerGame { get; set; }
        public string LocalGame { get; set; }
        public string FavoritesGame { get; set; }
        public string Player { get; set; }
        public string PrefJoy { get; set; }
        public bool PlayOffline { get; set; }
        public int Players { get; set; }
        public bool InputGrab { get; set; }
        public string NameTag { get; set; }
        public string Password { get; set; }
        public bool FullScreen { get; set; }
        public bool VSync { get; set; }
        public bool KeepAspect { get; set; }
        public bool FrameBezel { get; set; }
        public bool ScanLines { get; set; }
        public int Zoom { get; set; }
        public int Shader { get; set; }
        public int FloppySoundVolume { get; set; }
        public int StereoSeparation { get; set; }
        public int SoundFrequency { get; set; }
        public int AudioBufferSize { get; set; }
        public string FsTheme { get; set; }
        public string HostPort { get; set; }
        public string Announce { get; set; }
        public string AmigaLiveTheme { get; set; }
        public string Background { get; set; }
        public int ShowBackground { get; set; }
        public bool SaveOnExit { get; set; }
        public bool BackgroundScanLines { get; set; }
        public bool AlwaysShowPingResult { get; set; }
        public bool CompactMode { get; set; }
        public int ChatWindowYSize { get; set; }
        public int MainWindowYSize { get; set; }
        public List<string> GameList { get; set; }
        public List<string> FavoriteGamesPlatinum { get; set; }
        public List<string> FavoriteGamesGold { get; set; }
        public List<string> FavoriteGamesBronze { get; set; }
        public List<string> CustomSettings { get; set; }
    }
}