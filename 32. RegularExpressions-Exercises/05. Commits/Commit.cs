using System;
using System.Collections.Generic;

namespace _05.Commits
{
    public class Commit
    {
        public string CommitHash { get; set; }

        public string Message { get; set; }

        public int Additions { get; set; }

        public int Deletions { get; set; }
    }
}
