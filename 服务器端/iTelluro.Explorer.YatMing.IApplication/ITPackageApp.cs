using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TPackage���������ӿ�
    /// </summary>
    public interface ITPackageApp
    {
        /// <summary>
        /// ����һ��TPackage��¼
        /// </summary>
        /// <param name="dto">TPackageʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TPackageDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TPackage��¼
        /// </summary>
        /// <param name="guid">TPackage����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TPackage��¼
        /// </summary>
        /// <param name="dto">TPackageʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TPackageDTO dto);

        /// <summary>
        /// ����TPackage������ȡһ����¼
        /// </summary>
        /// <param name="guid">TPackage����ֵ</param>
        /// <returns>����������ѯ����TPackage��¼</returns>
        TPackageDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TPackage��¼
        /// </summary>
        /// <returns>TPackage���м�¼����</returns>
        List<TPackageDTO> GetAll();

    }
}
