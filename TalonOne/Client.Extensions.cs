using System.Net.Http;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace TalonOne
{
    public partial class Client
    {
        protected Regex signedPathsRegex =
            new Regex(@"^/v1/(!?(!?customer_sessions|customer_profiles)/\w+|events|referrals|customer_profiles_search)");

        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url)
        {
            request.Headers.Add("User-Agent", "TalonOne.NET/1");

            MaybeSignRequest(request, url);
            MaybeAddBearerToken(request);
        }

        private void MaybeSignRequest(HttpRequestMessage request, string url)
        {
            if (request.Method != HttpMethod.Put && request.Method != HttpMethod.Post) {
                // only sign requests with a payload
                return;
            }

            if (!signedPathsRegex.IsMatch(request.RequestUri.AbsolutePath)) {
                // only sign requests to the paths in the Integration API
                return;
            }

            var payload = request.Content.ReadAsByteArrayAsync().GetAwaiter().GetResult();
            using (var hmac = new HMACMD5(_clientConfig.ApplicationKeyBytes))
            {
                var signature = System.BitConverter.ToString(hmac.ComputeHash(payload));
                var header = string.Format("signer={0}; signature={1}", _clientConfig.ApplicationId, signature.Replace("-", "").ToLower());
                request.Headers.Add("Content-Signature", header);
            }
        }

        private void MaybeAddBearerToken(HttpRequestMessage request)
        {
            if (signedPathsRegex.IsMatch(request.RequestUri.AbsolutePath)) {
                return;
            }
            if (_clientConfig.BearerToken != null && _clientConfig.BearerToken.Length > 0) {
                request.Headers.Add("Authorization", string.Format("Bearer {0}", _clientConfig.BearerToken));
            }
        }
    }
}