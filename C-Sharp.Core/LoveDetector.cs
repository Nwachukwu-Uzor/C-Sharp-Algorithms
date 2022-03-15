namespace C_Sharp.Core
{
    public class LoveDetector
    {
        public static bool lovefunc(int flower1, int flower2)
        {
            return flower1 + flower2 != 0 && (flower1 + flower2) % 2 > 0;
        }
    }
}
