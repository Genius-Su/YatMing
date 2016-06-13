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
    /// TTrain�����������ṩ
    /// </summary>
    public class TTrainApp : ITTrainApp
    {
        private ITTrainRepository _repository;

        public TTrainApp(ITTrainRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// ����һ��TTrain��¼
        /// </summary>
        /// <param name="dto">TTrainʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool Add(TTrainDTO dto)
        {
            try
            {
                var entity = dto.ProjectedAs<T_Train>();
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
        /// ��������ɾ��һ��TTrain��¼
        /// </summary>
        /// <param name="guid">TTrain����ֵ</param>
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
        /// ����һ��TTrain��¼
        /// </summary>
        /// <param name="dto">TTrainʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool Update(TTrainDTO dto)
        {
            try
            {
                if (_repository.Update(dto.ProjectedAs<T_Train>()) >= 0)
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
        /// ����TTrain������ȡһ����¼
        /// </summary>
        /// <param name="guid">TTrain����ֵ</param>
        /// <returns>����������ѯ����TTrain��¼</returns>
        public TTrainDTO Get(string guid)
        {
            try
            {
                var entity = _repository.GetByKey(guid);
                return entity.ProjectedAs<TTrainDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// ��ѯ����TTrain��¼
        /// </summary>
        /// <returns>TTrain���м�¼����</returns>
        public List<TTrainDTO> GetAll()
        {
            try
            {
                return _repository.EntityNoTracking.ProjectedAsCollection<TTrainDTO>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
