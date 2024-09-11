public interface Pplan
{
    void release();
}
public class Product : Pplan
{
    public void release()
    {
        Console.WriteLine("tyda syda millioner");
    }
}
public class productplan : Pplan
{
    public void release()
    {
        Console.WriteLine("tyda syda new millioner");
    }
}

public interface goplan
{
    Pplan Create();
}
 public class productgoplan : goplan
{
    public Pplan Create()
    {
        return new Product();
    }
}
public class anotherproductgoplan: goplan
{
    public Pplan Create()
    {
        return new productplan();
    }
}
internal static class program
{
    public static void Main(string[] arg)
    {
        goplan creator = new productgoplan();
        Pplan product = creator.Create();

        creator = new anotherproductgoplan();
        Pplan anotherproduct = creator.Create();
        product.release();
        anotherproduct.release();
    }
}