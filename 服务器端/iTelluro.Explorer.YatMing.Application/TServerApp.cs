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
    /// TServer�����������ṩ
    /// </summary>
    public class TServerApp : ITServerApp
    {
        private ITServerRepository _repository;

        public TServerApp(ITServerRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TServer��¼
        /// </summary>
        /// <param name="dto">TServerʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TServerDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_Server>();
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
        /// ��������ɾ��һ��TServer��¼
        /// </summary>
        /// <param name="guid">TServer����ֵ</param>
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
        /// ����һ��TServer��¼
        /// </summary>
        /// <param name="dto">TServerʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TServerDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_Server>()) > 0)
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
        /// ����TServer������ȡһ����¼
        /// </summary>
        /// <param name="guid">TServer����ֵ</param>
        /// <returns>����������ѯ����TServer��¼</returns>
        public TServerDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TServerDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TServer��¼
        /// </summary>
        /// <returns>TServer���м�¼����</returns>
        public List<TServerDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TServerDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
