using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Varldsklass.Domain.Entities.Abstract
{
    class News
    {
        public string Headline { get; set; }

        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
    }
}
