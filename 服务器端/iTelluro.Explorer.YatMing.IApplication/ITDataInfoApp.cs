using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.Domain.Entities;

namespace iTelluro.Explorer.YatMing.IApplication
{
    /// <summary>
    /// TDataInfo���������ӿ�
    /// </summary>
    public interface ITDataInfoApp
    {
        /// <summary>
        /// ����һ��TDataInfo��¼
        /// </summary>
        /// <param name="dto">TDataInfoʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        bool Add(TDataInfoDTO dto);

        /// <summary>
        /// ��������ɾ��һ��TDataInfo��¼
        /// </summary>
        /// <param name="guid">TDataInfo����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        bool Remove(string guid);

        /// <summary>
        /// ����һ��TDataInfo��¼
        /// </summary>
        /// <param name="dto">TDataInfoʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        bool Update(TDataInfoDTO dto);

        /// <summary>
        /// ����TDataInfo������ȡһ����¼
        /// </summary>
        /// <param name="guid">TDataInfo����ֵ</param>
        /// <returns>����������ѯ����TDataInfo��¼</returns>
        TDataInfoDTO Get(string guid);

        /// <summary>
        /// ��ѯ����TDataInfo��¼
        /// </summary>
        /// <returns>TDataInfo���м�¼����</returns>
        List<TDataInfoDTO> GetAll();

        bool UploadFile(byte[] buffer, string metaId, int index);

        bool DownloadFile(out byte[] outstream, long length, string metaId);

        List<TDataInfoDTO> GetByForginKey(string key);

        List<TDataInfoDTO> GetByParentKey(string key);

        List<TDataInfoDTO> Query(bool limit, DateTime start, DateTime end, string keyword, string baseId);
    }
}
