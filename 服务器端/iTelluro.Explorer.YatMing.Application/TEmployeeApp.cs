using iTelluro.Explorer.YatMing.IApplication;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.Application.CodeFirst.Seedwork;
using iTelluro.Explorer.Domain.CodeFirst.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Domain.Context;
using iTelluro.Explorer.YatMing.Domain.Entities;
using iTelluro.Explorer.Infrastruct.CodeFirst.Seedwork;

namespace iTelluro.Explorer.YatMing.Application
{
    /// <summary>
    /// TEmployee�����������ṩ
    /// </summary>
    public class TEmployeeApp : ITEmployeeApp
    {
        private ITEmployeeRepository _repository;

        public TEmployeeApp(ITEmployeeRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TEmployee��¼
        /// </summary>
        /// <param name="dto">TEmployeeʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TEmployeeDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_Employee>();
                if (_repository.Insert(entity) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TEmployee��¼
        /// </summary>
        /// <param name="guid">TEmployee����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool Remove(string guid)
        {
            try
            {
                if (_repository.Delete(guid) > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ����һ��TEmployee��¼
        /// </summary>
        /// <param name="dto">TEmployeeʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TEmployeeDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_Employee>()) >= 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ����TEmployee������ȡһ����¼
        /// </summary>
        /// <param name="guid">TEmployee����ֵ</param>
        /// <returns>����������ѯ����TEmployee��¼</returns>
        public TEmployeeDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TEmployeeDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TEmployee��¼
        /// </summary>
        /// <returns>TEmployee���м�¼����</returns>
        public List<TEmployeeDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TEmployeeDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
