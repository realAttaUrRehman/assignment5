/*
 * YoutubeAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using YoutubeAPI.Standard.Controllers;
using YoutubeAPI.Standard.Http.Client;
using YoutubeAPI.Standard.Utilities;

namespace YoutubeAPI.Standard
{
    public partial class YoutubeAPIClient
    {

        /// <summary>
        /// Singleton access to Youtube controller
        /// </summary>
        public YoutubeController Youtube
        {
            get
            {
                return YoutubeController.Instance;
            }
        }
        /// <summary>
        /// The shared http client to use for all API calls
        /// </summary>
        public IHttpClient SharedHttpClient
        {
            get
            {
                return BaseController.ClientInstance;
            }
            set
            {
                BaseController.ClientInstance = value;
            }        
        }
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public YoutubeAPIClient() { }

        /// <summary>
        /// Client initialization constructor
        /// </summary>
        public YoutubeAPIClient(string key = "AIzaSyAAfjYIRPepalfP3M6UBnHeWj9MQUil1f4")
        {
            Configuration.Key = key;
        }
        #endregion
    }
}