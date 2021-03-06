﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicittApp.DataAccess.Crud;
using MicittApp.Entities.Objects;

namespace MicittApp.ApiCore.Management
{
    public class DepartamentoManagement : BaseManagement
    {
        public DepartamentoManagement()
        {
            _factory = new CrudDepartamento();
        }
        string ExcepMessage = null; // Management Exception
        public void CreateDepartamento(Departamento Obj)
        {
            try
            {
                _factory.Create(Obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<T> RetrieveAllDepartamento<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Departamento>();
                foreach (var obj in ret)
                {
                    lst.Add((T)Convert.ChangeType(obj, typeof(T)));
                }
            }
            catch (Exception ex)
            {
                ExcepMessage = "Logic Error" + ex;

            }
            return lst;
        }
        public void UpdateDepartamento(Departamento Obj)
        {
            try
            {
                _factory.Update(Obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void DeleteDepartamento(Departamento Obj)
        {
            try
            {
                _factory.Delete(Obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
