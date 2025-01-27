﻿/*
   Copyright 2012 Michael Edwards
 
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 
*/
//-CRE-

namespace Glass.Mapper.Sc
{
    public class Config : Glass.Mapper.Config
    {
        public Config()
        {
            ForceItemInPageEditor = true;
            UseGlassHtmlLambdaCache = true;
        }
        public bool ForceItemInPageEditor { get; set; }

        /// <summary>
        /// When using Lazy Enumerables this setting indicates that proxy objects
        /// should be used. Be default this is false.
        /// </summary>
        public bool UseProxiesForLazyEnumerables { get; set; }

        /// Indicates it the lambda expressions used by Editable expression in renderings are cached for performance.
        /// By default this is true, if you experience caching issue then set this to false.
        /// </summary>
        public bool UseGlassHtmlLambdaCache { get; set; }
    }
}
