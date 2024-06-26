﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result;
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

    public IResult Add(Car car)
    {
        if (car.Description.Length < 2)
        {
            return new ErrorResult(Messages.CarInvalid);
        }

        _carDal.Add(car);

        return new SuccessResult(Messages.CarAdded);
    }

    public IResult Delete(Car car)
    {
        _carDal.Delete(car);
        return new SuccessResult(Messages.CarDeleted);
    
    }

    public IDataResult<List<Car>> GetAll()
    {
        if (DateTime.Now.Hour == 24)
        {
            return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
        }
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
    }

    public IDataResult<List<Car>> GetByUnitPrice(decimal min, decimal max)
    {
        return new SuccessDataResult<List<Car>> (_carDal.GetAll(
            p => p.DailyPrice >= min && p.DailyPrice <= max));
    }

    public IDataResult<List<CarDetailDto>> GetCarDetails()
    {
        return new SuccessDataResult<List<CarDetailDto>> (_carDal.GetCarDetails());
    }

    public IDataResult<List<Car>> GetCarsByBrandId(int id)
    {
        return new SuccessDataResult<List<Car>> (_carDal.GetAll(p => p.BrandId == id));
    }

    public IDataResult<List<Car>> GetCarsByColorId(int id)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == id));
    }

    public IResult Update(Car car)
    {
        _carDal.Update(car);
        return new SuccessResult(Messages.CarUpdated);
    }
}
