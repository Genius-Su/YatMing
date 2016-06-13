using iTelluro.Explorer.Infrastructure.CrossCutting.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.Web;

namespace iTelluro.Explorer.YatMing.Service.InstanceProviders
{
    public class AttachDataSignBehavior : IDispatchMessageInspector
    {
        #region IDispatchMessageInspector ��Ա
        public object AfterReceiveRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel, System.ServiceModel.InstanceContext instanceContext)
        {
            int index = request.Headers.FindHeader("SSOToken", "http://www.infoearth.com");
            if (index >= 0)
            {
                string token = request.Headers.GetHeader<string>(index);
            }
            else
            {
#if DEBUG
                // return null;
#endif
               // LoggerFactory.CreateLog().LogError(string.Format("û�к���Token����Ϣͷ��({0}����)", 1));
                //  throw new Exception("û�к���Token����Ϣͷ��");
            }
            return null;
        }

        public void BeforeSendReply(ref System.ServiceModel.Channels.Message reply, object correlationState)
        {

        }
        #endregion

    }
}
