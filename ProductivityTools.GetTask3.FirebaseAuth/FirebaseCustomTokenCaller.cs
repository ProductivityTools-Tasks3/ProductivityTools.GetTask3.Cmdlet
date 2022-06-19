using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace ProductivityTools.GetTask3.FirebaseAuth
{
    public class FirebaseCustomTokenCaller
    {
        public async void SetAccessTokenFirebase()
        {
            var customToken = await GetCustomToken();
            var accessToken = GetAccesTooken(customToken);
        }

        async Task<string> GetCustomToken()
        {
            var HttpClient = new HttpClient();
            Uri url = new Uri(@"http://127.0.0.1:8080/CustomToken/Get");

            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await HttpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var resultAsString = await response.Content.ReadAsStringAsync();
                // T result = JsonConvert.DeserializeObject<T>(resultAsString);
                return resultAsString;
            }
            throw new Exception(response.ReasonPhrase);
        }

        async Task<string> GetAccesTooken(string custom_token)
        {


            var HttpClient = new HttpClient();
            Uri url = new Uri(@"https://identitytoolkit.googleapis.com/v1/accounts:signInWithCustomToken?key=AIzaSyAr0HCAH_e80NeivpRm7PJls50O0sX2Y18");

            HttpClient.DefaultRequestHeaders.Accept.Clear();
            HttpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            object obj = new { token = custom_token, returnSecureToken = true };
            var dataAsString = JsonConvert.SerializeObject(obj);
            var content = new StringContent(dataAsString, Encoding.UTF8, "application/json");


            HttpResponseMessage response = await HttpClient.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                var resultAsString = await response.Content.ReadAsStringAsync();
                TT result = JsonConvert.DeserializeObject<TT>(resultAsString);
                return result.idToken;
            }
            throw new Exception(response.ReasonPhrase);
        }

        public class TT
        {
            public string kind { get; set; }
            public string idToken { get; set; }
            public string refreshToken { get; set; }
            public string exiresIn { get; set; }

            public bool isNewUser { get; set; }
        }
    }
}