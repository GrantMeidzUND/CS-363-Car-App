#!/bin/bash

echo "Building C# Car Dashboard App..."

resgen2 Form1.resx "obj/Form1.resources"
resgen2 Form2.resx "obj/Form2.resources"
resgen2 Form3.resx "obj/Form3.resources"
cd Properties && resgen2 "Resources.resx" "../obj/CS_363_Car_App.Properties.Resources.resources" && cd ..

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

if [ $? -eq 0 ]; then
    echo "Build successful!"
    echo "Restarting app..."
    pkill -f "mono.*CS 363 Car App.exe" 2>/dev/null
    DISPLAY=:0 mono "bin/Debug/CS 363 Car App.exe" &
    echo "App restarted! Check the VNC pane."
else
    echo "Build failed! Check the errors above."
fi
