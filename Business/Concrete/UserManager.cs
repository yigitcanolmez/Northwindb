﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User GetByMail(string Mail)
        {
            return _userDal.Get(u=>u.Email == Mail);    
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return new List<OperationClaim>((IEnumerable<OperationClaim>)_userDal.GetClaims(user));

        }
    }
}
