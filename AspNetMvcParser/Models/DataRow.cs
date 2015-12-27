using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetMvcParser.Models
{
    public class DataRow
    {
        public string Title { get; set; }
        public string InnerText { get; set;}

        public DataRow(string title_, string innerText_)
        {
            Title = title_;
            InnerText = innerText_; 
        }
    }
}