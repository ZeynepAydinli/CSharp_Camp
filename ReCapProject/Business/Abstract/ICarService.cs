﻿using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface ICarService
{
    IDataResult<List<Car>> GetAll();
    IDataResult<List<Car>> GetCarsByBrandId(int id);
    IDataResult<List<Car>> GetCarsByColorId(int id);
    IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max);
    IResult Add(Car car);
    IResult Delete(Car car);
    IResult Update(Car car);
    IDataResult<List<CarDetailDto>> GetCarDetails();

}
