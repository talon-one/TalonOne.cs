namespace TalonOne
{
    public class ClientBase
    {
        protected ClientConfig _clientConfig;

        public ClientBase(ClientConfig config)
        {
            _clientConfig = config;
        }
    }
}