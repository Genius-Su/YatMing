using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TShopData���������ӿ�
    /// </summary>
    public interface ITShopDataApp
    {
        /// <summary>
        /// ����һ��TShopData��¼
        /// </summary>
        /// <param name="dto">TShopDataʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TShopDataDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TShopData��¼
        /// </summary>
        /// <param name="guid">TShopData����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TShopData��¼
        /// </summary>
        /// <param name="dto">TShopDataʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TShopDataDTO dto);

        /// <summary>
        /// ����TShopData������ȡһ����¼
        /// </summary>
        /// <param name="guid">TShopData����ֵ</param>
        /// <returns>����������ѯ����TShopData��¼</returns>
        TShopDataDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TShopData��¼
        /// </summary>
        /// <returns>TShopData���м�¼����</returns>
        List<TShopDataDTO> GetAll();

    }
}
