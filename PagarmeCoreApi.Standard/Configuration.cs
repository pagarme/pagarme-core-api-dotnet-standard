using PagarmeCoreApi.Standard.Models;
namespace PagarmeCoreApi.Standard
{
    public partial class Configuration
    {


        //The base Uri for API calls
        public static string BaseUri = "https://api.pagar.me/core/v5";

        //TODO: Replace the ServiceRefererName with an appropriate value
        public static string ServiceRefererName = "";

        //The username to use with basic authentication
        //TODO: Replace the BasicAuthUserName with an appropriate value
        public static string BasicAuthUserName = "";

        //The password to use with basic authentication
        //TODO: Replace the BasicAuthPassword with an appropriate value
        public static string BasicAuthPassword = "";

    }
}