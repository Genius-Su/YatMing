using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TTrain���������ӿ�
    /// </summary>
    public interface ITTrainApp
    {
        /// <summary>
        /// ����һ��TTrain��¼
        /// </summary>
        /// <param name="dto">TTrainʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TTrainDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TTrain��¼
        /// </summary>
        /// <param name="guid">TTrain����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TTrain��¼
        /// </summary>
        /// <param name="dto">TTrainʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TTrainDTO dto);

        /// <summary>
        /// ����TTrain������ȡһ����¼
        /// </summary>
        /// <param name="guid">TTrain����ֵ</param>
        /// <returns>����������ѯ����TTrain��¼</returns>
        TTrainDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TTrain��¼
        /// </summary>
        /// <returns>TTrain���м�¼����</returns>
        List<TTrainDTO> GetAll();

    }
}
