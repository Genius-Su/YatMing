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
    /// TPromotion�����������ṩ
    /// </summary>
    public class TPromotionApp : ITPromotionApp
    {
        private ITPromotionRepository _repository;

        public TPromotionApp(ITPromotionRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TPromotion��¼
        /// </summary>
        /// <param name="dto">TPromotionʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TPromotionDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_Promotion>();
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
        /// ��������ɾ��һ��TPromotion��¼
        /// </summary>
        /// <param name="guid">TPromotion����ֵ</param>
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
        /// ����һ��TPromotion��¼
        /// </summary>
        /// <param name="dto">TPromotionʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TPromotionDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_Promotion>()) >= 0)
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
        /// ����TPromotion������ȡһ����¼
        /// </summary>
        /// <param name="guid">TPromotion����ֵ</param>
        /// <returns>����������ѯ����TPromotion��¼</returns>
        public TPromotionDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TPromotionDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TPromotion��¼
        /// </summary>
        /// <returns>TPromotion���м�¼����</returns>
        public List<TPromotionDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TPromotionDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
