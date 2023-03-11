using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise_12
{
    interface ITestpaper
    {
        string Subject { get; }
        string[] MarkScheme { get; }
        string PassMark { get; }
    }

    class Testpaper : ITestpaper
    {
        public string Subject { get; }
        public string[] MarkScheme { get; }
        public string PassMark { get; }

        public Testpaper(string subject, string[] markScheme, string passMark)
        {
            this.Subject = subject;
            this.MarkScheme = markScheme;
            this.PassMark = passMark;
        }
    }
}