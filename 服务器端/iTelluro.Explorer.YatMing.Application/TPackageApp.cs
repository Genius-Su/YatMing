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
    /// TPackage�����������ṩ
    /// </summary>
    public class TPackageApp : ITPackageApp
    {
        private ITPackageRepository _repository;

        public TPackageApp(ITPackageRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TPackage��¼
        /// </summary>
        /// <param name="dto">TPackageʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TPackageDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_Package>();
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
        /// ��������ɾ��һ��TPackage��¼
        /// </summary>
        /// <param name="guid">TPackage����ֵ</param>
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
        /// ����һ��TPackage��¼
        /// </summary>
        /// <param name="dto">TPackageʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TPackageDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_Package>()) >= 0)
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
        /// ����TPackage������ȡһ����¼
        /// </summary>
        /// <param name="guid">TPackage����ֵ</param>
        /// <returns>����������ѯ����TPackage��¼</returns>
        public TPackageDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TPackageDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TPackage��¼
        /// </summary>
        /// <returns>TPackage���м�¼����</returns>
        public List<TPackageDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TPackageDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
