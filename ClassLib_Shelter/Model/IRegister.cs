using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib_Shelter.Model
{
    public interface IRegister<T>
    {

        void Add(T item);
        List<T> GetAll();
        T GetById(int id);
        T Update(int id, T item);
        void Remove(int id);
        string ToString();
    }
}