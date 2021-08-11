﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticePrinciples.DataAccess
{
    public interface IVehicleDao<T>
    {
        void Add(T vehicle);
        void Delete(T vehicle);
        ICollection<T> GetAll();
        T GetById(int id);
    }
}
