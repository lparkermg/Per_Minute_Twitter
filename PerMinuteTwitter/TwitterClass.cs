using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Json;
using Tweetinvi.Core.Enum;
using Tweetinvi.Core.Interfaces;
using Tweetinvi.Core.Interfaces.Models.Parameters;

namespace PerMinuteTwitter
{
    class TwitterClass
    {
        public static void SetTwitterAuth()
        {
            TwitterCredentials.SetCredentials("AT", "AS", "CK", "CS"); //Take out actual details before commiting to git and pushing to github.
        }

        public static string SearchForTweet(string searchTerm)
        {
            var searchParameter = Search.GenerateSearchTweetParameter(searchTerm);
            searchParameter.Lang = Language.English;
            searchParameter.SearchType = SearchResultType.Recent;
            searchParameter.MaximumNumberOfResults = 1;
            var grabbedTweet = Search.SearchTweets(searchTerm);
            return grabbedTweet[0].ToString();
        }

       /* public static string SearchTwitterJson()
        {
            return SearchJson.SearchTweets("gamedev");
        }*/
    }
}
