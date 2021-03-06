using System.Threading.Tasks;
using Appson.Identity.Client.Model.Authentication;
using Appson.Identity.Client.Util;

namespace Appson.Identity.Client.ClientSections
{
    public class EmailAuthenticationSection
    {
        public async Task<EmailAuthenticationResponse> AuthenticateAsync(string email,
            string password)
        {
            try
            {
                var req = new EmailAuthenticationInput { Email = email, Password = password };
                var response =
                    await HttpHelper.Post<EmailAuthenticationResponse>(EndpointAddresses.AuthenticationEmail, req);
                return response;
            }
            catch (System.Exception)
            {
                return default(EmailAuthenticationResponse);
            }
        }
    }
}