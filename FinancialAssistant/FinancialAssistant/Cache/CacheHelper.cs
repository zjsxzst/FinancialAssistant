﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Caching;

namespace FinancialAssistant.Cache
{
    //|------------------------------------------------------------|
    //|                    基础信息：                              |
    //|     名称：CacheHelper                                      |
    //|     功能：Cache操作                                        |
    //|     最后修改时间：2017/10/28                               |
    //|------------------------------------------------------------|
    public class CacheHelper
    {
        /// <summary>  
        /// 获取数据缓存  
        /// </summary>  
        /// <param name="cacheKey">键</param>  
        public static object GetCache(string cacheKey)
        {
            var objCache = HttpRuntime.Cache.Get(cacheKey);
            return objCache;
        }
        /// <summary>  
        /// 设置数据缓存  
        /// </summary>  
        public static void SetCache(string cacheKey, object objObject)
        {
            var objCache = HttpRuntime.Cache;
            objCache.Insert(cacheKey, objObject);
        }
        /// <summary>  
        /// 设置数据缓存  
        /// </summary>  
        public static void SetCache(string cacheKey, object objObject, int timeout = 7200)
        {
            try
            {
                if (objObject == null) return;
                var objCache = HttpRuntime.Cache;
                //相对过期  
                //objCache.Insert(cacheKey, objObject, null, DateTime.MaxValue, timeout, CacheItemPriority.NotRemovable, null);  
                //绝对过期时间  
                objCache.Insert(cacheKey, objObject, null, DateTime.Now.AddSeconds(timeout), TimeSpan.Zero, CacheItemPriority.High, null);
            }
            catch (Exception)
            {
                //throw;  
            }
        }
        /// <summary>  
        /// 移除指定数据缓存  
        /// </summary>  
        public static void RemoveAllCache(string cacheKey)
        {
            var cache = HttpRuntime.Cache;
            cache.Remove(cacheKey);
        }
        /// <summary>  
        /// 移除全部缓存  
        /// </summary>  
        public static void RemoveAllCache()
        {
            var cache = HttpRuntime.Cache;
            var cacheEnum = cache.GetEnumerator();
            while (cacheEnum.MoveNext())
            {
                cache.Remove(cacheEnum.Key.ToString());
            }
        }
    }
}
