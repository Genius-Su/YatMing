using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TEmployee���������ӿ�
    /// </summary>
    public interface ITEmployeeApp
    {
        /// <summary>
        /// ����һ��TEmployee��¼
        /// </summary>
        /// <param name="dto">TEmployeeʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TEmployeeDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TEmployee��¼
        /// </summary>
        /// <param name="guid">TEmployee����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TEmployee��¼
        /// </summary>
        /// <param name="dto">TEmployeeʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TEmployeeDTO dto);

        /// <summary>
        /// ����TEmployee������ȡһ����¼
        /// </summary>
        /// <param name="guid">TEmployee����ֵ</param>
        /// <returns>����������ѯ����TEmployee��¼</returns>
        TEmployeeDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TEmployee��¼
        /// </summary>
        /// <returns>TEmployee���м�¼����</returns>
        List<TEmployeeDTO> GetAll();

    }
}
