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
    /// TCheck�����������ṩ
    /// </summary>
    public class TCheckApp : ITCheckApp
    {
        private ITCheckRepository _repository;

        public TCheckApp(ITCheckRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TCheck��¼
        /// </summary>
        /// <param name="dto">TCheckʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TCheckDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_Check>();
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
        /// ��������ɾ��һ��TCheck��¼
        /// </summary>
        /// <param name="guid">TCheck����ֵ</param>
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
        /// ����һ��TCheck��¼
        /// </summary>
        /// <param name="dto">TCheckʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TCheckDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_Check>()) >= 0)
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
        /// ����TCheck������ȡһ����¼
        /// </summary>
        /// <param name="guid">TCheck����ֵ</param>
        /// <returns>����������ѯ����TCheck��¼</returns>
        public TCheckDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TCheckDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TCheck��¼
        /// </summary>
        /// <returns>TCheck���м�¼����</returns>
        public List<TCheckDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TCheckDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
