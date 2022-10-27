using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Text;

namespace SB.Shared.Services
{
    public class CachingProvider
    {
        private MemoryCache _cache;

        public CachingProvider()
        {
            _cache = new MemoryCache(nameof(CachingProvider));
        }

        public void SetItem(string key, Object value, double updateTime = 60)
        {
            _cache.Set(key, value, DateTime.Now.AddMinutes(updateTime));
        }
        public object GetItem(string key)
        {
           return _cache.Get(key);
        }

    }
}
