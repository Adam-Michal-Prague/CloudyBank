using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using DotNetOpenAuth.OAuth;
using CloudyBank.Web.Security.OAuth;
using DotNetOpenAuth.Messaging;
using DotNetOpenAuth.OAuth.Messages;

namespace CloudyBank.Web
{
    public class OAuth : IHttpHandler, IRequiresSessionState
    {
        ServiceProvider sp;

        public OAuth()
        {
            sp = new ServiceProvider(Constants.SelfDescription, Global.TokenManager, new CustomOAuthMessageFactory(Global.TokenManager));
        }

        public void ProcessRequest(HttpContext context)
        {
            IProtocolMessage request = sp.ReadRequest();
            RequestScopedTokenMessage requestToken;
            UserAuthorizationRequest requestAuth;
            AuthorizedTokenRequest requestAccessToken;
            if ((requestToken = request as RequestScopedTokenMessage) != null)
            {
                var response = sp.PrepareUnauthorizedTokenMessage(requestToken);
                sp.Channel.Send(response);
            }
            else if ((requestAuth = request as UserAuthorizationRequest) != null)
            {
                Global.PendingOAuthAuthorization = requestAuth;
                HttpContext.Current.Response.Redirect("~/Sites/Authorize.aspx");
            }
            else if ((requestAccessToken = request as AuthorizedTokenRequest) != null)
            {
                var response = sp.PrepareAccessTokenMessage(requestAccessToken);
                sp.Channel.Send(response);
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        public bool IsReusable
        {
            get { return true; }
        }
    }
}
