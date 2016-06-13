using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TDetailInfo���������ӿ�
    /// </summary>
    public interface ITDetailInfoApp
    {
        /// <summary>
        /// ����һ��TDetailInfo��¼
        /// </summary>
        /// <param name="dto">TDetailInfoʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TDetailInfoDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TDetailInfo��¼
        /// </summary>
        /// <param name="guid">TDetailInfo����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TDetailInfo��¼
        /// </summary>
        /// <param name="dto">TDetailInfoʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TDetailInfoDTO dto);

        /// <summary>
        /// ����TDetailInfo������ȡһ����¼
        /// </summary>
        /// <param name="guid">TDetailInfo����ֵ</param>
        /// <returns>����������ѯ����TDetailInfo��¼</returns>
        TDetailInfoDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TDetailInfo��¼
        /// </summary>
        /// <returns>TDetailInfo���м�¼����</returns>
        List<TDetailInfoDTO> GetAll();

        TDetailInfoDTO GetByForignKey(string id);

    }
}
