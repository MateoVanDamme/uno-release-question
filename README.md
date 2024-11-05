I created a  new Uno Platform App app in visual studio using the Uno Platform extension (5.5.37.40).  It runs in debug on Windows/iOS/Android but in release it crashes only on iOS after showing the .NET loading screen.

Uno checks says everything is ok and I reinstalled visual studio 2022 to be sure.

### UNO Template Settings 
```
Framework: .NET 8.0 

Platforms to support: Android, iOS, Windows
Presentation: MVVM
Markup: XAML

Theme:
Theme: Fluent 
Theme Service

Extensions:
Extensions: Dependency Injection
Navigation: Blank
Logging: Serilog

Features: Toolkit.

Authentication: None

Testing: Unit Tests, UI test
Pipeline: None
```

**NOTE:** I modified the csproj file slightly. I added ``<ProvisioningType>manual</ProvisioningType>`` at the top. 

### UNO Check 1.26.1 output

```
> OpenJDK 11.0 Checkup...
  - 17.0.8.1 (C:\Program Files (x86)\Android\openjdk\jdk-17.0.8.101-hotspot\bin\..)
  - 11.0.20.1 (C:\Program Files\Microsoft\jdk-11.0.20.101-hotspot\bin\..)

> Visual Studio 17.11.0 Checkup...
  - 17.11.5 - C:\Program Files\Microsoft Visual Studio\2022\Enterprise

> Visual Studio Workloads Checkup...
  - .NET desktop development is installed (17.11.5)
  - .NET Multi-platform App UI development is installed (17.11.5)
  - ASP.NET and web development is installed (17.11.5)

> Android SDK Checkup...
  - emulator (32.1.15)
  - build-tools;34.0.0 (34.0.0)
  - platforms;android-34 (3)
  - system-images;android-34;google_apis;x86_64 (10)
  - platform-tools (35.0.2)
  - cmdline-tools;5.0 (5.0)

> Android Emulator Checkup...
  - Emulator: custom_tablet found.

> .NET SDK Checkup...
  - 8.0.201 - C:\Program Files\dotnet\sdk\8.0.201
  - 8.0.300 - C:\Program Files\dotnet\sdk\8.0.300
  - 8.0.402 - C:\Program Files\dotnet\sdk\8.0.402
  - 8.0.403 - C:\Program Files\dotnet\sdk\8.0.403

> PowerShell Execution Policy Checkup...

> Windows Python Installation Checkup...
  - Python is installed in C:\Users\MateoVanDamme\AppData\Local\Microsoft\WindowsApps\python.exe
.

> Windows Long Path Checkup...
  - Long paths are enabled on Windows!

> Git Checkup...
SHELL: git --version
git version 2.43.0.windows.1

> Windows Hyper-V Checkup...
  - Hyper-V is configured

> dotnet new Uno Project Command Line Templates Checkup...

> Uno SDK Checkup...

> Edge WebView2 Checkup...
  - Found Edge WebView2 version 130.0.2849.56

> .NET SDK - Workloads (8.0.401) Checkup...
  - microsoft.net.sdk.android (34.0.113/8.0.100) installed.
  - microsoft.net.sdk.ios (17.5.8020/8.0.100) installed.
  - microsoft.net.sdk.maccatalyst (17.5.8020/8.0.100) installed.
  - microsoft.net.sdk.macos (14.5.8020/8.0.100) installed.
  - microsoft.net.sdk.maui (8.0.72/8.0.100) installed.
───────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────

- Congratulations, everything looks great!
```

### PC Hardware Information
```
Device name	DESKTOP-DTM1H49
Processor	13th Gen Intel(R) Core(TM) i9-13900H   2.60 GHz
Installed RAM	32,0 GB (31,7 GB usable)
Device ID	27F92ED6-27C5-46A1-8AD6-4CEB480753B7
Product ID	00355-61186-10664-AAOEM
System type	64-bit operating system, x64-based processor
Pen and touch	Touch support with 10 touch points
```
### PC OS Information
```
Edition	Windows 11 Business
Version	23H2
Installed on	11/12/2023
OS build	22631.4391
Experience	Windows Feature Experience Pack 1000.22700.1047.0
```
### iPad information 
```
iPadOS Version: 17.7.1
Model Name iPad (10th generation)
```
### iPad logs
See iPadLog.txt file. 