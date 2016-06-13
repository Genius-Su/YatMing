using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TServer���������ӿ�
    /// </summary>
    public interface ITServerApp
    {
        /// <summary>
        /// ����һ��TServer��¼
        /// </summary>
        /// <param name="dto">TServerʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TServerDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TServer��¼
        /// </summary>
        /// <param name="guid">TServer����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TServer��¼
        /// </summary>
        /// <param name="dto">TServerʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TServerDTO dto);

        /// <summary>
        /// ����TServer������ȡһ����¼
        /// </summary>
        /// <param name="guid">TServer����ֵ</param>
        /// <returns>����������ѯ����TServer��¼</returns>
        TServerDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TServer��¼
        /// </summary>
        /// <returns>TServer���м�¼����</returns>
        List<TServerDTO> GetAll();

    }
}
