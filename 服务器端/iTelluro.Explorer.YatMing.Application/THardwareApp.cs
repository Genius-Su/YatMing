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
    /// THardware�����������ṩ
    /// </summary>
    public class THardwareApp : ITHardwareApp
    {
        private ITHardwareRepository _repository;

        public THardwareApp(ITHardwareRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��THardware��¼
        /// </summary>
        /// <param name="dto">THardwareʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(THardwareDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_Hardware>();
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
        /// ��������ɾ��һ��THardware��¼
        /// </summary>
        /// <param name="guid">THardware����ֵ</param>
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
        /// ����һ��THardware��¼
        /// </summary>
        /// <param name="dto">THardwareʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(THardwareDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_Hardware>()) >= 0)
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
        /// ����THardware������ȡһ����¼
        /// </summary>
        /// <param name="guid">THardware����ֵ</param>
        /// <returns>����������ѯ����THardware��¼</returns>
        public THardwareDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<THardwareDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����THardware��¼
        /// </summary>
        /// <returns>THardware���м�¼����</returns>
        public List<THardwareDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<THardwareDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
