using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using WebShop;
using static Client.CachingExtensions;

namespace Client
{
    class CachingProductRepository : IProductRepository, IDisposable
    {
        private readonly IProductRepository _inner;
        private readonly MemoryCache _cache;

        public CachingProductRepository( IProductRepository inner )
        {
            _inner = inner;
            _cache = new MemoryCache(new MemoryCacheOptions());
        }

        #region IDisposable Members

        public void Dispose()
        {
            _cache.Dispose();
        }

        #endregion

        #region IProductRepository Members

        public Product GetById( int id )
        {
            string cacheKey = id.ToCacheKey();

            // Retrieve cached product for id, if exists
            if (_cache.TryGetValue(cacheKey, out Product product) == false)
            {
                // Lookup underlying product repository and update cache
                product = _inner.GetById(id);
                _cache.Set(cacheKey, product);
            }

            // Safe to return Product object directly from cache because it's immutable
            return product;
        }

        public void Add( Product product )
        {
            // Always upsert underlying product repository and update cache
            _inner.Add(product);
            _cache.Set(product.Id.ToCacheKey(), product);

            // See if all was previously cached as a list
            if (_cache.TryGetValue(AllCacheKey, out IList<Product> all) == true)
            {
                // We need to upsert the cached product as the full list has now been modified
                IList<Product> newAll = all
                    .Where(p => p.Id != product.Id)
                    .ToList();
                newAll.Add(product);

                _cache.Set(AllCacheKey, newAll);
            }
        }

        public IEnumerable<Product> GetAll()
        {
            // See if all was previously cached as a list
            if (_cache.TryGetValue(AllCacheKey, out IList<Product> all) == false)
            {
                // Update all the individual items in the cache, because we do not know if we have seen all elements
                all = _inner
                        .GetAll()
                        .ToList();
                foreach (Product product in all)
                {
                    _cache.Set(product.Id.ToCacheKey(), product);
                }

                // Create a separate cache item for the full collection as a list
                // (for easy returning as well as re-updating when Add() is later invoked again)
                _cache.Set(AllCacheKey, all);
            }

            // Necessary to copy Product instances to a new array to avoid exposing cached
            // List <Product>-object to clients (as the list itself is *not* immutable)
            return all.ToArray();
        }

        #endregion
    }
}