﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactApp.ViewModels
{
    public class UpdateStoryViewModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public List<string> Tags { get; set; }
    }
}
