using System.Collections.Generic;

namespace Parcel.Objects
{
  public class Package
  {
    private int _weight;
    private int _height;
    private int _length;
    private int _width;
    private static List<Package> _instance = new List<Package> {};

    public Package(int packageWeight, int packageHeight, int packageLength, int packageWidth)
    {
      _weight = packageWeight;
      _height = packageHeight;
      _length = packageLength;
      _width = packageWidth;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }

    public int GetWeight()
    {
      return _weight;
    }
    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }
    public int GetHeight()
    {
      return _height;
    }
    public void SetLength(int newLength)
    {
      _length = newLength;
    }
    public int GetLength()
    {
      return _length;
    }
    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }
    public int GetWidth()
    {
      return _width;
    }
    public static List<Package> GetAll()
    {
      return _instance;
    }
    public void Save()
    {
      _instance.Add(this);
    }
    public static void ClearAll()
    {
      _instance.Clear();
    }
  }
}
