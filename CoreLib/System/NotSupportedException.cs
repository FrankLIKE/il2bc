////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Apache License 2.0 (Apache)
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace System
{

    using System;
    [Serializable()]
    public class NotSupportedException : SystemException
    {
        public NotSupportedException()
            : base()
        {
        }

        public NotSupportedException(String message)
            : base(message)
        {
        }

        public NotSupportedException(String message, Exception innerException)
            : base(message, innerException)
        {
        }

    }
}

