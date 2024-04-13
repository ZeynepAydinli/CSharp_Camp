﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CarManager : ICarService
{
    ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public void Add(Car car)
    {
        _carDal.Add(car);
    }

    public void Delete(Car car)
    {
        _carDal.Delete(car);
    }

    public List<Car> GetAll()
    {
        return _carDal.GetAll();
    }

    public List<Car> GetByUnitPrice(decimal min, decimal max)
    {
        return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
    }

    public List<CarDetailDto> GetCarDetails()
    {
        return _carDal.GetCarDetails();
    }

    public List<Car> GetCarsByBrandId(int id)
    {
        return _carDal.GetAll(p => p.BrandId == id);
    }

    public List<Car> GetCarsByColorId(int id)
    {
        return _carDal.GetAll(p => p.ColorId == id);
    }
}
