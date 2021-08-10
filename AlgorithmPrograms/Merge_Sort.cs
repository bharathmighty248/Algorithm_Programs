using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class Merge_Sort
    {
        // Merges two subarrays of []arr.
        // First subarray is arr[left..mid]
        // Second subarray is arr[mid+1..right]
        public void merge(int[] arr, int left, int mid, int right)
        {
            // Find sizes of two
            // subarrays to be merged
            int n1 = mid - left + 1;
            int n2 = right - mid;

            // Create temp arrays
            int[] Left = new int[n1];
            int[] Right = new int[n2];
            int i, j;

            // Copy data to temp arrays
            for (i = 0; i < n1; ++i)
                Left[i] = arr[left + i];
            for (j = 0; j < n2; ++j)
                Right[j] = arr[mid + 1 + j];

            // Merge the temp arrays

            // Initial indexes of first
            // and second subarrays
            i = 0;
            j = 0;

            // Initial index of merged
            // subarry array
            int k = left;
            while (i < n1 && j < n2)
            {
                if (Left[i] <= Right[j])
                {
                    arr[k] = Left[i];
                    i++;
                }
                else
                {
                    arr[k] = Right[j];
                    j++;
                }
                k++;
            }

            // Copy remaining elements
            // of L[] if any
            while (i < n1)
            {
                arr[k] = Left[i];
                i++;
                k++;
            }

            // Copy remaining elements
            // of R[] if any
            while (j < n2)
            {
                arr[k] = Right[j];
                j++;
                k++;
            }
        }

        // Main function that
        // sorts arr[l..r] using
        // merge()
        public void sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle
                // point
                int mid = left + (right - left) / 2;

                // Sort first and
                // second halves
                sort(arr, left, mid);
                sort(arr, mid + 1, right);

                // Merge the sorted halves
                merge(arr, left, mid, right);
            }
        }

        // A utility function to
        // print array of size n */
        public void Display(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
