﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veresiye.Data;
using Veresiye.Model;

namespace Veresiye.Service
{
	public class UserService : IUserService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IRepository<User> userRepository;
		public UserService(IUnitOfWork unitOfWork, IRepository<User>userRepository)
		{
			this.unitOfWork = unitOfWork;
			this.userRepository = userRepository;
		}
		public IEnumerable<User> GetAll()
		{
			return userRepository.GetAll();
		}

		public User Login(string username, string password)
		{
			username = username.ToLower();
			var user = userRepository.Get(x => x.UserName==username && x.Password == password);
			return user;

		}

		public bool Register(string userName, string password, string confirmPassword)
		{
			userName = userName.ToLower();
			//Validasyonlar
			if (password !=confirmPassword)
			{
				return false;
			}
			else if (string.IsNullOrEmpty(userName))
			{
				return false;
			}
			else
			{
				var user = userRepository.Get(x => x.UserName == userName);
				if (user!=null)
				{
					return false;
				}

			}

			var newUser = new User();
			newUser.UserName = userName;
			newUser.Password = password;
			userRepository.Insert(newUser);
			unitOfWork.SaveChanges();
			return true;
		}
	}

	public interface IUserService
	{
		User Login(string username, string password);
		bool Register(string UserName, string Password, string ConfirmPassword);
		IEnumerable<User> GetAll();
	}
}