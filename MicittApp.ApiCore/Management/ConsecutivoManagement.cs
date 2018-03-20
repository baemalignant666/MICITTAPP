﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicittApp.DataAccess.Crud;
using MicittApp.Entities.Objects;

namespace MicittApp.ApiCore.Management
{
    public class ConsecutivoManagement : BaseManagement
    {
        public ConsecutivoManagement()
        {
            _factory = new CrudConsecutivo();
        }
        string ExcepMessage = null; // Management Exception
        public void CreateConsecutivo(Consecutivo Obj)
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
        public List<T> RetrieveAllConsecutivo<T>()
        {
            var lst = new List<T>();
            try
            {
                var ret = _factory.RetrieveAll<Consecutivo>();
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
        public void UpdateConsecutivo(Consecutivo Obj)
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
        public void DeleteConsecutivo(Consecutivo Obj)
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
