using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValSystem.Integracao.Controller.LocaSMS;

namespace ValSystem.Integracao.Controller
{
    public class LocaSMSController : ServiceSMSSoap
    {
        public string GetBalance( string User, string Pwd )
        {
            throw new NotImplementedException();
        }

        public Task<string> GetBalanceAsync( string User, string Pwd )
        {
            throw new NotImplementedException();
        }

        public DataSet GetStatus( string User, string Pwd, string Id )
        {
            throw new NotImplementedException();
        }

        public Task<DataSet> GetStatusAsync( string User, string Pwd, string Id )
        {
            throw new NotImplementedException();
        }

        public DataSet GetStatusByRef( string User, string Pwd, string Id, string Ref )
        {
            throw new NotImplementedException();
        }

        public Task<DataSet> GetStatusByRefAsync( string User, string Pwd, string Id, string Ref )
        {
            throw new NotImplementedException();
        }

        public string SendSMS( string User, string Pwd, rSMS SmsMessage )
        {
            throw new NotImplementedException();
        }

        public Task<string> SendSMSAsync( string User, string Pwd, rSMS SmsMessage )
        {
            throw new NotImplementedException();
        }

        public string SetHoldSMS( string User, string Pwd, string Id )
        {
            throw new NotImplementedException();
        }

        public Task<string> SetHoldSMSAsync( string User, string Pwd, string Id )
        {
            throw new NotImplementedException();
        }

        public string SetReleaseSMS( string User, string Pwd, string Id )
        {
            throw new NotImplementedException();
        }

        public Task<string> SetReleaseSMSAsync( string User, string Pwd, string Id )
        {
            throw new NotImplementedException();
        }
    }
}
