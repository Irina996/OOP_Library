using System;

namespace Documents
{
    class LibraryCall
    {
        int LibCallID { get; set; }

        int ReaderID { get; set; }

        int LibID { get; set; }

        string Goal { get; set; }

        DateTime Date = DateTime.Now;
    }
}
