# Open in Sublime Text
A Visual Studio extension that adds a menu command that
lets you open any solution, project, folder or file in
Sublime Text.

[![Build status](https://ci.appveyor.com/api/projects/status/k8f8ny0jxq2h53wr?svg=true)](https://ci.appveyor.com/project/madskristensen/openinsublimetext)

Download the extension at the
[VS Gallery](https://visualstudiogallery.msdn.microsoft.com/384892a5-7b67-42f2-b7de-574ef254a02a)
or get the
[nightly build](http://vsixgallery.com/extension/2925bbf7-d48b-4abd-83dc-1cd711d9b9ba/)

------------------------------------

This extension is for those times where you have a project
open in Visual Studio and you want to be able to quickly
open it in Sublime Text.

## Prerequisite
In order to use this extension, you must have Visual
Studio 2015 as well as Sublime Text installed.

You can
[download Sublime Text](http://www.sublimetext.com/)
for free.

## Solution Explorer
You can open any solution, project, folder or file in
Sublime Text by simply right-clicking it in Solution
Explorer and select
**Open in Sublime Text**.

![Context menu](art/context-menu.png)

### Settings
The extension will automatically find **sublime_text.exe**
when it's located at Sublime Text's default install
directory. If it's installed at a custom location, you
can easily change it in the settings:

![Settings](art/settings.png)

### Change Sublime's settings
Sublime Text will by default remember which folders and
files was open last time it was closed. That makes opening
Sublime Text to a folder from the command line
problematic (this extension uses same mechanism).

![Sublime Text Preferences](art/preferences.png)

To turn off this behavior in Sublime Text, go to
**Preferences -> User - Settings** and then add these two lines to the file:

```json
"hot_exit": false,
"remember_open_files": false
```

## Contribute
Check out the [contribution guidelines](.github/CONTRIBUTING.md)
if you want to contribute to this project.

For cloning and building this project yourself, make sure 
to install the
[Extensibility Tools 2015](https://visualstudiogallery.msdn.microsoft.com/ab39a092-1343-46e2-b0f1-6a3f91155aa6)
extension for Visual Studio which enables some features
used by this project.

## License
[Apache 2.0](LICENSE) 