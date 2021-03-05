using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICostumerService
    {
        IDataResult<List<Costumer>> GetAll();
        IDataResult<Costumer>GetById(int costumerId);
        IResult Add(Costumer costumer);
        IResult Update(Costumer costumer);
        IResult Delete(Costumer costumer);
        //IDataResult<List<CostumerDetailDto>> GetCostumerDetails();
       
       
    }
}
