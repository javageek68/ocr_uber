# ocr_uber


The screen scraping portion of the application works by invoking an embedded version of the Edge web browswer.  This requires a library to be installed on the user's computer.

If the library is not already installed on your machine, then the embedded web browswer on the Georeferencer tab will not render the page. In that case, you can install the library
from this address.
https://developer.microsoft.com/en-us/microsoft-edge/webview2/


This is a video that demonstrates how to use the application.

https://www.youtube.com/watch?v=jj4SnItBT6I

New feature – 

Since the video was created, I added a new feature.  I noticed that copying coordinate fields one at a time was a little monotonous.  So I added a checkbox with the text “Auto fill all fields (assumes fields were selected in order)” next to the Target Field drop down box.  If you check it, then it will copy all of the fields at once.  It will copy the row you select in the data grid into the Origin Coords field.  Then it will copy each row below that into Coordinate 2, Coordinate 3 and so on until it reaches the last row of the grid.  The final entry will be copied to the Destination Coords field. Note that this features assumes that you selected the points in order from the origin to the destination. 



Installation Instructions

The code is programmed in C# and WinForms. The software can be compiled using Visual Studio 2019 or newer.

Requirements

Installation instructions are for the command prompt (Powershell or CMD) using winget, the Windows package manager.

Windows Operating System
Microsoft Visual Studio 2019 or 2022

winget install Microsoft VisualStudio.2019.Community

OR for Visual Studio 2022

winget install Microsoft VisualStudio.2022.Community

If you want another edition than the Community Edition, please use winget search

winget search VisualStudio


Microsoft EdgeView2

winget install Microsoft.EdgeWebView2Runtime



Running Visual Studio 2022

Choose Clone a Repository on start screen.

In the Repository Location box, put in this repository's git addresses:

https://github.com/javageek68/ocr_uber.git

Chose a path where you want to store the repository. Click the Clone Button. If this is the first time you are starting Visual Studio 20xx, it will probably need to install a few Gigabytes of files to run the first time. After that, you should be able to build the project and run it.

