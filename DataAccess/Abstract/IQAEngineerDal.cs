﻿using System.Collections.Generic;
using Core.DataAccess.EntityRepositories;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IQAEngineerDal : IEntityRepository<QAEngineer>
    {
        List<QAEngineerDto> GetQAEngineerDetails();
    }
}