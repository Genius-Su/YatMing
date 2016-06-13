using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TLogin���������ӿ�
    /// </summary>
    public interface ITLoginApp
    {
        /// <summary>
        /// ����һ��TLogin��¼
        /// </summary>
        /// <param name="dto">TLoginʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TLoginDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TLogin��¼
        /// </summary>
        /// <param name="guid">TLogin����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TLogin��¼
        /// </summary>
        /// <param name="dto">TLoginʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TLoginDTO dto);

        /// <summary>
        /// ����TLogin������ȡһ����¼
        /// </summary>
        /// <param name="guid">TLogin����ֵ</param>
        /// <returns>����������ѯ����TLogin��¼</returns>
        TLoginDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TLogin��¼
        /// </summary>
        /// <returns>TLogin���м�¼����</returns>
        List<TLoginDTO> GetAll();

        bool CheckLogin(string account, string psw, out string message,out TLoginDTO result);

        bool CheckAccountExits(string account);

        bool CheckUpdate(string currentVersion);

        bool Update(out string[] uploadFileLst, out string[] deleteFileLst, out byte[][] fileContent);
    }
}
