Quick test on how to dip into C/C++ from C# using your own shared C++ libraries


# Building
Building and testing is quite quick and only involves several steps. Before proceeding, it should be noted that this quick test targets Linux. This makes a difference because in Linux C++ shared libraries have a *.so file extension compared to Windows having a *.dll file extension. The ``Program.cs`` file is looking for a shared library with an extension ending is *.so. As is this test will not work on Windows without some modifications.

### Required
* Linux
* .NET Core 3.1
* GCC >= 7 or clang >= 7

## Building C++ library
1. Change into the C++ Libs directory and create a build directory
```Bash
cd Libs; mkdir build
```
2. Build the C++ library
```Bash
cd build; cmake -DCMAKE_BUILD_TYPE=DEBUG ..; make
```
3. Copy the library to the root of the project
```Bash
cp libTestExample.so ../../
```

## Building .NET console software
1. Ensure that you are in the root of the project. Then build the software
```Bash
dotnet build
```
2. Copy the C++ library to where the executable is build
```Bash
cp libTestExample.so bin/Debug/netcoreapp3.1/
```
3. Run the software
```Bash
dotnet run
```
4. The .NET code is calling a function from the C++ library that was built. The result is the sum of two integers
