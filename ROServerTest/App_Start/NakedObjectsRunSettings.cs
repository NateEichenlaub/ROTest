// Copyright Naked Objects Group Ltd, 45 Station Road, Henley on Thames, UK, RG9 1AT
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. 
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0.
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and limitations under the License.

using System;
using NakedObjects.Core.Configuration;
using NakedObjects.Persistor.Entity.Configuration;
using TestModel;

namespace ROServerTest {
    public class NakedObjectsSettings {
        public static string RestRoot
        {
            get { return "api"; }
        }

        private static Type[] Types {
            get {
                return new Type[] {
                };
            }
        }

        private static Type[] Services {
            get {
                return new Type[] {
                    typeof(TestRepository)
                };
            }
        }

        //private static Type[] AssociatedTypes() {
        //    var allTypes = AppDomain.CurrentDomain.GetAssemblies().Single(a => a.GetName().Name == "AdventureWorksModel").GetTypes();
        //    return allTypes.Where(t => t.BaseType == typeof (AWDomainObject) && !t.IsAbstract).ToArray();
        //}

        public static ReflectorConfiguration ReflectorConfig() {
            return new ReflectorConfiguration(Types, Services, new string[] { "TestModel" });
        }

        public static EntityObjectStoreConfiguration EntityObjectStoreConfig() {
            var config = new EntityObjectStoreConfiguration();
            config.UsingCodeFirstContext(() => new TestDbContext());
            return config;
        }

		//public static IMenuBuilder[] MainMenus(IMenuFactory factory) {
        //    //e.g. var menu1 = factory.NewMenu<MyService1>(true); //then add to returned array
        //    return new IMenuBuilder[] {  };
        //}
    }
}