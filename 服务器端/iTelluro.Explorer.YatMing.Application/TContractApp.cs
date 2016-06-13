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
    /// TContract�����������ṩ
    /// </summary>
    public class TContractApp : ITContractApp
    {
        private ITContractRepository _repository;

        public TContractApp(ITContractRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TContract��¼
        /// </summary>
        /// <param name="dto">TContractʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TContractDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_Contract>();
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
        /// ��������ɾ��һ��TContract��¼
        /// </summary>
        /// <param name="guid">TContract����ֵ</param>
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
        /// ����һ��TContract��¼
        /// </summary>
        /// <param name="dto">TContractʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TContractDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_Contract>()) >= 0)
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
        /// ����TContract������ȡһ����¼
        /// </summary>
        /// <param name="guid">TContract����ֵ</param>
        /// <returns>����������ѯ����TContract��¼</returns>
        public TContractDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TContractDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TContract��¼
        /// </summary>
        /// <returns>TContract���м�¼����</returns>
        public List<TContractDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TContractDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
