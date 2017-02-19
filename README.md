# FileStoringWithDependency
first version

NOTE:
You have to change in the Android, IOS and UWP Projects the 
FileStoringWithDependency,
to your project name
,if you download this NuGet package!!!

Usage:

Create and Write file:

DependencyService.Get<IFileStoreAndLoad.IFileStoreAndLoad>().SaveText("filename.txt","text");

Load text from file:

string loadedText = DependencyService.Get<IFileStoreAndLoad.IFileStoreAndLoad>().LoadText("filename.txt");
