using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApp.TagHelpers
{
    public class SelectAddTagHelper : TagHelper
    {
        public string SelectAddElement { get; set; }
    }
}
