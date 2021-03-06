; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Zepcode Barcode Printing"
#define MyAppVersion "1.5"
#define MyAppPublisher "Zeptoa It Solutions"
#define MyAppURL "http://www.zeptoa.com/"
#define MyAppExeName "Barcode Print.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{C11C01AD-D32F-49E8-B74D-01377E47CFE3}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
OutputBaseFilename=setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\Barcode Print.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\Barcode Print.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\Barcode Print.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\Barcode Print.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\Barcode Print.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\BarcodeLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\Google.Protobuf.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\Google.Protobuf.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\IronBarCode.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\IronBarCode.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\MySql.Data.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\MySql.Data.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\Newtonsoft.Json.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\Newtonsoft.Json.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\sheik\source\repos\BarcodePrint\BarcodePrint\bin\Debug\Newtonsoft.Json.xml"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{group}\{cm:UninstallProgram,{#MyAppName}}"; Filename: "{uninstallexe}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
