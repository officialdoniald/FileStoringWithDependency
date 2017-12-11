# FileStoringWithDependency
first version

NOTE:
This NuGetPackage will create 3 other folders: UWP, iOS and Droid. That they are in a folder you have to move to the each Platform's folder like this:
UWP -> <your_project_name>.UWP
Droid -> <your_project_name>.Droid
iOS -> <your_project_name>.iOS

Usage:

Create and Write file:

DependencyService.Get<IFileStoreAndLoad.IFileStoreAndLoad>().SaveText("filename.txt","text");

Load text from file:

string loadedText = DependencyService.Get<IFileStoreAndLoad.IFileStoreAndLoad>().LoadText("filename.txt");
