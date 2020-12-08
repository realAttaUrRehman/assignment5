/*
 * YoutubeAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YoutubeAPI.Standard;
using YoutubeAPI.Standard.Utilities;


namespace YoutubeAPI.Standard.Models
{
    public class PageInfo : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int totalResults;
        private int resultsPerPage;

        /// <summary>
        /// Total results for the search.
        /// </summary>
        [JsonProperty("totalResults")]
        public int TotalResults 
        { 
            get 
            {
                return this.totalResults; 
            } 
            set 
            {
                this.totalResults = value;
                onPropertyChanged("TotalResults");
            }
        }

        /// <summary>
        /// Per page search items.
        /// </summary>
        [JsonProperty("resultsPerPage")]
        public int ResultsPerPage 
        { 
            get 
            {
                return this.resultsPerPage; 
            } 
            set 
            {
                this.resultsPerPage = value;
                onPropertyChanged("ResultsPerPage");
            }
        }
    }
} 