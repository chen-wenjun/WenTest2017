using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Flags]
    public enum Alignments
    {
        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8
    }

    public enum Status
    {
        None,
        Created,
        Confirmed,
        Completed,
        Closed
    }
}
