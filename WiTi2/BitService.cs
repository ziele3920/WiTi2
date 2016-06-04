
namespace WiTi2
{
    class BitService
    {
        public int ClearBit(int value, int index)
        {
            value &= ~(1 << index);
            return value;
        }

        public int SetBit(int value, int index)
        {
            value |= (1 << index);
            return value;
        }

        public bool CheckBit(int value, int index)
        {
            bool bit = ((value >> index) & 1) == 1 ? true : false;
            return bit;
        }

        public int TwoPowX(int power)
        {
            return (1 << power);
        }
    }
}
