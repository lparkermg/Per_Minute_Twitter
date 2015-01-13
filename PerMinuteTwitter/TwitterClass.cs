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
            TwitterCredentials.SetCredentials(); //Take out actual details before commiting to git and pushing to github.
        }

        public static string[] SearchForTweet(string searchTerm)
        {
            var searchParameter = Search.GenerateSearchTweetParameter(searchTerm);
            string[] returnText = new string[2];
            searchParameter.Lang = Language.English;
            searchParameter.SearchType = SearchResultType.Recent;
            searchParameter.MaximumNumberOfResults = 1;
            var grabbedTweet = Search.SearchTweets(searchTerm);
            returnText[0] = grabbedTweet[0].Creator.Name;
            returnText[1] = grabbedTweet[0].Text;
            return returnText; ;
        }

       /* public static string SearchTwitterJson()
        {
            return SearchJson.SearchTweets("gamedev");
        }*/
    }
}
