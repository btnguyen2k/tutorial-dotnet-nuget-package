#!/bin/sh

MY_PACKAGE_NAME=btnguyen2k.demolib

# Create new .NET solution in the current directory
dotnet new sln -n $MY_PACKAGE_NAME

# Create new .NET class library project
dotnet new classlib -n $MY_PACKAGE_NAME
