#region License

/*
 * Copyright 2002-2010 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using System.Reflection;
using GemStone.GemFire.Cache;

namespace Spring.Data.GemFire.Tests
{
    /// <summary>
    ///  
    /// </summary>
    /// <author>Mark Pollack</author>
    public class TestUtils
    {
        public static T ReadField<T>(string name, object target)
        {
            //FieldInfo fi = typeof(Foo).GetField("_bar", BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo fi = target.GetType().GetField(name, BindingFlags.NonPublic | BindingFlags.Instance);
            if (fi == null)
            {
                throw new IllegalArgumentException("Cannot find field '"  + name + "' in the class hierarchy of " + target.GetType());
            }
            return (T) fi.GetValue(target);
        }
    }

}