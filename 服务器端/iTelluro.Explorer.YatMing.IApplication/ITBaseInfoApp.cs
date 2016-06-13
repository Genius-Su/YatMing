using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TBaseInfo���������ӿ�
    /// </summary>
    public interface ITBaseInfoApp
    {
        /// <summary>
        /// ����һ��TBaseInfo��¼
        /// </summary>
        /// <param name="dto">TBaseInfoʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TBaseInfoDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TBaseInfo��¼
        /// </summary>
        /// <param name="guid">TBaseInfo����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TBaseInfo��¼
        /// </summary>
        /// <param name="dto">TBaseInfoʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TBaseInfoDTO dto);

        /// <summary>
        /// ����TBaseInfo������ȡһ����¼
        /// </summary>
        /// <param name="guid">TBaseInfo����ֵ</param>
        /// <returns>����������ѯ����TBaseInfo��¼</returns>
        TBaseInfoDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TBaseInfo��¼
        /// </summary>
        /// <returns>TBaseInfo���м�¼����</returns>
        List<TBaseInfoDTO> GetAll();

        List<TBaseInfoDTO> QueryByKeyword(string key);

    }
}
