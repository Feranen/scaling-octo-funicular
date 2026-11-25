using System;
using System.Collections.Generic;
using System.Text;

namespace Navigation2.Models
{
    public class Note
    {
        public string title { get; private set; } = string.Empty;
        public string desc { get; private set; } = string.Empty;

        public Note(string title, string desc)
        {
            if (!string.IsNullOrEmpty(title) & !string.IsNullOrEmpty(desc))
            {
                this.title = title;
                this.desc = desc;
            }
            
        }
    }
}
