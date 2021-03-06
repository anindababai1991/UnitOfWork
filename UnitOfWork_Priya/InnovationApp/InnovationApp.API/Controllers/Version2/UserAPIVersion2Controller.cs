﻿using InnovationApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace InnovationApp.API.Controllers.Version2
{
    public class UserAPIVersion2Controller : ApiController, IUserAPI
    {
        private IUserRepository userRepository;
        private UnitOfWork unitOfWork;

        public UserAPIVersion2Controller()
        {
            this.userRepository = new UserRepository(new Entity());
            this.unitOfWork = new UnitOfWork(new Entity());
        }
    
        [HttpGet]
        [ActionName("GetUsers")]
        public List<User> GetUsers()
        {
            List<User> _user = new List<User>();
            List<User> _userDal = new List<User>();

            _userDal = unitOfWork.UserRepo.GetUsers();

            // _userDal = userRepository.GetUsers();

            //Convert the dal model to model layer model and return
            foreach (var item in _userDal)
            {
                _user.Add(new User()
                {
                    Password = item.Password,
                    TemplateMasters = item.TemplateMasters,
                    UserId = item.UserId,
                    Username = item.Username,
                    UserRoles = item.UserRoles
                });
            }
            return _user;
        }
    }
}