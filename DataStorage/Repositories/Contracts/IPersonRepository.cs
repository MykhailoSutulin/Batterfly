using DataModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bat.DataStorage.Repositories.Contracts
{
    interface IPersonRepository
    {
		Task<Person> GetById(int id);

		Task<ICollection<Person>> GetAll(int id);

		Task AddAsync(Person item);

		Task Update(Person item);

		Task DeleteById(int id);
	}
}
