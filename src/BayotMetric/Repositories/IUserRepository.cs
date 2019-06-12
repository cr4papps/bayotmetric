using System;
using System.Collections.Generic;
using BayotMetric.Models;

namespace BayotMetric.Repositories
{
	public interface IUserRepository
	{
		IList<User> FindAll();
		void Save(User u);
		void Update(User u, int id);
		void Delete(int id);
	}
}
