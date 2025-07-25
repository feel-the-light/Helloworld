﻿using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Keycloak.Net.Tests
{
    public partial class KeycloakClientShould
    {
        [Theory]
        [InlineData("master")]
        public async Task GetClientsAsync(string realm)
        {
            var result = await _client.GetClientsAsync(realm);
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GenerateClientSecretAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GenerateClientSecretAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientSecretAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientSecretAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetDefaultClientScopesAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetDefaultClientScopesAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance", "insurance-product")]
        public async Task GenerateClientExampleAccessTokenAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GenerateClientExampleAccessTokenAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetProtocolMappersInTokenGenerationAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetProtocolMappersInTokenGenerationAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientGrantedScopeMappingsAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientGrantedScopeMappingsAsync(realm, clientsId, realm);
                Assert.NotNull(result);
                result = await _client.GetClientGrantedScopeMappingsAsync(realm, clientsId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientNotGrantedScopeMappingsAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientNotGrantedScopeMappingsAsync(realm, clientsId, realm);
                Assert.NotNull(result);
                result = await _client.GetClientNotGrantedScopeMappingsAsync(realm, clientsId, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientProviderAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var providerInstances = await _client.GetIdentityProviderInstancesAsync(realm);
                string providerInstanceId = providerInstances.FirstOrDefault()?.ProviderId;
                if (providerInstanceId != null)
                {
                    string result = await _client.GetClientProviderAsync(realm, clientsId, providerInstanceId);
                    Assert.NotNull(result);
                }
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientAuthorizationPermissionsInitializedAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientAuthorizationPermissionsInitializedAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientOfflineSessionCountAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                int? result = await _client.GetClientOfflineSessionCountAsync(realm, clientsId);
                Assert.True(result >= 0);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientOfflineSessionsAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientOfflineSessionsAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetOptionalClientScopesAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetOptionalClientScopesAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GenerateClientRegistrationAccessTokenAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GenerateClientRegistrationAccessTokenAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory(Skip = "Not working yet")]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetUserForServiceAccountAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetUserForServiceAccountAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientSessionCountAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                int? result = await _client.GetClientSessionCountAsync(realm, clientsId);
                Assert.True(result >= 0);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task TestClientClusterNodesAvailableAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.TestClientClusterNodesAvailableAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetClientUserSessionsAsync(string realm, string clientId)
        {
            var clients = await _client.GetClientsAsync(realm);
            string clientsId = clients.FirstOrDefault(x => x.ClientId == clientId)?.Id;
            if (clientsId != null)
            {
                var result = await _client.GetClientUserSessionsAsync(realm, clientsId);
                Assert.NotNull(result);
            }
        }

        [Theory]
        [InlineData("Insurance", "insurance-product")]
        public async Task GetResourcesOwnedByClientAsync(string realm, string clientId)
        {
	        var result = await _client.GetResourcesOwnedByClientAsync(realm, clientId);
	        Assert.NotNull(result);
        }
    }
}
