﻿using System.Net.Http;
using System.Threading.Tasks;
using GoogleLogin.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GoogleLogin.Services
{
    /// <summary>
    /// Doc: https://developers.google.com/identity/protocols/OAuth2InstalledApp
    /// </summary>
    public class GoogleServices
    {
        /// <summary>
        /// Create a new app and get new creadentials: 
        /// https://console.developers.google.com/apis/
        /// </summary>
        public static readonly string ClientId = "1014438478778-bjg3gtmogejgahvjbnj2p97lgrps031e.apps.googleusercontent.com";
        public static readonly string ClientSecret = "VfalyPULwbc18OY5luxyI44n";
        public static readonly string RedirectUri = "https://www.youtube.com/channel/UC85GXDPrtaHkD56pw5W0nAw";

        public async Task<string> GetAccessTokenAsync(string code)
        {
            var requestUrl =
                "https://www.googleapis.com/oauth2/v4/token" 
                + "?code=" + code
                + "&client_id=" + ClientId
                + "&client_secret=" + ClientSecret
                + "&redirect_uri=" + RedirectUri
                + "&grant_type=authorization_code";

            var httpClient = new HttpClient();

            var response = await httpClient.PostAsync(requestUrl, null);

            var json = await response.Content.ReadAsStringAsync();

            var accessToken = JsonConvert.DeserializeObject<JObject>(json).Value<string>("access_token");

            return accessToken;
        }

        public async Task<GoogleProfile> GetGoogleUserProfileAsync(string accessToken)
        {
            var requestUrl = "https://www.googleapis.com/plus/v1/people/me" + "?access_token=" + accessToken;

            var httpClient = new HttpClient();

            var userJson = await httpClient.GetStringAsync(requestUrl);

            var googleProfile = JsonConvert.DeserializeObject<GoogleProfile>(userJson);

            return googleProfile;
        }
    }
}