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
    /// TDetailInfo�����������ṩ
    /// </summary>
    public class TDetailInfoApp : ITDetailInfoApp
    {
        private ITDetailInfoRepository _repository;

        public TDetailInfoApp(ITDetailInfoRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TDetailInfo��¼
        /// </summary>
        /// <param name="dto">TDetailInfoʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TDetailInfoDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_DetailInfo>();
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
        /// ��������ɾ��һ��TDetailInfo��¼
        /// </summary>
        /// <param name="guid">TDetailInfo����ֵ</param>
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
        /// ����һ��TDetailInfo��¼
        /// </summary>
        /// <param name="dto">TDetailInfoʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TDetailInfoDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_DetailInfo>()) >= 0)
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
        /// ����TDetailInfo������ȡһ����¼
        /// </summary>
        /// <param name="guid">TDetailInfo����ֵ</param>
        /// <returns>����������ѯ����TDetailInfo��¼</returns>
        public TDetailInfoDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TDetailInfoDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TDetailInfo��¼
        /// </summary>
        /// <returns>TDetailInfo���м�¼����</returns>
        public List<TDetailInfoDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TDetailInfoDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TDetailInfoDTO GetByForignKey(string id)
        {
            try
            {
                return _repository.EntityNoTracking.Where(t => t.BaseInfoId == id).FirstOrDefault().ProjectedAs<TDetailInfoDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
