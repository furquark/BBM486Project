﻿using System.Collections.Generic;
using Entities.Concrete;

namespace Service.Abstract
{
    public interface IJuniorSoftwareDeveloperService
    {
        List<JuniorSoftwareDeveloper> GetAll();
    }
}