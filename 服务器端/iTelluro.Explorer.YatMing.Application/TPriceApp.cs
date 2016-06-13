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
    /// TPrice�����������ṩ
    /// </summary>
    public class TPriceApp : ITPriceApp
    {
        private ITPriceRepository _repository;

        public TPriceApp(ITPriceRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TPrice��¼
        /// </summary>
        /// <param name="dto">TPriceʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TPriceDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_Price>();
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
        /// ��������ɾ��һ��TPrice��¼
        /// </summary>
        /// <param name="guid">TPrice����ֵ</param>
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
        /// ����һ��TPrice��¼
        /// </summary>
        /// <param name="dto">TPriceʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TPriceDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_Price>()) >= 0)
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
        /// ����TPrice������ȡһ����¼
        /// </summary>
        /// <param name="guid">TPrice����ֵ</param>
        /// <returns>����������ѯ����TPrice��¼</returns>
        public TPriceDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TPriceDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TPrice��¼
        /// </summary>
        /// <returns>TPrice���м�¼����</returns>
        public List<TPriceDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TPriceDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
