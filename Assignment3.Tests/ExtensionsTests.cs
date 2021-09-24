using System;
using Xunit;


namespace BDSA2020.Assignment03.Tests
{
    public class ExtensionsTests
    {
        [Theory]
        [InlineData("http://info.cern.ch/hypertext/WWW/TheProject.html")]
        [InlineData("http://go.com/")]
        public void IsSecure_given_http_url_is_false(string uriString)
        {
            var uri = new Uri(uriString);
            Assert.False(uri.IsSecure());
        }

        [Theory]
        [InlineData("https://www.google.com/search?client=firefox-b-d&q=the+answer+to+life+the+universe+and+everything")]
        [InlineData("https://open.kattis.com/")]
        public void IsSecure_given_https_url_is_true(string uriString)
        {
            var uri = new Uri(uriString);
            Assert.True(uri.IsSecure());
        }

        [Theory]
        [InlineData("wss://www.example.com/socketserver")]
        [InlineData("wss://edu.test.dk")]
        public void IsSecure_given_wss_url_is_false(string uriString)
        {
            var uri = new Uri(uriString);
            Assert.False(uri.IsSecure());
        }

        [Theory]
        [InlineData("Hey my dear TA, I hope you're have a nice day!", 12)]
        [InlineData("wss://edu.test.dk", 4)]
        [InlineData("", 0)]
        [InlineData("I love deadlines. I like the whooshing sound they make as they fly by.", 14)]
        public void WordCount_returns_number_of_words_in_string(string input, int expectedNumWords)
        {
            var numWords = input.WordCount();
            Assert.Equal(expectedNumWords, numWords);
        }
    }
}
