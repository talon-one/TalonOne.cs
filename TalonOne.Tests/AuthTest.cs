using System;
using System.Collections.ObjectModel;
using Xunit;
using TalonOne;

namespace TalonOne.Tests
{
    // E2E testing of the client
    [Collection("LiveTest")]
    public class AuthTest
    {
        private LiveTestFixture liveAPI;

        public AuthTest(LiveTestFixture fixture)
        {
            liveAPI = fixture;
        }

        [Fact]
        async public void SignIntegrationRequests()
        {
            var state = await liveAPI.Client.UpdateCustomerSessionAsync("hello-dotnet", new NewCustomerSession {
                ProfileId = "user-1234",
            });
            Assert.Equal(state.Profile.IntegrationId, "user-1234");
        }

        [Fact]
        async public void AddBearerTokenToOtherRequests()
        {
            var campaign = await liveAPI.Client.CreateCampaignAsync(liveAPI.Application.Id, new NewCampaign
            {
                Name = "My test campaign",
                Description = "Campaign description",
                State = NewCampaignState.Disabled,
                Tags = new ObservableCollection<string>(),
            });
            var campaigns = await liveAPI.Client.GetCampaignsAsync(10, 0, "", liveAPI.Application.Id);
            Assert.Equal(campaign.Id, campaigns.Data[0].Id);
        }
    }
}
