using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using NakedObjects;
using NakedObjects.Services;


namespace TestModel
{
    public class TestRepository : AbstractFactoryAndRepository
    {
        public IQueryable<TestObject> AllTestObjects()
        {
            return Container.Instances<TestObject>();
        }

    }
}
