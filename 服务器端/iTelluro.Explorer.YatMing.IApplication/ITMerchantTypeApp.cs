using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TMerchantType���������ӿ�
    /// </summary>
    public interface ITMerchantTypeApp
    {
        /// <summary>
        /// ����һ��TMerchantType��¼
        /// </summary>
        /// <param name="dto">TMerchantTypeʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TMerchantTypeDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TMerchantType��¼
        /// </summary>
        /// <param name="guid">TMerchantType����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TMerchantType��¼
        /// </summary>
        /// <param name="dto">TMerchantTypeʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TMerchantTypeDTO dto);

        /// <summary>
        /// ����TMerchantType������ȡһ����¼
        /// </summary>
        /// <param name="guid">TMerchantType����ֵ</param>
        /// <returns>����������ѯ����TMerchantType��¼</returns>
        TMerchantTypeDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TMerchantType��¼
        /// </summary>
        /// <returns>TMerchantType���м�¼����</returns>
        List<TMerchantTypeDTO> GetAll();

        List<TMerchantTypeDTO> GetByPid(string pid);

    }
}
