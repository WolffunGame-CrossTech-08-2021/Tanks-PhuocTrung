public static class BitExtensions
{
    public static int SetBitTo1(this int value, int position)
    {
        return value |= (1 << position);
    }
    
    public static int SetBitTo0(this int value, int position)
    {
        return value & ~(1 << position);
    }
    
    public static bool IsBitSetTo1(this int value, int position)
    {
        return (value & (1 << position)) != 0;
    }
    
    public static bool IsBitSetTo0(this int value, int position)
    {
        return !IsBitSetTo1(value, position);
    }
}
