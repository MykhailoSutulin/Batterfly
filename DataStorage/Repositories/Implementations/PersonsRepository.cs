using Bat.DataStorage.Repositories.Contracts;
using DataModels.Models;
using DataStorage;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bat.DataStorage.Repositories.Implementations
{
	public class PersonsRepository : IPersonRepository
	{
		private BatContext _context;

		public PersonsRepository(BatContext context)
		{
			_context = context;
		}

		public async Task<ICollection<Person>> GetAll(int id)
		{
			return await _context.Persons.ToListAsync();
		}

		public async Task<Person> GetById(int id)
		{
			return await _context.Persons.FirstOrDefaultAsync(x => x.Id == id);
		}

		public async Task AddAsync(Person item)
		{
			await _context.Persons.AddAsync(item);
		}

		public async Task Update(Person item)
		{
			await _context.Persons.ToListAsync();
		}

		public async Task DeleteById(int id)
		{
			Person item = await _context.Persons.FirstOrDefaultAsync(x => x.Id == id);
			if(item !=null)
			{
				_context.Persons.Remove(item);
			}
		}
	}
}
