# WindowsFormsAppTestSaveLoad
App created during the interview process for a Junior .NET Software Developer position. 
App is able to save text box inputs to a file, load files, save changes to currently open files, 
has a list of recently accessed files and is able to load files from the list.
It took me around 8 to 10 hours to create this app as it is right now, I haven't made a WinForms app in a long itme, so this was quite fun.


To do:

-Save functionality is a bit buggy. Sometimes crashes the app multiple times in a row and sometimes works like a charm.

-Both Save and Save As can crash if the rich text box is empty. Adding a check to see if the RichTextBox is empty doesn't seem to solve the issue.

-Load Selected Recent File does crash if no recent file is selected in the list box, forgot to add selection validation.

-Need to add "Are you sure you want to exit without saving" functionality(compare function).

-Documentation of the various methods is severely lacking due to time constraints.

-Might add another function to use an array of strings when dealing with user data to help make code more readable.

-Other user data functions could use another pass for better performance as well.

-Might replace button press functions with simply invoking neede functions wherever applicable.

-Might add missing functionality initially required (password encryption/decryption during file IO, default values...)


Requested app specification text added below:

General
All code must be written using C# and Windows Forms (.NET 4.7 or newer and Visual Studio 2019 or newer).

Test results may contain multiple projects, but all projects must be a part of a single Visual Studio solution. The solution must be fully buildable without any errors or warnings.

All code identifiers (forms, components, classes, methods, properties, fields…) must be named using meaningful English names describing their function.

Usage of NuGet packages is allowed. All other 3rd party components are not allowed.

Task

We need a GUI application (Windows Forms) that will provide functionality to create, save and load projects.

Project is defined by the following parameters:

• Server name

• Database name

• Username

• Password

• Parameters (multiline)

The application needs to provide the following functionality:

• Save Project data to a file

• Load Project data from a file

• Optional (bonus):

o Password encryption/decryption when saving and loading data

o Unit tests for save and load functionality

• GUI to fill in all the project data

• Save/Save As project to a file

• Load project from file (and populate the GUI)

• New project (clears all entered data)

• Implement options to set default values

o Default values are used when program is started, or new project is created

• Recent file (projects) list

o The application should remember last 5 projects

o The list must be saved when application is closed and loaded on next application start

o The user must be able to load recent project

o Ability to configure number of recent files

