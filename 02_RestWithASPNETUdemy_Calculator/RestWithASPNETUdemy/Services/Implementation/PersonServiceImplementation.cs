using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RestWithASPNETUdemy.Services.Implementation
{
    public class PersonServiceImplementation : IPersonService
    {
        private MySQLContext _context;

        public PersonServiceImplementation(MySQLContext context) {
            this._context = context;
        }

        public Person Create(Person person)
        {
            try {
                _context.Add(person);
                _context.SaveChanges();
            } catch (Exception ex) {
                throw ex;
            }
            return person;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null) {
                try {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                } catch (Exception ex) {
                    throw ex;
                }
            }
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }


        public Person FindById(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person Update(Person person, long id)
        {
            if (!Exists(id)) return new Person();
            var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
            person.Id = id;
            if (result != null) {
                try {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                } catch (Exception ex) {
                    throw ex;
                }
            }
            return person;
        }

        private bool Exists(long id) {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }
    }
}
