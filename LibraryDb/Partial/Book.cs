using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDb.Models;

    public partial class Book
    {
    public string info => $"{Title} ({Year})";
    }

