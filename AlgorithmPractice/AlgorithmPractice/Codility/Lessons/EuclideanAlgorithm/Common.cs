namespace AlgorithmPractice.Codility.Lessons.EuclideanAlgorithm
{
    public class Common
    {
        /// <summary>
        /// get gcd(N, M)
        /// </summary>
        /// <param name="N"></param>
        /// <param name="M"></param>
        /// <returns></returns>
        public static int GCD(int N, int M)
        {
            if (N % M == 0)
                return M;
            else
                return GCD(M, N % M);
        }
    }
}
