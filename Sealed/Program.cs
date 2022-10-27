//public class NonInheritanceClass:BaseClass
//{
        //Miras alinamaz
//}

public sealed class BaseClass
{

}

public class ChildClass : ClassWithSealedMethod
{
    public sealed override string GetTime()
    {
        return DateTime.Now.ToString("f");
    }
}

public class ChildClass2 : ChildClass
{
    // Method override edilemez

    //public override string GetTime()
    //{
    //    return DateTime.Now.ToString("f");
    //}
}

public class ClassWithSealedMethod
{
    public virtual string GetTime()
    {
        return DateTime.Now.ToString();
    } 
}