/*
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

namespace Glass.Mapper.Sc.CastleWindsor
{
    /// <summary>
    /// Config
    /// </summary>
    public class Config
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Config"/> class.
        /// </summary>
        public Config()
        {
            UseWindsorContructor = false;
        }
        /// <summary>
        /// Indicates that classes should be build using the Windsor dependency resolver. Default is False
        /// </summary>
        /// <value>
        /// <c>true</c> if [use windsor contructor]; otherwise, <c>false</c>.
        /// </value>
        public bool UseWindsorContructor { get; set; }

        /// <summary>
        /// Indicates that caching should be enabled by Glass
        /// </summary>
        public bool EnableCaching { get; set; }
    }
}

