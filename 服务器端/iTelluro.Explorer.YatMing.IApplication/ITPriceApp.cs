using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TPrice���������ӿ�
    /// </summary>
    public interface ITPriceApp
    {
        /// <summary>
        /// ����һ��TPrice��¼
        /// </summary>
        /// <param name="dto">TPriceʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TPriceDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TPrice��¼
        /// </summary>
        /// <param name="guid">TPrice����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TPrice��¼
        /// </summary>
        /// <param name="dto">TPriceʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TPriceDTO dto);

        /// <summary>
        /// ����TPrice������ȡһ����¼
        /// </summary>
        /// <param name="guid">TPrice����ֵ</param>
        /// <returns>����������ѯ����TPrice��¼</returns>
        TPriceDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TPrice��¼
        /// </summary>
        /// <returns>TPrice���м�¼����</returns>
        List<TPriceDTO> GetAll();

    }
}
