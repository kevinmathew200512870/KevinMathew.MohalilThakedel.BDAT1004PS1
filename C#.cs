dynamic x=5;
Console.WriteLine(x.GetType());

dynamic y=5.0;
Console.WriteLine(y.GetType());

dynamic z= 5>1;
Console.WriteLine(z.GetType());

dynamic a= '5';
Console.WriteLine(a.GetType());

dynamic b=5*2;
Console.WriteLine(b.GetType());

dynamic c ='5' * 2;
Console.WriteLine(c.GetType());

dynamic d ='5' * '2';
Console.WriteLine(d.GetType());

dynamic d =5/2;
Console.WriteLine(d.GetType());

dynamic d =5%2;
Console.WriteLine(d.GetType());

int[] d ={5,2,1};
Console.WriteLine(d.GetType());

dynamic d = 5==3;
Console.WriteLine(d.GetType());

a=3.14;
Console.WriteLine(a.GetType());

string text ="Supercalifragilisticexpialidocious" ;
Console.WriteLine("Number of letters in string: " +text.Length);

string text ="Supercalifragilisticexpialidocious" ;
string sub ="ice";
bool a  = text.Contains(sub);
Console.WriteLine("Is there substring ice in the text? : " +a);

string s1 ="Supercalifragilisticexpialidocious" ;
string s2 ="Honorificabilitudinitatibus" ;
string s3 = "Bababadalgharaghtakamminarronnkonn" ;
if ( s1.Length> s2.Length && s1.Length>s3.Length )
{
Console.WriteLine("Longest String: " +s1);
}
else if (s2.Length> s1.Length && s2.Length>s3.Length )
{
Console.WriteLine("Longest String: " +s2);
}
else
{
Console.WriteLine("Longest String: " +s3);
}

SortedDictionary<string, string> composers = new SortedDictionary<string, string>(); 
composers.Add("Berlioz","1");
composers.Add("Borodin","2");
composers.Add("Brian","3");
composers.Add("Bartok","4");
composers.Add("Bellini","5");
composers.Add("Buxtehude","6");
composers.Add("Bernstein","7");
composers.ElementAt(0);
composers.ElementAt(composers.Count -1);
Console.WriteLine("First in Dictionary: " +composers.ElementAt(0) );
Console.WriteLine("Last in Dictionary: " +composers.ElementAt(composers.Count -1) );

double triangleArea(int a, int b, int c)
{
double s = (double)(a+b+c)/2;
double x= (double)(s*(s - a)*(s -b)*(s -c));
double area = Math.Sqrt(x);
return area;
}
Console.WriteLine(triangleArea(2,2,2));

using System;
 
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = new int[100];
        int[] even = new int[100];
        int[] odd = new int[100];
 
        int evenElementCount = 0;
        int oddElementCount = 0;
        Console.WriteLine("Input the number of elements to be stored in the array:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input " + n + " elements in the array:");
        for (int i = 0; i < n; i++) {
            Console.Write("element - " + i + " :");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++) {
            if (arr[i]%2 == 0) {
                even[evenElementCount] = arr[i];
                evenElementCount ++;
            } else {
                odd[oddElementCount] = arr[i];
                oddElementCount ++;
            }
        }
 
        Console.WriteLine("The Even elements are:");
        for (int i = 0; i < evenElementCount; i++) {
              Console.Write(even[i] + " ");
        }
 
        Console.WriteLine("\nThe Odd elements are:");
        for (int i = 0; i < oddElementCount; i++) {
            Console.Write(odd[i] + " ");
        }
    }
}

bool inside(double x,double y,double x1,double y1,double x2,double y2)
{
 if(x>x1 && x<x2  && y>y1 && y<y2)
 
  return true;
 
 else 
 return false;
}
Console.WriteLine(inside(1,1,0,0,2,3));
Console.WriteLine(inside(-1,-1,0,0,2,3));
Console.WriteLine(inside(1,1,0.3,0.5,1.1,0.7) && inside(1,1,0.5,0.2,1.1,2));


