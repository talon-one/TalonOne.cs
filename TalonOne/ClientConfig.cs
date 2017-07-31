using System.Linq;

namespace TalonOne
{
    public class ClientConfig
    {

        public byte[] ApplicationKeyBytes { get; private set; }
        public int ApplicationId;
        private string _applicationKeyString;
        public string ApplicationKey {
            get { return _applicationKeyString; }
            set {
                ApplicationKeyBytes = Enumerable.Range(0, value.Length)
                        .Where(x => x % 2 == 0)
                        .Select(x => System.Convert.ToByte(value.Substring(x, 2), 16))
                        .ToArray();
                _applicationKeyString = value;
            }
        }

        // <summary>Used for authenticating requests as a particular user</summary>
        public string BearerToken;
    }
}