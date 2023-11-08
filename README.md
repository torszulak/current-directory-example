# current-directory-example
This repo shows examples how to get current directory in .NET app according to this [post](https://torszulak.github.io/blog/dotnet_get_current_directory_examples/)

# Requirements
.NET 7

# Getting started
After download this solution, run command ```dotnet build``` in console (from .sln main directory).  
You can test this application by running generated .exe file (bin/Debug/net7.0).  
Make sure that OtherProject.dll is in bin/Debug/.net7.0/plugins folder (it should be there because in OtherProject.csproj is configured post-build event to copy this dll)
