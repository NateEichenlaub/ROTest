using System;
using System.Data.Entity;

namespace TestModel
{
    public class TestDbInitialiser : DropCreateDatabaseIfModelChanges<TestDbContext>
    {
        protected override void Seed(TestDbContext context)
        {
            const int objectCount = 1000;
            const int randomTextLength = 1000;

            for(int i=0; i<objectCount; i++)
            {
                context.TestObjects.Add(new TestObject(randomTextLength)
                {
                    CreatedDate = DateTime.Now,
                    ObjectA = new ObjectA(randomTextLength),
                    ObjectB = new ObjectB(randomTextLength)
                });
                //System.Diagnostics.Debug.WriteLine(i);
            }

            base.Seed(context);
        }
    }
}