using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SQliteDbCreate
{
    /// <summary>
    /// Blog entity
    /// </summary>
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public DateTime DateTimeAdd { get; set; }

    }
}
