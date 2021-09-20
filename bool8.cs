namespace Marble
{
  public struct bool8
  {
    private byte _num;
    
    public bool Get(int index)
    {
      var i = 1 << index;
      return (_num & i) != 0;
    }
    
    public bool Set(int index, bool value)
    {
      var i = 1 << index;
      if (value)
      {
        _num = (byte)(_num | i);
      }
      else
      {
        _num = (byte)(_num & ~i);
      }
      
    }
      
    public void Toggle(int index)
    {
        var i = 1 << index;
        _num = (byte)(_num ^ i);
    }
    
    public void ToggleAll()
    {
      _num = (byte)(~num);
    }
  }
}
