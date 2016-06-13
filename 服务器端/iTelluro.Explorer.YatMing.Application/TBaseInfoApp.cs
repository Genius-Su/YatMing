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
    /// TBaseInfo�����������ṩ
    /// </summary>
    public class TBaseInfoApp : ITBaseInfoApp
    {
        private ITBaseInfoRepository _repository;

        public TBaseInfoApp(ITBaseInfoRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TBaseInfo��¼
        /// </summary>
        /// <param name="dto">TBaseInfoʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TBaseInfoDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_BaseInfo>();
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
        /// ��������ɾ��һ��TBaseInfo��¼
        /// </summary>
        /// <param name="guid">TBaseInfo����ֵ</param>
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
        /// ����һ��TBaseInfo��¼
        /// </summary>
        /// <param name="dto">TBaseInfoʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TBaseInfoDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_BaseInfo>()) >= 0)
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
        /// ����TBaseInfo������ȡһ����¼
        /// </summary>
        /// <param name="guid">TBaseInfo����ֵ</param>
        /// <returns>����������ѯ����TBaseInfo��¼</returns>
        public TBaseInfoDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TBaseInfoDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TBaseInfo��¼
        /// </summary>
        /// <returns>TBaseInfo���м�¼����</returns>
        public List<TBaseInfoDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TBaseInfoDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TBaseInfoDTO> QueryByKeyword(string key)
        {
            try
            {
                return _repository.EntityNoTracking.Where(t => t.MerchantName.Contains(key)).ProjectedAsCollection<TBaseInfoDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
