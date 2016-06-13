using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TPromotion���������ӿ�
    /// </summary>
    public interface ITPromotionApp
    {
        /// <summary>
        /// ����һ��TPromotion��¼
        /// </summary>
        /// <param name="dto">TPromotionʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TPromotionDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TPromotion��¼
        /// </summary>
        /// <param name="guid">TPromotion����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TPromotion��¼
        /// </summary>
        /// <param name="dto">TPromotionʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TPromotionDTO dto);

        /// <summary>
        /// ����TPromotion������ȡһ����¼
        /// </summary>
        /// <param name="guid">TPromotion����ֵ</param>
        /// <returns>����������ѯ����TPromotion��¼</returns>
        TPromotionDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TPromotion��¼
        /// </summary>
        /// <returns>TPromotion���м�¼����</returns>
        List<TPromotionDTO> GetAll();

    }
}
