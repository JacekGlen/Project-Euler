using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple.Problems
{
    public class Problem11
    {
        int[,] inputArray;
        int inputArraySizeX;
        int inputArraySizeY;

        public Problem11(string inputArrayStr)
        {
            if (String.IsNullOrWhiteSpace(inputArrayStr))
            {
                throw new ArgumentNullException("inputArrayStr");
            }

            var yLines = inputArrayStr.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            if (yLines.Length == 0)
            {
                throw new ArgumentNullException("inputArrayStr");
            }

            inputArraySizeX = yLines[0].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Length;
            inputArraySizeY = yLines.Length;

            inputArray = new int[inputArraySizeX, inputArraySizeY];

            for (int y = 0; y < inputArraySizeY; y++)
            {
                var lineValues = yLines[y].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                for (int x = 0; x < inputArraySizeX; x++)
                {
                    inputArray[x, y] = int.Parse(lineValues[x]);
                }
            }
        }

        public Int64 FindMaxProduct(int elementsInProduct)
        {
            Int64 currentMaxProduct = 0;

            for (int x = 0; x < inputArraySizeX; x++)
                for (int y = 0; y < inputArraySizeY; y++)
                {
                    currentMaxProduct = Math.Max(currentMaxProduct, CalculateHorizontalProduct(x, y, elementsInProduct));
                    currentMaxProduct = Math.Max(currentMaxProduct, CalculateVerticalProduct(x, y, elementsInProduct));
                    currentMaxProduct = Math.Max(currentMaxProduct, CalculateSlashDiagonalProduct(x, y, elementsInProduct));
                    currentMaxProduct = Math.Max(currentMaxProduct, CalculateBackslashDiagonalProduct(x, y, elementsInProduct));
                }

            return currentMaxProduct;
        }

        private Int64 CalculateHorizontalProduct(int x, int y, int elementsInProduct)
        {
            if ((x + elementsInProduct) > inputArraySizeX)
            {
                return 0;
            }

            Int64 product = 1;

            for (int i = x; i < x + elementsInProduct; i++)
            {
                product = product * inputArray[i, y];
            }

            return product;
        }

        private Int64 CalculateVerticalProduct(int x, int y, int elementsInProduct)
        {
            if ((y + elementsInProduct) > inputArraySizeY)
            {
                return 0;
            }

            Int64 product = 1;

            for (int i = y; i < y + elementsInProduct; i++)
            {
                product = product * inputArray[x, i];
            }

            return product;
        }

        private Int64 CalculateSlashDiagonalProduct(int x, int y, int elementsInProduct)
        {
            if ((x + elementsInProduct) > inputArraySizeX || (y + elementsInProduct) > inputArraySizeX)
            {
                return 0;
            }

            Int64 product = 1;

            for (int i = 0; i < elementsInProduct; i++)
            {
                product = product * inputArray[x + i, y + i];
            }

            return product;
        }

        private Int64 CalculateBackslashDiagonalProduct(int x, int y, int elementsInProduct)
        {
            if ((x + elementsInProduct) > inputArraySizeX || (y - elementsInProduct) < 0)
            {
                return 0;
            }

            Int64 product = 1;

            for (int i = 0; i < elementsInProduct; i++)
            {
                product = product * inputArray[x + i, y - i];
            }

            return product;
        }
    }
}
