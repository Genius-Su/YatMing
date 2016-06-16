using iTelluro.Explorer.YatMing.Application.DTO;
using iTelluro.Explorer.YatMing.IApplication;
using iTelluro.Explorer.YatMing.Service.InstanceProviders;
using log4net;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace iTelluro.Explorer.YatMing.Service
{
    // ע��: ʹ�á��ع����˵��ϵġ����������������ͬʱ���Ĵ��롢svc �������ļ��е�������YatMingService����
    // ע��: Ϊ������ WCF ���Կͻ����Բ��Դ˷������ڽ��������Դ��������ѡ�� YatMingService.svc �� YatMingService.svc.cs��Ȼ��ʼ���ԡ�
    [UnityInstanceProviderServiceBehavior]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class YatMingService : IYatMingService
    {
        #region TLogin

        /// <summary>
        /// ����ע��TLoginApp
        /// </summary>
        [Dependency]
        public ITLoginApp _TLoginApp { get; set; }

        /// <summary>
        /// ����һ��TLogin��¼
        /// </summary>
        /// <param name="TLoginDTO">TLoginʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TLoginAdd(TLoginDTO TLoginDTO)
        {
            try
            {
                return _TLoginApp.Add(TLoginDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TLogin��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TLoginDelete(string guid)
        {
            try
            {
                return _TLoginApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TLogin��¼
        /// </summary>
        /// <param name="TLoginDTO">TLoginʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TLoginUpdate(TLoginDTO TLoginDTO)
        {
            try
            {
                return _TLoginApp.Update(TLoginDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TLogin��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TLoginDTO TLoginQueryById(string guid)
        {
            try
            {
                return _TLoginApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TLogin��¼
        /// </summary>
        /// <returns>���е�TLogin�����</returns>
        public List<TLoginDTO> TLoginQueryAll()
        {
            try
            {
                return _TLoginApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        public bool TLoginCheckLogin(string account, string psw, out string message, out TLoginDTO result)
        {
            try
            {
                return _TLoginApp.CheckLogin(account, psw, out message,out result);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                message = "�������쳣��" + ex.Message;
                result = null;
                return false;
            }
        }

        public bool TLoginCheckAccountExits(string account)
        {
            try
            {
                return _TLoginApp.CheckAccountExits(account);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        public bool TLoginCheckUpdate(string currentVersion)
        {
             try
            {
                return _TLoginApp.CheckUpdate(currentVersion);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        public bool TLoginUpdateSys(out string[] uploadFileLst, out string[] deleteFileLst, out byte[][] fileContent)
        {
            try
            {
                return _TLoginApp.Update(out uploadFileLst,out deleteFileLst ,out fileContent);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                fileContent = null;
                deleteFileLst = null;
                uploadFileLst=null;
                return false;
            }
        }

        #endregion


        #region TCheck

        /// <summary>
        /// ����ע��TCheckApp
        /// </summary>
        [Dependency]
        public ITCheckApp _TCheckApp { get; set; }

        /// <summary>
        /// ����һ��TCheck��¼
        /// </summary>
        /// <param name="TCheckDTO">TCheckʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TCheckAdd(TCheckDTO TCheckDTO)
        {
            try
            {
                return _TCheckApp.Add(TCheckDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TCheck��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TCheckDelete(string guid)
        {
            try
            {
                return _TCheckApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TCheck��¼
        /// </summary>
        /// <param name="TCheckDTO">TCheckʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TCheckUpdate(TCheckDTO TCheckDTO)
        {
            try
            {
                return _TCheckApp.Update(TCheckDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TCheck��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TCheckDTO TCheckQueryById(string guid)
        {
            try
            {
                return _TCheckApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TCheck��¼
        /// </summary>
        /// <returns>���е�TCheck�����</returns>
        public List<TCheckDTO> TCheckQueryAll()
        {
            try
            {
                return _TCheckApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region TBaseInfo

        /// <summary>
        /// ����ע��TBaseInfoApp
        /// </summary>
        [Dependency]
        public ITBaseInfoApp _TBaseInfoApp { get; set; }

        /// <summary>
        /// ����һ��TBaseInfo��¼
        /// </summary>
        /// <param name="TBaseInfoDTO">TBaseInfoʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TBaseInfoAdd(TBaseInfoDTO TBaseInfoDTO)
        {
            try
            {
                return _TBaseInfoApp.Add(TBaseInfoDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TBaseInfo��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TBaseInfoDelete(string guid)
        {
            try
            {
                return _TBaseInfoApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TBaseInfo��¼
        /// </summary>
        /// <param name="TBaseInfoDTO">TBaseInfoʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TBaseInfoUpdate(TBaseInfoDTO TBaseInfoDTO)
        {
            try
            {
                return _TBaseInfoApp.Update(TBaseInfoDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TBaseInfo��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TBaseInfoDTO TBaseInfoQueryById(string guid)
        {
            try
            {
                return _TBaseInfoApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TBaseInfo��¼
        /// </summary>
        /// <returns>���е�TBaseInfo�����</returns>
        public List<TBaseInfoDTO> TBaseInfoQueryAll()
        {
            try
            {
                return _TBaseInfoApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        public List<TBaseInfoDTO> TBaseInfoQueryByKeyword(string key)
        {
            try
            {
                return _TBaseInfoApp.QueryByKeyword(key);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region TMerchantType

        /// <summary>
        /// ����ע��TMerchantTypeApp
        /// </summary>
        [Dependency]
        public ITMerchantTypeApp _TMerchantTypeApp { get; set; }

        /// <summary>
        /// ����һ��TMerchantType��¼
        /// </summary>
        /// <param name="TMerchantTypeDTO">TMerchantTypeʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TMerchantTypeAdd(TMerchantTypeDTO TMerchantTypeDTO)
        {
            try
            {
                return _TMerchantTypeApp.Add(TMerchantTypeDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TMerchantType��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TMerchantTypeDelete(string guid)
        {
            try
            {
                return _TMerchantTypeApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TMerchantType��¼
        /// </summary>
        /// <param name="TMerchantTypeDTO">TMerchantTypeʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TMerchantTypeUpdate(TMerchantTypeDTO TMerchantTypeDTO)
        {
            try
            {
                return _TMerchantTypeApp.Update(TMerchantTypeDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TMerchantType��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TMerchantTypeDTO TMerchantTypeQueryById(string guid)
        {
            try
            {
                return _TMerchantTypeApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TMerchantType��¼
        /// </summary>
        /// <returns>���е�TMerchantType�����</returns>
        public List<TMerchantTypeDTO> TMerchantTypeQueryAll()
        {
            try
            {
                return _TMerchantTypeApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        public List<TMerchantTypeDTO> TMerchantTypeGetByPid(string pid)
        {
            try
            {
                return _TMerchantTypeApp.GetByPid(pid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region TDetailInfo

        /// <summary>
        /// ����ע��TDetailInfoApp
        /// </summary>
        [Dependency]
        public ITDetailInfoApp _TDetailInfoApp { get; set; }

        /// <summary>
        /// ����һ��TDetailInfo��¼
        /// </summary>
        /// <param name="TDetailInfoDTO">TDetailInfoʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TDetailInfoAdd(TDetailInfoDTO TDetailInfoDTO)
        {
            try
            {
                return _TDetailInfoApp.Add(TDetailInfoDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TDetailInfo��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TDetailInfoDelete(string guid)
        {
            try
            {
                return _TDetailInfoApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TDetailInfo��¼
        /// </summary>
        /// <param name="TDetailInfoDTO">TDetailInfoʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TDetailInfoUpdate(TDetailInfoDTO TDetailInfoDTO)
        {
            try
            {
                return _TDetailInfoApp.Update(TDetailInfoDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TDetailInfo��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TDetailInfoDTO TDetailInfoQueryById(string guid)
        {
            try
            {
                return _TDetailInfoApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TDetailInfo��¼
        /// </summary>
        /// <returns>���е�TDetailInfo�����</returns>
        public List<TDetailInfoDTO> TDetailInfoQueryAll()
        {
            try
            {
                return _TDetailInfoApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        public TDetailInfoDTO TDetailInfoGetByForignKey(string id)
        {
            try
            {
                return _TDetailInfoApp.GetByForignKey(id);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region TDataInfo

        /// <summary>
        /// ����ע��TDataInfoApp
        /// </summary>
        [Dependency]
        public ITDataInfoApp _TDataInfoApp { get; set; }

        /// <summary>
        /// ����һ��TDataInfo��¼
        /// </summary>
        /// <param name="TDataInfoDTO">TDataInfoʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TDataInfoAdd(TDataInfoDTO TDataInfoDTO)
        {
            try
            {
                return _TDataInfoApp.Add(TDataInfoDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TDataInfo��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TDataInfoDelete(string guid)
        {
            try
            {
                return _TDataInfoApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TDataInfo��¼
        /// </summary>
        /// <param name="TDataInfoDTO">TDataInfoʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TDataInfoUpdate(TDataInfoDTO TDataInfoDTO)
        {
            try
            {
                return _TDataInfoApp.Update(TDataInfoDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TDataInfo��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TDataInfoDTO TDataInfoQueryById(string guid)
        {
            try
            {
                return _TDataInfoApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TDataInfo��¼
        /// </summary>
        /// <returns>���е�TDataInfo�����</returns>
        public List<TDataInfoDTO> TDataInfoQueryAll()
        {
            try
            {
                return _TDataInfoApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        public bool TDataInfoUploadFile(byte[] buffer, string metaId, int index)
        {
            try
            {
                return _TDataInfoApp.UploadFile(buffer, metaId, index);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        public bool TDataInfoDownloadFile(out byte[] outstream, long length, string metaId)
        {
            try
            {
                return _TDataInfoApp.DownloadFile(out outstream, length, metaId);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                outstream = null;
                return false;
            }
        }

        public List<TDataInfoDTO> TDataInGetByForginKey(string key)
        {
            try
            {
                return _TDataInfoApp.GetByForginKey(key);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        public List<TDataInfoDTO> TDataInGetByParentKey(string key)
        {
            try
            {
                return _TDataInfoApp.GetByParentKey(key);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        public List<TDataInfoDTO> TDataInQuery(bool limit, DateTime start, DateTime end, string keyword, string baseId)
        {
            try
            {
                return _TDataInfoApp.Query(limit, start, end, keyword, baseId);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        public void TDataInDoConvert(string metaId)
        {
            try
            {
                 _TDataInfoApp.DoConvert(metaId);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);            
            }
        }

        #endregion


        #region TPromotion

        /// <summary>
        /// ����ע��TPromotionApp
        /// </summary>
        [Dependency]
        public ITPromotionApp _TPromotionApp { get; set; }

        /// <summary>
        /// ����һ��TPromotion��¼
        /// </summary>
        /// <param name="TPromotionDTO">TPromotionʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TPromotionAdd(TPromotionDTO TPromotionDTO)
        {
            try
            {
                return _TPromotionApp.Add(TPromotionDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TPromotion��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TPromotionDelete(string guid)
        {
            try
            {
                return _TPromotionApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TPromotion��¼
        /// </summary>
        /// <param name="TPromotionDTO">TPromotionʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TPromotionUpdate(TPromotionDTO TPromotionDTO)
        {
            try
            {
                return _TPromotionApp.Update(TPromotionDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TPromotion��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TPromotionDTO TPromotionQueryById(string guid)
        {
            try
            {
                return _TPromotionApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TPromotion��¼
        /// </summary>
        /// <returns>���е�TPromotion�����</returns>
        public List<TPromotionDTO> TPromotionQueryAll()
        {
            try
            {
                return _TPromotionApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region TPlatform

        /// <summary>
        /// ����ע��TPlatformApp
        /// </summary>
        [Dependency]
        public ITPlatformApp _TPlatformApp { get; set; }

        /// <summary>
        /// ����һ��TPlatform��¼
        /// </summary>
        /// <param name="TPlatformDTO">TPlatformʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TPlatformAdd(TPlatformDTO TPlatformDTO)
        {
            try
            {
                return _TPlatformApp.Add(TPlatformDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TPlatform��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TPlatformDelete(string guid)
        {
            try
            {
                return _TPlatformApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TPlatform��¼
        /// </summary>
        /// <param name="TPlatformDTO">TPlatformʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TPlatformUpdate(TPlatformDTO TPlatformDTO)
        {
            try
            {
                return _TPlatformApp.Update(TPlatformDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TPlatform��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TPlatformDTO TPlatformQueryById(string guid)
        {
            try
            {
                return _TPlatformApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TPlatform��¼
        /// </summary>
        /// <returns>���е�TPlatform�����</returns>
        public List<TPlatformDTO> TPlatformQueryAll()
        {
            try
            {
                return _TPlatformApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        public List<TPlatformDTO> TPlatformGetByForignKey(string key)
        {
            try
            {
                return _TPlatformApp.GetByForignKey(key);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region TShopData

        /// <summary>
        /// ����ע��TShopDataApp
        /// </summary>
        [Dependency]
        public ITShopDataApp _TShopDataApp { get; set; }

        /// <summary>
        /// ����һ��TShopData��¼
        /// </summary>
        /// <param name="TShopDataDTO">TShopDataʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TShopDataAdd(TShopDataDTO TShopDataDTO)
        {
            try
            {
                return _TShopDataApp.Add(TShopDataDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TShopData��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TShopDataDelete(string guid)
        {
            try
            {
                return _TShopDataApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TShopData��¼
        /// </summary>
        /// <param name="TShopDataDTO">TShopDataʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TShopDataUpdate(TShopDataDTO TShopDataDTO)
        {
            try
            {
                return _TShopDataApp.Update(TShopDataDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TShopData��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TShopDataDTO TShopDataQueryById(string guid)
        {
            try
            {
                return _TShopDataApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TShopData��¼
        /// </summary>
        /// <returns>���е�TShopData�����</returns>
        public List<TShopDataDTO> TShopDataQueryAll()
        {
            try
            {
                return _TShopDataApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region TPrice

        /// <summary>
        /// ����ע��TPriceApp
        /// </summary>
        [Dependency]
        public ITPriceApp _TPriceApp { get; set; }

        /// <summary>
        /// ����һ��TPrice��¼
        /// </summary>
        /// <param name="TPriceDTO">TPriceʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TPriceAdd(TPriceDTO TPriceDTO)
        {
            try
            {
                return _TPriceApp.Add(TPriceDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TPrice��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TPriceDelete(string guid)
        {
            try
            {
                return _TPriceApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TPrice��¼
        /// </summary>
        /// <param name="TPriceDTO">TPriceʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TPriceUpdate(TPriceDTO TPriceDTO)
        {
            try
            {
                return _TPriceApp.Update(TPriceDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TPrice��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TPriceDTO TPriceQueryById(string guid)
        {
            try
            {
                return _TPriceApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TPrice��¼
        /// </summary>
        /// <returns>���е�TPrice�����</returns>
        public List<TPriceDTO> TPriceQueryAll()
        {
            try
            {
                return _TPriceApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region TPackage

        /// <summary>
        /// ����ע��TPackageApp
        /// </summary>
        [Dependency]
        public ITPackageApp _TPackageApp { get; set; }

        /// <summary>
        /// ����һ��TPackage��¼
        /// </summary>
        /// <param name="TPackageDTO">TPackageʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TPackageAdd(TPackageDTO TPackageDTO)
        {
            try
            {
                return _TPackageApp.Add(TPackageDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TPackage��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TPackageDelete(string guid)
        {
            try
            {
                return _TPackageApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TPackage��¼
        /// </summary>
        /// <param name="TPackageDTO">TPackageʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TPackageUpdate(TPackageDTO TPackageDTO)
        {
            try
            {
                return _TPackageApp.Update(TPackageDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TPackage��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TPackageDTO TPackageQueryById(string guid)
        {
            try
            {
                return _TPackageApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TPackage��¼
        /// </summary>
        /// <returns>���е�TPackage�����</returns>
        public List<TPackageDTO> TPackageQueryAll()
        {
            try
            {
                return _TPackageApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region THardware

        /// <summary>
        /// ����ע��THardwareApp
        /// </summary>
        [Dependency]
        public ITHardwareApp _THardwareApp { get; set; }

        /// <summary>
        /// ����һ��THardware��¼
        /// </summary>
        /// <param name="THardwareDTO">THardwareʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool THardwareAdd(THardwareDTO THardwareDTO)
        {
            try
            {
                return _THardwareApp.Add(THardwareDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��THardware��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool THardwareDelete(string guid)
        {
            try
            {
                return _THardwareApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��THardware��¼
        /// </summary>
        /// <param name="THardwareDTO">THardwareʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool THardwareUpdate(THardwareDTO THardwareDTO)
        {
            try
            {
                return _THardwareApp.Update(THardwareDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��THardware��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public THardwareDTO THardwareQueryById(string guid)
        {
            try
            {
                return _THardwareApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�THardware��¼
        /// </summary>
        /// <returns>���е�THardware�����</returns>
        public List<THardwareDTO> THardwareQueryAll()
        {
            try
            {
                return _THardwareApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region TContract

        /// <summary>
        /// ����ע��TContractApp
        /// </summary>
        [Dependency]
        public ITContractApp _TContractApp { get; set; }

        /// <summary>
        /// ����һ��TContract��¼
        /// </summary>
        /// <param name="TContractDTO">TContractʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TContractAdd(TContractDTO TContractDTO)
        {
            try
            {
                return _TContractApp.Add(TContractDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TContract��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TContractDelete(string guid)
        {
            try
            {
                return _TContractApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TContract��¼
        /// </summary>
        /// <param name="TContractDTO">TContractʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TContractUpdate(TContractDTO TContractDTO)
        {
            try
            {
                return _TContractApp.Update(TContractDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TContract��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TContractDTO TContractQueryById(string guid)
        {
            try
            {
                return _TContractApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TContract��¼
        /// </summary>
        /// <returns>���е�TContract�����</returns>
        public List<TContractDTO> TContractQueryAll()
        {
            try
            {
                return _TContractApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region TSubmit

        /// <summary>
        /// ����ע��TSubmitApp
        /// </summary>
        [Dependency]
        public ITSubmitApp _TSubmitApp { get; set; }

        /// <summary>
        /// ����һ��TSubmit��¼
        /// </summary>
        /// <param name="TSubmitDTO">TSubmitʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TSubmitAdd(TSubmitDTO TSubmitDTO)
        {
            try
            {
                return _TSubmitApp.Add(TSubmitDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TSubmit��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TSubmitDelete(string guid)
        {
            try
            {
                return _TSubmitApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TSubmit��¼
        /// </summary>
        /// <param name="TSubmitDTO">TSubmitʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TSubmitUpdate(TSubmitDTO TSubmitDTO)
        {
            try
            {
                return _TSubmitApp.Update(TSubmitDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TSubmit��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TSubmitDTO TSubmitQueryById(string guid)
        {
            try
            {
                return _TSubmitApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TSubmit��¼
        /// </summary>
        /// <returns>���е�TSubmit�����</returns>
        public List<TSubmitDTO> TSubmitQueryAll()
        {
            try
            {
                return _TSubmitApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region TServer

        /// <summary>
        /// ����ע��TServerApp
        /// </summary>
        [Dependency]
        public ITServerApp _TServerApp { get; set; }

        /// <summary>
        /// ����һ��TServer��¼
        /// </summary>
        /// <param name="TServerDTO">TServerʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TServerAdd(TServerDTO TServerDTO)
        {
            try
            {
                return _TServerApp.Add(TServerDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TServer��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TServerDelete(string guid)
        {
            try
            {
                return _TServerApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TServer��¼
        /// </summary>
        /// <param name="TServerDTO">TServerʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TServerUpdate(TServerDTO TServerDTO)
        {
            try
            {
                return _TServerApp.Update(TServerDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TServer��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TServerDTO TServerQueryById(string guid)
        {
            try
            {
                return _TServerApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TServer��¼
        /// </summary>
        /// <returns>���е�TServer�����</returns>
        public List<TServerDTO> TServerQueryAll()
        {
            try
            {
                return _TServerApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region TTrain

        /// <summary>
        /// ����ע��TTrainApp
        /// </summary>
        [Dependency]
        public ITTrainApp _TTrainApp { get; set; }

        /// <summary>
        /// ����һ��TTrain��¼
        /// </summary>
        /// <param name="TTrainDTO">TTrainʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TTrainAdd(TTrainDTO TTrainDTO)
        {
            try
            {
                return _TTrainApp.Add(TTrainDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TTrain��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TTrainDelete(string guid)
        {
            try
            {
                return _TTrainApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TTrain��¼
        /// </summary>
        /// <param name="TTrainDTO">TTrainʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TTrainUpdate(TTrainDTO TTrainDTO)
        {
            try
            {
                return _TTrainApp.Update(TTrainDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TTrain��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TTrainDTO TTrainQueryById(string guid)
        {
            try
            {
                return _TTrainApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TTrain��¼
        /// </summary>
        /// <returns>���е�TTrain�����</returns>
        public List<TTrainDTO> TTrainQueryAll()
        {
            try
            {
                return _TTrainApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion


        #region TEmployee

        /// <summary>
        /// ����ע��TEmployeeApp
        /// </summary>
        [Dependency]
        public ITEmployeeApp _TEmployeeApp { get; set; }

        /// <summary>
        /// ����һ��TEmployee��¼
        /// </summary>
        /// <param name="TEmployeeDTO">TEmployeeʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        public bool TEmployeeAdd(TEmployeeDTO TEmployeeDTO)
        {
            try
            {
                return _TEmployeeApp.Add(TEmployeeDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ��������ɾ��һ��TEmployee��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        public bool TEmployeeDelete(string guid)
        {
            try
            {
                return _TEmployeeApp.Remove(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����һ��TEmployee��¼
        /// </summary>
        /// <param name="TEmployeeDTO">TEmployeeʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        public bool TEmployeeUpdate(TEmployeeDTO TEmployeeDTO)
        {
            try
            {
                return _TEmployeeApp.Update(TEmployeeDTO);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// ����������ѯһ��TEmployee��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ��ʵ����</returns>
        public TEmployeeDTO TEmployeeQueryById(string guid)
        {
            try
            {
                return _TEmployeeApp.Get(guid);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        /// <summary>
        /// ��ѯ���е�TEmployee��¼
        /// </summary>
        /// <returns>���е�TEmployee�����</returns>
        public List<TEmployeeDTO> TEmployeeQueryAll()
        {
            try
            {
                return _TEmployeeApp.GetAll();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("YatMingSerice-" + this.GetType().Name + "-" + MethodBase.GetCurrentMethod().Name);
                log.Error(ex.Message);
                return null;
            }
        }

        #endregion



    }
}
