using System;

namespace Documents
{
    public class IssuingBook
    {
        int DocID { get; set; }

        int BookID { get; set; }

        int LibCallID { get; set; }

        DateTime issueDate = DateTime.Now;

        DateTime returnDate = DateTime.Now.AddDays(4);
    }
}
