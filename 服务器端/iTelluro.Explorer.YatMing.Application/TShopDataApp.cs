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
    /// TShopData�����������ṩ
    /// </summary>
    public class TShopDataApp : ITShopDataApp
    {
        private ITShopDataRepository _repository;

        public TShopDataApp(ITShopDataRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TShopData��¼
        /// </summary>
        /// <param name="dto">TShopDataʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TShopDataDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_ShopData>();
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
        /// ��������ɾ��һ��TShopData��¼
        /// </summary>
        /// <param name="guid">TShopData����ֵ</param>
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
        /// ����һ��TShopData��¼
        /// </summary>
        /// <param name="dto">TShopDataʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TShopDataDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_ShopData>()) >= 0)
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
        /// ����TShopData������ȡһ����¼
        /// </summary>
        /// <param name="guid">TShopData����ֵ</param>
        /// <returns>����������ѯ����TShopData��¼</returns>
        public TShopDataDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TShopDataDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TShopData��¼
        /// </summary>
        /// <returns>TShopData���м�¼����</returns>
        public List<TShopDataDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TShopDataDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
