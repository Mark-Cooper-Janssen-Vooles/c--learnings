using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        // to look something up by a key, use a dictionary
        // to look something up by an index, use a list

        //key should be type string, value of type string
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get 
            {
                return _dictionary[key];
            }
            set 
            {
                _dictionary[key] = value;
            }
        }
    }
}
