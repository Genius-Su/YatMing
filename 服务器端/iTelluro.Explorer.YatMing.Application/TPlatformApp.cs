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
    /// TPlatform�����������ṩ
    /// </summary>
    public class TPlatformApp : ITPlatformApp
    {
        private ITPlatformRepository _repository;

        public TPlatformApp(ITPlatformRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TPlatform��¼
        /// </summary>
        /// <param name="dto">TPlatformʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TPlatformDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_Platform>();
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
        /// ��������ɾ��һ��TPlatform��¼
        /// </summary>
        /// <param name="guid">TPlatform����ֵ</param>
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
        /// ����һ��TPlatform��¼
        /// </summary>
        /// <param name="dto">TPlatformʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TPlatformDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_Platform>()) >= 0)
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
        /// ����TPlatform������ȡһ����¼
        /// </summary>
        /// <param name="guid">TPlatform����ֵ</param>
        /// <returns>����������ѯ����TPlatform��¼</returns>
        public TPlatformDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TPlatformDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TPlatform��¼
        /// </summary>
        /// <returns>TPlatform���м�¼����</returns>
        public List<TPlatformDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TPlatformDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TPlatformDTO> GetByForignKey(string key)
        {
            try
            {
                return _repository.EntityNoTracking.Where(t => t.MerchantId == key).ProjectedAsCollection<TPlatformDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
