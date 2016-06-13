using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// THardware���������ӿ�
    /// </summary>
    public interface ITHardwareApp
    {
        /// <summary>
        /// ����һ��THardware��¼
        /// </summary>
        /// <param name="dto">THardwareʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(THardwareDTO dto);

        /// <summary>
        /// ��������ɾ��һ��THardware��¼
        /// </summary>
        /// <param name="guid">THardware����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��THardware��¼
        /// </summary>
        /// <param name="dto">THardwareʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(THardwareDTO dto);

        /// <summary>
        /// ����THardware������ȡһ����¼
        /// </summary>
        /// <param name="guid">THardware����ֵ</param>
        /// <returns>����������ѯ����THardware��¼</returns>
        THardwareDTO Get(string guid);

        /// <summary>
        /// ��ѯ����THardware��¼
        /// </summary>
        /// <returns>THardware���м�¼����</returns>
        List<THardwareDTO> GetAll();

    }
}
