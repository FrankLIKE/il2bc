////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Apache License 2.0 (Apache)
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace System.Threading
{

    using System;
    using System.Runtime.CompilerServices;
    public sealed class AutoResetEvent : WaitHandle
    {

        
        extern public AutoResetEvent(bool initialState);

        
        extern public bool Reset();
        
        extern public bool Set();
    }
}

