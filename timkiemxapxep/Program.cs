using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timkiemxapxep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[500];
            int n;
            Console.Write("cho biet phan tu cua mang:");
            n = int.Parse(Console.ReadLine());
            //PhatSinhMang(a, n);
            //Console.Write("mang duoc phat sinh ngau nhien:");
            nhapmang(a, n);
            Console.WriteLine("mang ban dau:");
            Xuatmang(a, n);

            Console.WriteLine("\n ket qua cua tung buoc thuat toan:");
            BubbleSort(a, n);
            //QuicSort(a, 0,n-1);
            //InterChangeSort(a, n);
            Console.Write("\nmang duoc sap xep tang:");
            Xuatmang(a, n);
            //Console.Write("\nnhat gia tri can tim:");
            //int x = int.Parse(Console.ReadLine());
            //int kq = TimTuyenTinh(a, n, x);

            //if (kq == -1)
            //    Console.WriteLine($"{x} khong xuat hien trong mang");
            //else
            //    Console.WriteLine($"{x} xuat hien trong mang:");

            Console.ReadLine();
        }
        static void PhatSinhMang(int[] a, int n)
        {
            Random R = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = R.Next(10);
            }
        }
        static void nhapmang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuatmang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }
        static int TimTuyenTinh(int[] a, int n, int x)
        {
            int i = 0;
            while (i < n && a[i] != x)
            {
                i++;
            }
            if (i == n)
                return -1;
            else
                return i;
        }
        static int TinhNhiPhan(int[] a, int n, int x)
        {
            int left, right, mid;
            left = 0;
            right = n - 1;
            while (left >= right)
            {
                mid = (left + right) / 2;
                if (a[mid] == x)
                    return x;
                else if (a[mid] > x)
                    right = mid - 1;
                else
                    left = mid + 1;

            }
            return -1;

        }
        static void InterChangeSort(int[] a, int n)
        {
            int tan;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        tan = a[i];
                        a[i] = a[j];
                        a[j] = tan;
                    }
                }
                Console.Write($"\nlan lap i={i}:");
                Xuatmang(a, n);
            }
        }
        static void SelecitionSort(int[] a, int n)
        {
            int tan;
            int dem = 0;
            for (int i = 0; i < n - 1; i++)
            {
                int  min=i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[min] > a[j])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    tan = a[i];
                    a[i] = a[min];
                    a[min] = tan;
                    dem++;
                }
                Console.Write($"\nlan lap i={i}:");
                Xuatmang(a, n);
            }
            Console.WriteLine($"So lan hoan vi:{dem}");
        }
        static void QuicSort(int[] a,int left, int right)
        {
            int tan;
            int i = left;
            int j= right;
            int x = a[(left+right)/2];
            while ( i <= j )
            {
                while ( a[i] < x ) i++;
                while (a[j] > x ) j--;
                if(i<=j)
                {
                    tan= a[i];
                    a[i] = a[j]; a[j] = tan;
                    i++;
                    j--;
                }
            }
            if(left<j)
                QuicSort(a, left, j);
            if(i<right)
                QuicSort(a, right, i);
            
        }
        static void BubbleSort(int[] a, int n)
        {
            int tan;
            int dem = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0 ; i < n-1; j--)
                {
                    if (a[j+1] > a[j])
                    {
                        tan = a[j];
                        a[j] = a[j-1];
                        a[j-1] = tan;
                    }
                }
                //Console.Write($"\nlan lap i={i}:");
                //Xuatmang(a, n);
            }
        }

    }
}
