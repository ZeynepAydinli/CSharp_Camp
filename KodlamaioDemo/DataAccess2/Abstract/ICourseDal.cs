﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess2.Abstract;

public interface ICourseDal : IEntityRepository<Course>
{

}
