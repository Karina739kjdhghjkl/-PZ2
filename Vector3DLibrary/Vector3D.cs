namespace Vector3DLibrary
{
    public class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector3D() { }

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public void Input()
        {
            Console.WriteLine("Введіть координати вектора:");
            Console.Write("X: ");
            X = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            Y = double.Parse(Console.ReadLine());
            Console.Write("Z: ");
            Z = double.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Vector3D({X}, {Y}, {Z})";
        }

        public static Vector3D operator +(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3D operator -(Vector3D v1, Vector3D v2)
        {
            return new Vector3D(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static Vector3D operator *(Vector3D v, double scalar)
        {
            return new Vector3D(v.X * scalar, v.Y * scalar, v.Z * scalar);
        }

        public static double operator *(Vector3D v1, Vector3D v2)
        {
            return (v1.X * v2.X) + (v1.Y * v2.Y) + (v1.Z * v2.Z);
        }

        public static bool operator ==(Vector3D v1, Vector3D v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y && v1.Z == v2.Z;
        }

        public static bool operator !=(Vector3D v1, Vector3D v2)
        {
            return !(v1 == v2);
        }

        public static bool operator >(Vector3D v1, Vector3D v2)
        {
            return v1.Magnitude() > v2.Magnitude();
        }

        public static bool operator <(Vector3D v1, Vector3D v2)
        {
            return v1.Magnitude() < v2.Magnitude();
        }

        public double Magnitude()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
    }
}
