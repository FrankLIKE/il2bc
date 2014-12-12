IL2BC - Compiling C#/MSIL to Native Code using LLVM.
=====================================================

What is IL2BC
=============
IL2BC allows you to use C# instead of C++ to compile native cross-platform applications. Additionally IL2BC can convert any MSIL DLL into LLVM IR.

What IL2BC is not
=============
IL2BC is not providing .NET Framework functionality


QUICK START
===========
Hello World (C# code)


    using System;
    
    class X {
    	public static int Main (string [] args)
    	{
    		Console.WriteLine ("Hello, World!");
    		return 0;
    	}
    }

Step 1) Generating LLVM IR file
===============================

    Il2Bc.exe helloworld.cs /corelib:CoreLib.dll
    Il2Bc.exe CoreLib.dll

It will generate 2 files helloworld.ll and CoreLib.ll

Step 2) Compiling executable file
=================================

    llc -filetype=obj -mtriple=i686-w64-mingw32 CoreLib.ll
    llc -filetype=obj -mtriple=i686-w64-mingw32 helloworld.ll
    g++ -o helloworld.exe helloworld.obj CoreLib.obj -lstdc++ -lgc-lib -march=i686 -L .

It will generate exe file helloworld.exe which can be executed

PS. To Compile EXE file you need to have LLVM 3.6 and GCC MinGW which you can download from the following links

Binaries
========

[LLVM 3.6](http://llvm.org/builds/downloads/LLVM-3.6.0-r222681-win32.exe) and [GCC MinGW](http://sourceforge.net/projects/mingw-w64/files/Toolchains%20targetting%20Win32/Personal%20Builds/mingw-builds/4.8.2/threads-posix/dwarf/i686-4.8.2-release-posix-dwarf-rt_v3-rev4.7z/download)

PS2. You can download binaries from the site [http://csnative.codeplex.com/] http://csnative.codeplex.com/