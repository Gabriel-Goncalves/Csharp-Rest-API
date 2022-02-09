﻿using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Services.Implementation
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        Person Update(Person person, long id);
        List<Person> FindAll();
        void Delete(long id);
    }
}
