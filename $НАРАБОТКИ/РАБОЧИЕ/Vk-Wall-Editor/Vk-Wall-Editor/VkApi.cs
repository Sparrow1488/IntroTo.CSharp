using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using xNet;

namespace Vk_Wall_Editor
{
    public class VkApi
    {
        public static string AccessToken = null;
        public string urlVkMethods = "https://api.vk.com/method/";
        public string accessTokenString = "access_token=";

        public string friendsOnlineMethod = $"friends.getOnline?v=5.52";
        public string friends = "users.get?v=5.52";
        public string apiVersion = "v=5.130";
        public VkApi(string accessToken)
        {
            AccessToken = accessToken;
        }
        public int[] GetOnline()
        {
            using (var request = new HttpRequest())
            {
                request.UserAgent = Http.ChromeUserAgent();
                var response = request.Get(urlVkMethods + friendsOnlineMethod + "&" + accessTokenString + AccessToken);
                var dic = JsonConvert.DeserializeObject<Dictionary<string, int[]>>(response.ToString());
                List<int> usersID = null;
                foreach (var item in dic.Values)
                    return item;
                return null;
            }
        }
        public string GetFriends()
        {
            using (var request = new HttpRequest())
            {
                request.UserAgent = Http.ChromeUserAgent();
                var response = request.Get(urlVkMethods + friends + "&" + accessTokenString + AccessToken);
                var dic = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, dynamic>>>(response.ToString());
                List<int> usersID = null;
                string fullName = null;
                foreach (var item in dic.Values)
                {
                    foreach (var str in item)
                    {
                        fullName += str.Value;
                    }
                }
                return fullName;
            }
        }
    }
}
