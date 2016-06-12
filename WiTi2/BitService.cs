
namespace WiTi2
{
    class BitService
    {
        public bool CheckBit(int value, int index)
        {
            return ((value >> index) & 1) == 1 ? true : false;
        }

        public int ClearBit(int value, int index)
        {
            return value &= ~(1 << index);
        }

        public int SetBit(int value, int index)
        {
            return value |= (1 << index);
        }

        public int TwoPowX(int power)
        {
            return (1 << power);
        }
    }
}
