using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CostumerManager : ICostumerService
    {
        ICostumerDal _costumerDal;

        public CostumerManager(ICostumerDal costumerDal)
        {
            _costumerDal = costumerDal;
        }
        public IResult Add(Costumer costumer)
        {
            if (costumer.CompanyName == null)
            {
                return new ErrorResult(Messages.NameInvalid);
            }
            _costumerDal.Add(costumer);
            return new SuccessResult(Messages.CostumerAdded);
        }

        public IResult Delete(Costumer costumer)
        {
            _costumerDal.Delete(costumer);
            return new SuccessResult(Messages.CostumerDeleted);
        }

        public IDataResult<List<Costumer>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Costumer>>(Messages.MaintenanceTime);
            }


            return new SuccessDataResult<List<Costumer>>(_costumerDal.GetAll(), Messages.CostumerListed);
        }
        public IDataResult<Costumer> GetById(int id)
        {
            return new SuccessDataResult<Costumer>(_costumerDal.Get(c => c.Id == id));
        }


        public IResult Update(Costumer costumer)
        {
            _costumerDal.Update(costumer);
            return new SuccessResult(Messages.CostumerUpdated);
        }
    }
}
