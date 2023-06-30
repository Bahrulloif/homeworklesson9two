public class Point3D : Point2D
{
    private int _z;

    public Point3D()
    {

    }
    public Point3D(int x, int y, int z) : base(x, y)
    {
        _z = z;
    }
    public int GetZ()
    {
        return _z;
    }
    public void SetZ(int z)
    {
        _z = z;
    }
   
    public override string ToString()
    {
        return $"{base.ToString()},{_z})";
    }
}