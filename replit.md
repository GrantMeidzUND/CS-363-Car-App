# CS 363 Car Dashboard App

## Project Overview
This is a C# Windows Forms desktop application that simulates a car dashboard. The application was originally developed for Windows using Visual Studio and has been successfully ported to run on Replit using Mono.

## Project Type
- **Language**: C# (Mono compatible)
- **Framework**: .NET Framework 4.8 API (Mono implementation)
- **GUI Framework**: Windows Forms
- **Display**: VNC (Virtual Network Computing) for GUI rendering

## Features
The application includes three main forms:
1. **carApp (Form1)**: Main car dashboard interface with vehicle controls and monitoring
2. **controllerForm (Form2)**: Controller interface for managing car operations
3. **addDriverForm (Form3)**: Form to add and manage driver information

## Running the Application

The application runs automatically when you start the Repl. The GUI is displayed through VNC in the Replit viewer.

To manually restart the application:
1. Stop the current workflow if running
2. Click the "Run" button or restart the workflow

The workflow command is:
```bash
DISPLAY=:0 mono "bin/Debug/CS 363 Car App.exe"
```

## Building the Application

The application is compiled using the Mono C# compiler (mcs). If you need to rebuild after making changes:

```bash
# Compile resource files
resgen2 Form1.resx "obj/Form1.resources"
resgen2 Form2.resx "obj/Form2.resources"
resgen2 Form3.resx "obj/Form3.resources"
cd Properties && resgen2 "Resources.resx" "../obj/CS_363_Car_App.Properties.Resources.resources" && cd ..

# Compile the application
mcs -target:winexe \
    -out:"bin/Debug/CS 363 Car App.exe" \
    -sdk:4.8 \
    -r:System.Windows.Forms \
    -r:System.Drawing \
    -r:System.Data \
    -r:System.Xml \
    -r:System.Core \
    -r:System.Xml.Linq \
    -r:System.Data.DataSetExtensions \
    -r:Microsoft.CSharp \
    -r:System.Net.Http \
    -r:System.Deployment \
    -resource:"obj/Form1.resources","CS_363_Car_App.carApp.resources" \
    -resource:"obj/Form2.resources","CS_363_Car_App.controllerForm.resources" \
    -resource:"obj/Form3.resources","CS_363_Car_App.addDriverForm.resources" \
    -resource:"obj/CS_363_Car_App.Properties.Resources.resources","CS_363_Car_App.Properties.Resources.resources" \
    Program.cs Form1.cs Form1.Designer.cs Form2.cs Form2.Designer.cs \
    Form3.cs Form3.Designer.cs Properties/AssemblyInfo.cs \
    Properties/Resources.Designer.cs Properties/Settings.Designer.cs
```

## Project Structure

```
/
├── CS 363 Car App.sln          # Visual Studio solution file
├── CS 363 Car App.csproj       # Project file
├── Program.cs                  # Application entry point
├── Form1.cs / Form1.Designer.cs / Form1.resx     # Main car dashboard form
├── Form2.cs / Form2.Designer.cs / Form2.resx     # Controller form
├── Form3.cs / Form3.Designer.cs / Form3.resx     # Add driver form
├── Properties/
│   ├── AssemblyInfo.cs         # Assembly metadata
│   ├── Resources.Designer.cs   # Generated resource accessor
│   ├── Resources.resx          # Resource definitions
│   ├── Settings.Designer.cs    # Application settings
│   └── Settings.settings       # Settings configuration
├── Resources/
│   ├── car pic.jpg             # Car image resource
│   └── map_pic.jpg             # Map image resource
├── bin/Debug/
│   └── CS 363 Car App.exe      # Compiled executable
└── obj/                        # Compiled resource files
```

## Technical Details

### Mono Compatibility
This application uses Mono to run .NET Framework code on Linux:
- Mono version: 6.14.1
- Target framework: .NET Framework 4.8 API
- Compiler: mcs (Mono C# compiler)

### VNC Display
The application runs in a VNC environment because it's a GUI desktop application:
- VNC provides a virtual X11 display server
- The DISPLAY environment variable is set to :0
- You can interact with the GUI through Replit's VNC viewer

### Known Issues
- GTK warning: "Gtk not found (missing LD_LIBRARY_PATH to libgtk-x11-2.0.so.0?), using built-in colorscheme" - This is a cosmetic warning and doesn't affect functionality. Mono falls back to its built-in color scheme.

## Dependencies

### System Dependencies
- mono (6.14.1)
- gtk3 (for GUI rendering)
- X11 libraries (libX11, libXext, libXrender)
- tigervnc (for VNC display)

### .NET References
- System
- System.Core
- System.Data
- System.Deployment
- System.Drawing
- System.Net.Http
- System.Windows.Forms
- System.Xml
- System.Xml.Linq
- Microsoft.CSharp

## Development Notes

### Making Changes
1. Edit the source files as needed
2. Rebuild using the build commands above
3. Restart the workflow to see your changes

### Resource Files
Resource files (.resx) must be compiled to .resources files before being embedded in the executable. The embedded resource names must match the full type name (namespace + class name) for Windows Forms to find them correctly.

## Original Source
This project was imported from GitHub and adapted to run on Replit's environment.
