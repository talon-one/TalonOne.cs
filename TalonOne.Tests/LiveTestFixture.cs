using System;
using System.Threading.Tasks;
using TalonOne;
using Xunit;

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

        public Application Application { get; private set; }

        public LiveTestFixture() {
        }

        public async Task InitializeAsync()
        {
            ClientConfig = new ClientConfig
            {
                BearerToken = System.Environment.GetEnvironmentVariable("TALONONE_SESSION_TOKEN"),
            };

            Client = new Client(ClientConfig)
            {
                BaseUrl = System.Environment.GetEnvironmentVariable("TALONONE_ENDPOINT"),
            };

            Application = await Client.CreateApplicationAsync(new NewApplication{
                Name = string.Format("Test application {0}", System.Environment.GetEnvironmentVariable("TRAVIS_JOB_ID")),
                Key = "fefecafedeadbeef",
                Timezone = "Etc/UTC",
                Currency = "USD",
            });

            ClientConfig.ApplicationId = Application.Id;
            ClientConfig.ApplicationKey = Application.Key;

            Client = new Client(ClientConfig)
            {
                BaseUrl = System.Environment.GetEnvironmentVariable("TALONONE_ENDPOINT"),
            };
        }

        public async Task DisposeAsync()
        {
            if (Application != null) {
                await Client.DeleteApplicationAsync(Application.Id);
            }
        }
    }
}