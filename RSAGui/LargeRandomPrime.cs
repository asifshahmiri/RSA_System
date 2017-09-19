using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Numerics;
using System.Collections;

namespace RSAGui
{
    class LargeRandomPrime
    {
        public enum NumberType
        {
            Composite,
            Prime
        }

        public bool IsPrimeMillerRabin(BigInteger integer)
        {
            NumberType type = MillerRabin(integer, 400);
            return type == NumberType.Prime;
        }

        public bool IsPrimePseudo(BigInteger integer)
        {
            NumberType type = PseudoPrime(integer);
            return type == NumberType.Prime;
        }

        // Primality testing based on Miller-Rabin
        public NumberType MillerRabin(BigInteger n, int s)
        {
            BigInteger nMinusOne = BigInteger.Subtract(n, 1);

            for (int j = 1; j <= s; j++)
            {
                BigInteger a = Random(1, nMinusOne);

                if (Witness(a, n))
                {
                    return NumberType.Composite;
                }
            }

            return NumberType.Prime;
        }

        // Generates a random BigInteger between min and max
        public BigInteger Random(BigInteger min, BigInteger max)
        {
            byte[] maxBytes = max.ToByteArray();
            BitArray maxBits = new BitArray(maxBytes);
            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < maxBits.Length; i++)
            {
                // Randomly set the bit
                int randomInt = random.Next();
                if ((randomInt % 2) == 0)
                {
                    // Reverse the bit
                    maxBits[i] = !maxBits[i];
                }
            }

            BigInteger result = new BigInteger();

            // Convert the bits back to a BigInteger
            for (int k = (maxBits.Count - 1); k >= 0; k--)
            {
                BigInteger bitValue = 0;

                if (maxBits[k])
                {
                    bitValue = BigInteger.Pow(2, k);
                }

                result = BigInteger.Add(result, bitValue);
            }

            // Generate the random number
            BigInteger randomBigInt = BigInteger.ModPow(result, 1, BigInteger.Add(max, min));
            return randomBigInt;
        }

        // Pseudo primality testing with Fermat's theorem
        public NumberType PseudoPrime(BigInteger n)
        {
            BigInteger modularExponentiation =
                            ModularExponentiation(2,
                                                  BigInteger.Subtract(n, 1),
                                                  n);
            if (!modularExponentiation.IsOne)
            {
                return NumberType.Composite;
            }
            else
            {
                return NumberType.Prime;
            }
        }

        public bool Witness(BigInteger a, BigInteger n)
        {
            KeyValuePair<int, BigInteger> tAndU = GetTAndU(BigInteger.Subtract(n, 1));
            int t = tAndU.Key;
            BigInteger u = tAndU.Value;
            BigInteger[] x = new BigInteger[t + 1];

            x[0] = ModularExponentiation(a, u, n);

            for (int i = 1; i <= t; i++)
            {
                // x[i] = x[i-1]^2 mod n
                x[i] = BigInteger.ModPow(BigInteger.Multiply(x[i - 1], x[i - 1]), 1, n);
                BigInteger minus = BigInteger.Subtract(x[i - 1], BigInteger.Subtract(n, 1));

                if (x[i] == 1 && x[i - 1] != 1 && !minus.IsZero)
                {
                    return true;
                }
            }

            if (!x[t].IsOne)
            {
                return true;
            }

            return false;
        }

        public KeyValuePair<int, BigInteger> GetTAndU(BigInteger nMinusOne)
        {
            // Convert n - 1 to a byte array
            byte[] nBytes = nMinusOne.ToByteArray();
            BitArray bits = new BitArray(nBytes);
            int t = 0;
            BigInteger u = new BigInteger();

            int n = bits.Count - 1;
            bool lastBit = bits[n];

            // Calculate t
            while (!lastBit)
            {
                t++;
                n--;
                lastBit = bits[n];
            }

            for (int k = ((bits.Count - 1) - t); k >= 0; k--)
            {
                BigInteger bitValue = 0;

                if (bits[k])
                {
                    bitValue = BigInteger.Pow(2, k);
                }

                u = BigInteger.Add(u, bitValue);
            }

            KeyValuePair<int, BigInteger> tAndU = new KeyValuePair<int, BigInteger>(t, u);
            return tAndU;
        }

        public BigInteger ModularExponentiation(BigInteger a, BigInteger b, BigInteger n)
        {
            // a^b mod n
            return BigInteger.ModPow(a, b, n);
        }
    }
}
