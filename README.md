# SoulStrap

A Roblox bootstrapper built with C# (.NET 8 / WinForms) featuring:
- **FastFlag Editor** — edit `ClientAppSettings.json` with presets (FPS unlock, lighting, rendering modes, etc.)
- **Roblox Launcher** — launch Roblox directly, auto-detects install path
- **Auto-Updater** — checks GitHub releases for new SoulStrap versions
- **Dark/Light Theme** — dark blue Bloxstrap-inspired UI with full theme toggle

---

## 🔨 Build Instructions

### Requirements
- Windows 10/11
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Steps

```bash
# 1. Clone or extract this folder
cd SoulStrap

# 2. Restore NuGet packages
dotnet restore

# 3. Build (debug)
dotnet build

# 4. Run
dotnet run

# 5. Publish as single .exe
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o ./publish
```

The final `.exe` will be in `./publish/SoulStrap.exe`

---

## 📁 Project Structure

```
SoulStrap/
├── Program.cs                  # Entry point
├── SoulStrap.csproj
├── Controls/
│   └── SoulControls.cs         # Custom UI controls (buttons, panels, badges)
├── Forms/
│   └── MainForm.cs             # Main window with sidebar navigation
├── Managers/
│   ├── ThemeManager.cs         # Dark/light theme + settings persistence
│   ├── FastFlagManager.cs      # FastFlag read/write + presets
│   ├── RobloxManager.cs        # Roblox launcher + path detection
│   └── AutoUpdater.cs          # GitHub release update checker
```

---

## ⚙️ FastFlag Presets Included

| Category   | Presets |
|------------|---------|
| FPS        | Unlock 240, Unlock Unlimited, Show FPS Counter |
| Rendering  | Vulkan, OpenGL, D3D11 |
| Lighting   | Future, Shadowmap, Voxel, Disable Shadows |
| Graphics   | Low / High Quality override |
| Texture    | Low / High quality |
| UI         | Disable Ads, Old Chat, Disable Telemetry |

---

## 🔧 Customization

- **Auto-update repo**: Edit `GitHubApiUrl` in `Managers/AutoUpdater.cs` to point to your GitHub repo.
- **Add FastFlag presets**: Add entries to the `Presets` dictionary in `Managers/FastFlagManager.cs`.
- **Colors**: All colors are in `Managers/ThemeManager.cs`.

---

## ⚠️ Disclaimer

SoulStrap is not affiliated with Roblox Corporation. Use FastFlags at your own risk.
