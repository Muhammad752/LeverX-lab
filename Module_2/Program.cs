// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Text;

Console.WriteLine("Hello, World!");


static int mult3and5(int num)
{
    int sum = 0;
    if (num < 0)
    {
        return 0;
    }
    for (int i = 0; i < num; i++)
    {
        if(i%3 == 0 || i%5==0) {
            sum += i;
        }
    }
    return sum;
}

//Console.WriteLine(mult3and5(-10));

static string numToStr(string str)
{
    IDictionary<char,int> keyValuePairs = new Dictionary<char,int>();
    string nums="";
    foreach (char a in str)
    {
        if (keyValuePairs.ContainsKey(a))
        {
            keyValuePairs[a] += 1;
            nums += keyValuePairs[a];
        }
        else
        {
            keyValuePairs.Add(a, 1);
            nums += keyValuePairs[a];
        }
    }
    Console.WriteLine(nums);
    return nums;
}

//numToStr("Hello World!");
//numToStr("aaaaaaaaaaaaaa");

static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iter)
{
    var first = iter.First();

    var uniques = new List<T>();

    uniques.Add(first);

    foreach (var i in iter)
    {
        if (i.Equals(first))
        {
            continue;
        }
        first = i;
        uniques.Add(i);
    }
    foreach (var item in uniques)
    {
        Console.Write(item);
    }
    Console.WriteLine();
    return uniques;
}
//UniqueInOrder("AAAABBBCCDAABBB");
//UniqueInOrder("ABBCcAD");

//Couldn't find data type that suits
//UniqueInOrder([1, 2, 2, 3, 3]);  


static int ips_between(string a,string b)
{
    double size_a=0,size_b=0;
    var nNum = new StringBuilder();
    a += ".";
        double power = Math.Pow(256,3);
    foreach(char n in a)
    {
        if(n == '.')
        {
            //Console.WriteLine("Number added:" + nNum);
            Console.WriteLine(Double.Parse(nNum.ToString()));
            size_a += power * Double.Parse(nNum.ToString());
            power /= 256;
            nNum = new StringBuilder();
            Console.WriteLine($"size: {size_a}, power {power}");
        }
        else
        {
            //Console.WriteLine("adding char" + n);
            nNum.Append(n);
        }
    }
    Console.WriteLine() ;
    nNum = new StringBuilder();
    power = Math.Pow(256, 3);
    b += ".";
    foreach (char n in b)
    {
        if (n == '.')
        {
            //Console.WriteLine("Number added:" + nNum);
            Console.WriteLine(Double.Parse(nNum.ToString()));
            size_b += power * Double.Parse(nNum.ToString());
            power /= 256;
            nNum = new StringBuilder();
            Console.WriteLine($"size: {size_a}, power {power}");
        }
        else
        {
            //Console.WriteLine("adding char" + n);
            nNum.Append(n);
        }
    }
    Console.WriteLine("Size b is" + size_b);
    int diff=(int)(size_b - size_a);
    Console.WriteLine(diff);
    return diff;
}

//ips_between("10.0.0.0","10.0.0.50");
//ips_between("10.0.0.0","10.0.1.0");
//ips_between("20.0.0.10","20.0.1.0");

static Array createSpiral(int n)
{
    int val = 1;
    int[,] arr=new int[n,n];
    int m = n;
    int k = 0, l = 0;
    while (k < m && l < n)
    {

        for (int i = l; i < n; ++i)
        {
            arr[k, i] = val++;
        }

        k++;
        for (int i = k; i < m; ++i)
        {
            arr[i, n - 1] = val++;
        }
        n--;
        if (k < m)
        {
            for (int i = n - 1; i >= l; --i)
            {
                arr[m - 1, i] = val++;
            }
            m--;
        }
        if (l < n)
        {
            for (int i = m - 1; i >= k; --i)
            {
                arr[i, l] = val++;
            }
            l++;
        }
    }
    return arr;
}
int num = 5;
int[,] arr = (int[,])createSpiral(num);

for(int i = 0; i < num; i++)
{
    for (int j = 0; j < num; j++)
    {
        string space = " ";
        if (arr[i, j]/10 < 1)
            space="  ";
        Console.Write(arr[i, j] + space);
    }
    Console.WriteLine();
}