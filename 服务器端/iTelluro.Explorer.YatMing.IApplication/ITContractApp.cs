using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TContract���������ӿ�
    /// </summary>
    public interface ITContractApp
    {
        /// <summary>
        /// ����һ��TContract��¼
        /// </summary>
        /// <param name="dto">TContractʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TContractDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TContract��¼
        /// </summary>
        /// <param name="guid">TContract����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TContract��¼
        /// </summary>
        /// <param name="dto">TContractʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TContractDTO dto);

        /// <summary>
        /// ����TContract������ȡһ����¼
        /// </summary>
        /// <param name="guid">TContract����ֵ</param>
        /// <returns>����������ѯ����TContract��¼</returns>
        TContractDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TContract��¼
        /// </summary>
        /// <returns>TContract���м�¼����</returns>
        List<TContractDTO> GetAll();

    }
}
