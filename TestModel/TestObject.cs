using NakedObjects;
using System;

namespace TestModel
{
    public class TestObject
    {
        public IDomainObjectContainer Container { set; protected get; }

        public override string ToString()
        {
            var t = Container.NewTitleBuilder();
            t.Append(Number);
            return t.ToString();
        }


        public TestObject() { }
        
        public TestObject(int textLength)
        {
            Number = Util.RandomNumber();
            Text = Util.RandomText(textLength);
        }

        [NakedObjectsIgnore]
        public virtual int Id { get; set; }

        public virtual int Number { get; set; }
        public virtual string Text { get; set; }
        public virtual DateTime CreatedDate { get; set; }

        public virtual ObjectA ObjectA { get; set; }
        public virtual ObjectB ObjectB { get; set; }
    }

    public class ObjectA
    {
        public ObjectA() { }
        public ObjectA(int textLength)
        {
            Number = Util.RandomNumber();
            Text = Util.RandomText(textLength);
        }

        [NakedObjectsIgnore]
        public virtual int Id { get; set; }

        public virtual int Number { get; set; }
        public virtual string Text { get; set; }
    }

    public class ObjectB
    {
        public ObjectB() { }
        public ObjectB(int textLength)
        {
            Number = Util.RandomNumber();
            Text = Util.RandomText(textLength);
        }

        [NakedObjectsIgnore]
        public virtual int Id { get; set; }

        public virtual int Number { get; set; }
        public virtual string Text { get; set; }
    }
}

