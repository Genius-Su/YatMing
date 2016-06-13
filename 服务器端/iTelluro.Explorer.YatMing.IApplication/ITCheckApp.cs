using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TCheck���������ӿ�
    /// </summary>
    public interface ITCheckApp
    {
        /// <summary>
        /// ����һ��TCheck��¼
        /// </summary>
        /// <param name="dto">TCheckʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TCheckDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TCheck��¼
        /// </summary>
        /// <param name="guid">TCheck����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TCheck��¼
        /// </summary>
        /// <param name="dto">TCheckʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TCheckDTO dto);

        /// <summary>
        /// ����TCheck������ȡһ����¼
        /// </summary>
        /// <param name="guid">TCheck����ֵ</param>
        /// <returns>����������ѯ����TCheck��¼</returns>
        TCheckDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TCheck��¼
        /// </summary>
        /// <returns>TCheck���м�¼����</returns>
        List<TCheckDTO> GetAll();

    }
}
