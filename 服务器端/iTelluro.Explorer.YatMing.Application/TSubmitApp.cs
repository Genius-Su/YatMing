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
    /// TSubmit�����������ṩ
    /// </summary>
    public class TSubmitApp : ITSubmitApp
    {
        private ITSubmitRepository _repository;

        public TSubmitApp(ITSubmitRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TSubmit��¼
        /// </summary>
        /// <param name="dto">TSubmitʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TSubmitDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_Submit>();
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
        /// ��������ɾ��һ��TSubmit��¼
        /// </summary>
        /// <param name="guid">TSubmit����ֵ</param>
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
        /// ����һ��TSubmit��¼
        /// </summary>
        /// <param name="dto">TSubmitʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TSubmitDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_Submit>()) >= 0)
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
        /// ����TSubmit������ȡһ����¼
        /// </summary>
        /// <param name="guid">TSubmit����ֵ</param>
        /// <returns>����������ѯ����TSubmit��¼</returns>
        public TSubmitDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TSubmitDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TSubmit��¼
        /// </summary>
        /// <returns>TSubmit���м�¼����</returns>
        public List<TSubmitDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TSubmitDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
