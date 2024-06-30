﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Abstractions
{
    public interface IDashboradService
    {
        Task<List<int>> GetYearlyCounts();
        Task<int> GetTotalArticleCount();
        Task<int> GetTotalCategoryCount();
    }
}
