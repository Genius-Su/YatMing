using iTelluro.Explorer.YatMing.Application.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace iTelluro.Explorer.YatMing.Service
{
    // ע��: ʹ�á��ع����˵��ϵġ����������������ͬʱ���Ĵ���������ļ��еĽӿ�����IYatMingService����
    [ServiceContract]
    public interface IYatMingService
    {
        #region TLogin

        /// <summary>
        /// ����һ��TLogin��¼
        /// </summary>
        /// <param name="TLoginDTO">TLoginʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TLoginAdd(TLoginDTO TLoginDTO);

        /// <summary>
        /// ����һ��TLogin��¼
        /// </summary>
        /// <param name="TLoginDTO">TLoginʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TLoginUpdate(TLoginDTO TLoginDTO);

        /// <summary>
        /// ��������ɾ��һ��TLogin��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TLoginDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TLogin��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TLoginDTO TLoginQueryById(string guid);

        /// <summary>
        /// ��ѯTLogin���еļ�¼
        /// </summary>
        /// <returns>TLogin�����м�¼����</returns>
        [OperationContract]
        List<TLoginDTO> TLoginQueryAll();

        [OperationContract]
        bool TLoginCheckLogin(string account, string psw, out string message, out TLoginDTO result);

        [OperationContract]
        bool TLoginCheckAccountExits(string account);

        [OperationContract]
        bool TLoginCheckUpdate(string currentVersion);

        [OperationContract]
        bool TLoginUpdateSys(out string[] uploadFileLst, out string[] deleteFileLst, out byte[][] fileContent);
        #endregion


        #region TCheck

        /// <summary>
        /// ����һ��TCheck��¼
        /// </summary>
        /// <param name="TCheckDTO">TCheckʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TCheckAdd(TCheckDTO TCheckDTO);

        /// <summary>
        /// ����һ��TCheck��¼
        /// </summary>
        /// <param name="TCheckDTO">TCheckʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TCheckUpdate(TCheckDTO TCheckDTO);

        /// <summary>
        /// ��������ɾ��һ��TCheck��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TCheckDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TCheck��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TCheckDTO TCheckQueryById(string guid);

        /// <summary>
        /// ��ѯTCheck���еļ�¼
        /// </summary>
        /// <returns>TCheck�����м�¼����</returns>
        [OperationContract]
        List<TCheckDTO> TCheckQueryAll();

        #endregion


        #region TBaseInfo

        /// <summary>
        /// ����һ��TBaseInfo��¼
        /// </summary>
        /// <param name="TBaseInfoDTO">TBaseInfoʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TBaseInfoAdd(TBaseInfoDTO TBaseInfoDTO);

        /// <summary>
        /// ����һ��TBaseInfo��¼
        /// </summary>
        /// <param name="TBaseInfoDTO">TBaseInfoʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TBaseInfoUpdate(TBaseInfoDTO TBaseInfoDTO);

        /// <summary>
        /// ��������ɾ��һ��TBaseInfo��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TBaseInfoDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TBaseInfo��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TBaseInfoDTO TBaseInfoQueryById(string guid);

        /// <summary>
        /// ��ѯTBaseInfo���еļ�¼
        /// </summary>
        /// <returns>TBaseInfo�����м�¼����</returns>
        [OperationContract]
        List<TBaseInfoDTO> TBaseInfoQueryAll();

        [OperationContract]
        List<TBaseInfoDTO> TBaseInfoQueryByKeyword(string key);

        #endregion


        #region TMerchantType

        /// <summary>
        /// ����һ��TMerchantType��¼
        /// </summary>
        /// <param name="TMerchantTypeDTO">TMerchantTypeʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TMerchantTypeAdd(TMerchantTypeDTO TMerchantTypeDTO);

        /// <summary>
        /// ����һ��TMerchantType��¼
        /// </summary>
        /// <param name="TMerchantTypeDTO">TMerchantTypeʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TMerchantTypeUpdate(TMerchantTypeDTO TMerchantTypeDTO);

        /// <summary>
        /// ��������ɾ��һ��TMerchantType��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TMerchantTypeDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TMerchantType��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TMerchantTypeDTO TMerchantTypeQueryById(string guid);

        /// <summary>
        /// ��ѯTMerchantType���еļ�¼
        /// </summary>
        /// <returns>TMerchantType�����м�¼����</returns>
        [OperationContract]
        List<TMerchantTypeDTO> TMerchantTypeQueryAll();

        [OperationContract]
        List<TMerchantTypeDTO> TMerchantTypeGetByPid(string pid);

        #endregion


        #region TDetailInfo

        /// <summary>
        /// ����һ��TDetailInfo��¼
        /// </summary>
        /// <param name="TDetailInfoDTO">TDetailInfoʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TDetailInfoAdd(TDetailInfoDTO TDetailInfoDTO);

        /// <summary>
        /// ����һ��TDetailInfo��¼
        /// </summary>
        /// <param name="TDetailInfoDTO">TDetailInfoʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TDetailInfoUpdate(TDetailInfoDTO TDetailInfoDTO);

        /// <summary>
        /// ��������ɾ��һ��TDetailInfo��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TDetailInfoDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TDetailInfo��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TDetailInfoDTO TDetailInfoQueryById(string guid);

        /// <summary>
        /// ��ѯTDetailInfo���еļ�¼
        /// </summary>
        /// <returns>TDetailInfo�����м�¼����</returns>
        [OperationContract]
        List<TDetailInfoDTO> TDetailInfoQueryAll();

        [OperationContract]
        TDetailInfoDTO TDetailInfoGetByForignKey(string id);

        #endregion


        #region TDataInfo

        /// <summary>
        /// ����һ��TDataInfo��¼
        /// </summary>
        /// <param name="TDataInfoDTO">TDataInfoʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TDataInfoAdd(TDataInfoDTO TDataInfoDTO);

        /// <summary>
        /// ����һ��TDataInfo��¼
        /// </summary>
        /// <param name="TDataInfoDTO">TDataInfoʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TDataInfoUpdate(TDataInfoDTO TDataInfoDTO);

        /// <summary>
        /// ��������ɾ��һ��TDataInfo��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TDataInfoDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TDataInfo��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TDataInfoDTO TDataInfoQueryById(string guid);

        /// <summary>
        /// ��ѯTDataInfo���еļ�¼
        /// </summary>
        /// <returns>TDataInfo�����м�¼����</returns>
        [OperationContract]
        List<TDataInfoDTO> TDataInfoQueryAll();

        [OperationContract]
        bool TDataInfoUploadFile(byte[] buffer, string metaId, int index);

        [OperationContract]
        bool TDataInfoDownloadFile(out byte[] outstream, long length, string metaId);

        [OperationContract]
        List<TDataInfoDTO> TDataInGetByForginKey(string key);

        [OperationContract]
        List<TDataInfoDTO> TDataInGetByParentKey(string key);

        [OperationContract]
        List<TDataInfoDTO> TDataInQuery(bool limit, DateTime start, DateTime end, string keyword, string baseId);

         [OperationContract]
        void TDataInDoConvert(string metaId);
        #endregion



        #region TPromotion

        /// <summary>
        /// ����һ��TPromotion��¼
        /// </summary>
        /// <param name="TPromotionDTO">TPromotionʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TPromotionAdd(TPromotionDTO TPromotionDTO);

        /// <summary>
        /// ����һ��TPromotion��¼
        /// </summary>
        /// <param name="TPromotionDTO">TPromotionʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TPromotionUpdate(TPromotionDTO TPromotionDTO);

        /// <summary>
        /// ��������ɾ��һ��TPromotion��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TPromotionDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TPromotion��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TPromotionDTO TPromotionQueryById(string guid);

        /// <summary>
        /// ��ѯTPromotion���еļ�¼
        /// </summary>
        /// <returns>TPromotion�����м�¼����</returns>
        [OperationContract]
        List<TPromotionDTO> TPromotionQueryAll();

        #endregion


        #region TPlatform

        /// <summary>
        /// ����һ��TPlatform��¼
        /// </summary>
        /// <param name="TPlatformDTO">TPlatformʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TPlatformAdd(TPlatformDTO TPlatformDTO);

        /// <summary>
        /// ����һ��TPlatform��¼
        /// </summary>
        /// <param name="TPlatformDTO">TPlatformʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TPlatformUpdate(TPlatformDTO TPlatformDTO);

        /// <summary>
        /// ��������ɾ��һ��TPlatform��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TPlatformDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TPlatform��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TPlatformDTO TPlatformQueryById(string guid);

        /// <summary>
        /// ��ѯTPlatform���еļ�¼
        /// </summary>
        /// <returns>TPlatform�����м�¼����</returns>
        [OperationContract]
        List<TPlatformDTO> TPlatformQueryAll();

        [OperationContract]
        List<TPlatformDTO> TPlatformGetByForignKey(string key);

        #endregion

        #region TRecorder

        /// <summary>
        /// ����һ��TRecorder��¼
        /// </summary>
        /// <param name="TRecorderDTO">TRecorderʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TRecorderAdd(TRecorderDTO TRecorderDTO);

        /// <summary>
        /// ����һ��TRecorder��¼
        /// </summary>
        /// <param name="TRecorderDTO">TRecorderʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TRecorderUpdate(TRecorderDTO TRecorderDTO);

        /// <summary>
        /// ��������ɾ��һ��TRecorder��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TRecorderDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TRecorder��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TRecorderDTO TRecorderQueryById(string guid);

        /// <summary>
        /// ��ѯTRecorder���еļ�¼
        /// </summary>
        /// <returns>TRecorder�����м�¼����</returns>
        [OperationContract]
        List<TRecorderDTO> TRecorderQueryAll();

        [OperationContract]
        List<TRecorderDTO> TRecorderGetByForignKey(string key);

        #endregion

        #region TShopData

        /// <summary>
        /// ����һ��TShopData��¼
        /// </summary>
        /// <param name="TShopDataDTO">TShopDataʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TShopDataAdd(TShopDataDTO TShopDataDTO);

        /// <summary>
        /// ����һ��TShopData��¼
        /// </summary>
        /// <param name="TShopDataDTO">TShopDataʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TShopDataUpdate(TShopDataDTO TShopDataDTO);

        /// <summary>
        /// ��������ɾ��һ��TShopData��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TShopDataDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TShopData��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TShopDataDTO TShopDataQueryById(string guid);

        /// <summary>
        /// ��ѯTShopData���еļ�¼
        /// </summary>
        /// <returns>TShopData�����м�¼����</returns>
        [OperationContract]
        List<TShopDataDTO> TShopDataQueryAll();

        #endregion


        #region TPrice

        /// <summary>
        /// ����һ��TPrice��¼
        /// </summary>
        /// <param name="TPriceDTO">TPriceʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TPriceAdd(TPriceDTO TPriceDTO);

        /// <summary>
        /// ����һ��TPrice��¼
        /// </summary>
        /// <param name="TPriceDTO">TPriceʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TPriceUpdate(TPriceDTO TPriceDTO);

        /// <summary>
        /// ��������ɾ��һ��TPrice��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TPriceDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TPrice��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TPriceDTO TPriceQueryById(string guid);

        /// <summary>
        /// ��ѯTPrice���еļ�¼
        /// </summary>
        /// <returns>TPrice�����м�¼����</returns>
        [OperationContract]
        List<TPriceDTO> TPriceQueryAll();

        #endregion


        #region TPackage

        /// <summary>
        /// ����һ��TPackage��¼
        /// </summary>
        /// <param name="TPackageDTO">TPackageʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TPackageAdd(TPackageDTO TPackageDTO);

        /// <summary>
        /// ����һ��TPackage��¼
        /// </summary>
        /// <param name="TPackageDTO">TPackageʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TPackageUpdate(TPackageDTO TPackageDTO);

        /// <summary>
        /// ��������ɾ��һ��TPackage��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TPackageDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TPackage��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TPackageDTO TPackageQueryById(string guid);

        /// <summary>
        /// ��ѯTPackage���еļ�¼
        /// </summary>
        /// <returns>TPackage�����м�¼����</returns>
        [OperationContract]
        List<TPackageDTO> TPackageQueryAll();

        #endregion


        #region THardware

        /// <summary>
        /// ����һ��THardware��¼
        /// </summary>
        /// <param name="THardwareDTO">THardwareʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool THardwareAdd(THardwareDTO THardwareDTO);

        /// <summary>
        /// ����һ��THardware��¼
        /// </summary>
        /// <param name="THardwareDTO">THardwareʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool THardwareUpdate(THardwareDTO THardwareDTO);

        /// <summary>
        /// ��������ɾ��һ��THardware��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool THardwareDelete(string guid);

        /// <summary>
        /// ����������ѯһ��THardware��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        THardwareDTO THardwareQueryById(string guid);

        /// <summary>
        /// ��ѯTHardware���еļ�¼
        /// </summary>
        /// <returns>THardware�����м�¼����</returns>
        [OperationContract]
        List<THardwareDTO> THardwareQueryAll();

        #endregion


        #region TContract

        /// <summary>
        /// ����һ��TContract��¼
        /// </summary>
        /// <param name="TContractDTO">TContractʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TContractAdd(TContractDTO TContractDTO);

        /// <summary>
        /// ����һ��TContract��¼
        /// </summary>
        /// <param name="TContractDTO">TContractʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TContractUpdate(TContractDTO TContractDTO);

        /// <summary>
        /// ��������ɾ��һ��TContract��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TContractDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TContract��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TContractDTO TContractQueryById(string guid);

        /// <summary>
        /// ��ѯTContract���еļ�¼
        /// </summary>
        /// <returns>TContract�����м�¼����</returns>
        [OperationContract]
        List<TContractDTO> TContractQueryAll();

        #endregion


        #region TSubmit

        /// <summary>
        /// ����һ��TSubmit��¼
        /// </summary>
        /// <param name="TSubmitDTO">TSubmitʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TSubmitAdd(TSubmitDTO TSubmitDTO);

        /// <summary>
        /// ����һ��TSubmit��¼
        /// </summary>
        /// <param name="TSubmitDTO">TSubmitʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TSubmitUpdate(TSubmitDTO TSubmitDTO);

        /// <summary>
        /// ��������ɾ��һ��TSubmit��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TSubmitDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TSubmit��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TSubmitDTO TSubmitQueryById(string guid);

        /// <summary>
        /// ��ѯTSubmit���еļ�¼
        /// </summary>
        /// <returns>TSubmit�����м�¼����</returns>
        [OperationContract]
        List<TSubmitDTO> TSubmitQueryAll();

        #endregion


        #region TServer

        /// <summary>
        /// ����һ��TServer��¼
        /// </summary>
        /// <param name="TServerDTO">TServerʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TServerAdd(TServerDTO TServerDTO);

        /// <summary>
        /// ����һ��TServer��¼
        /// </summary>
        /// <param name="TServerDTO">TServerʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TServerUpdate(TServerDTO TServerDTO);

        /// <summary>
        /// ��������ɾ��һ��TServer��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TServerDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TServer��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TServerDTO TServerQueryById(string guid);

        /// <summary>
        /// ��ѯTServer���еļ�¼
        /// </summary>
        /// <returns>TServer�����м�¼����</returns>
        [OperationContract]
        List<TServerDTO> TServerQueryAll();

        #endregion


        #region TTrain

        /// <summary>
        /// ����һ��TTrain��¼
        /// </summary>
        /// <param name="TTrainDTO">TTrainʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TTrainAdd(TTrainDTO TTrainDTO);

        /// <summary>
        /// ����һ��TTrain��¼
        /// </summary>
        /// <param name="TTrainDTO">TTrainʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TTrainUpdate(TTrainDTO TTrainDTO);

        /// <summary>
        /// ��������ɾ��һ��TTrain��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TTrainDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TTrain��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TTrainDTO TTrainQueryById(string guid);

        /// <summary>
        /// ��ѯTTrain���еļ�¼
        /// </summary>
        /// <returns>TTrain�����м�¼����</returns>
        [OperationContract]
        List<TTrainDTO> TTrainQueryAll();

        #endregion


        #region TEmployee

        /// <summary>
        /// ����һ��TEmployee��¼
        /// </summary>
        /// <param name="TEmployeeDTO">TEmployeeʵ��</param>
        /// <returns>�Ƿ������ɹ�</returns>
        [OperationContract]
        bool TEmployeeAdd(TEmployeeDTO TEmployeeDTO);

        /// <summary>
        /// ����һ��TEmployee��¼
        /// </summary>
        /// <param name="TEmployeeDTO">TEmployeeʵ��</param>
        /// <returns>�Ƿ���³ɹ�</returns>
        [OperationContract]
        bool TEmployeeUpdate(TEmployeeDTO TEmployeeDTO);

        /// <summary>
        /// ��������ɾ��һ��TEmployee��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>�Ƿ�ɾ���ɹ�</returns>
        [OperationContract]
        bool TEmployeeDelete(string guid);

        /// <summary>
        /// ����������ѯһ��TEmployee��¼
        /// </summary>
        /// <param name="guid">����ֵ</param>
        /// <returns>��ѯ�Ľ��</returns>
        [OperationContract]
        TEmployeeDTO TEmployeeQueryById(string guid);

        /// <summary>
        /// ��ѯTEmployee���еļ�¼
        /// </summary>
        /// <returns>TEmployee�����м�¼����</returns>
        [OperationContract]
        List<TEmployeeDTO> TEmployeeQueryAll();

        #endregion
    }
}
