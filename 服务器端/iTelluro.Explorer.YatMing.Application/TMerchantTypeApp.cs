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
    /// TMerchantType�����������ṩ
    /// </summary>
    public class TMerchantTypeApp : ITMerchantTypeApp
    {
        private ITMerchantTypeRepository _repository;

        public TMerchantTypeApp(ITMerchantTypeRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TMerchantType��¼
        /// </summary>
        /// <param name="dto">TMerchantTypeʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TMerchantTypeDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_MerchantType>();
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
        /// ��������ɾ��һ��TMerchantType��¼
        /// </summary>
        /// <param name="guid">TMerchantType����ֵ</param>
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
        /// ����һ��TMerchantType��¼
        /// </summary>
        /// <param name="dto">TMerchantTypeʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TMerchantTypeDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_MerchantType>()) >= 0)
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
        /// ����TMerchantType������ȡһ����¼
        /// </summary>
        /// <param name="guid">TMerchantType����ֵ</param>
        /// <returns>����������ѯ����TMerchantType��¼</returns>
        public TMerchantTypeDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TMerchantTypeDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TMerchantType��¼
        /// </summary>
        /// <returns>TMerchantType���м�¼����</returns>
        public List<TMerchantTypeDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TMerchantTypeDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TMerchantTypeDTO> GetByPid(string pid)
        {
            try
            {
                return _repository.EntityNoTracking.Where(t => t.ParentId == pid).ProjectedAsCollection<TMerchantTypeDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
