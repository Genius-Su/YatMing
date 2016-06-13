using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TPlatform���������ӿ�
    /// </summary>
    public interface ITPlatformApp
    {
        /// <summary>
        /// ����һ��TPlatform��¼
        /// </summary>
        /// <param name="dto">TPlatformʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TPlatformDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TPlatform��¼
        /// </summary>
        /// <param name="guid">TPlatform����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TPlatform��¼
        /// </summary>
        /// <param name="dto">TPlatformʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TPlatformDTO dto);

        /// <summary>
        /// ����TPlatform������ȡһ����¼
        /// </summary>
        /// <param name="guid">TPlatform����ֵ</param>
        /// <returns>����������ѯ����TPlatform��¼</returns>
        TPlatformDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TPlatform��¼
        /// </summary>
        /// <returns>TPlatform���м�¼����</returns>
        List<TPlatformDTO> GetAll();

        List<TPlatformDTO> GetByForignKey(string key);

    }
}
