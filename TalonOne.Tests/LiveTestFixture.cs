using System;
using System.Threading.Tasks;
using TalonOne;
using Xunit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TalonOne.Tests
{
    [CollectionDefinition("LiveTest")]
    public class LiveTestCollection : ICollectionFixture<LiveTestFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }

    /// <summary>This fixture provides a TalonOne.Client that will perform real requests</summary>
    public class LiveTestFixture : IAsyncLifetime
    {
        public ClientConfig ClientConfig { get; private set; }
        public Client Client { get; private set; }
        public Session Session { get; private set; }

        public Application Application { get; private set; }

        public LiveTestFixture() {
        }

        public async Task InitializeAsync()
        {
            var secrets = new ConfigurationBuilder().AddUserSecrets("TalonOne.Tests.Credentials").Build();

            ClientConfig = new ClientConfig();
            Client = new Client(ClientConfig);
            Client.BaseUrl = secrets["Endpoint"];

            Session = await Client.CreateSessionAsync(new LoginParams
            {
               Email = secrets["Email"],
               Password = secrets["Password"],
            });

            ClientConfig.BearerToken = Session.Token;

            // Use Client.GetApplicationAsync(appId) to fetch an existing application.
            Application = await Client.CreateApplicationAsync(new NewApplication{
                Name = string.Format("Test application {0}", System.Environment.GetEnvironmentVariable("TRAVIS_JOB_ID")),
                Key = "fefecafedeadbeef",
                Timezone = "Etc/UTC",
                Currency = "USD",
            });

            ClientConfig.ApplicationId = Application.Id;
            ClientConfig.ApplicationKey = Application.Key;
        }

        public async Task DisposeAsync()
        {
            if (Application != null) {
                await Client.DeleteApplicationAsync(Application.Id);
            }
            if (Session != null) {
                await Client.DestroySessionAsync();
            }
        }
    }
}