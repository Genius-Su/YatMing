using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TSubmit���������ӿ�
    /// </summary>
    public interface ITSubmitApp
    {
        /// <summary>
        /// ����һ��TSubmit��¼
        /// </summary>
        /// <param name="dto">TSubmitʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TSubmitDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TSubmit��¼
        /// </summary>
        /// <param name="guid">TSubmit����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TSubmit��¼
        /// </summary>
        /// <param name="dto">TSubmitʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TSubmitDTO dto);

        /// <summary>
        /// ����TSubmit������ȡһ����¼
        /// </summary>
        /// <param name="guid">TSubmit����ֵ</param>
        /// <returns>����������ѯ����TSubmit��¼</returns>
        TSubmitDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TSubmit��¼
        /// </summary>
        /// <returns>TSubmit���м�¼����</returns>
        List<TSubmitDTO> GetAll();

    }
}
