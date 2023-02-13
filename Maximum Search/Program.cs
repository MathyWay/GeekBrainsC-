int MAX(int ret, int b, int c)
{
    if(b > ret) ret = b;
    if(c > ret) ret = c;
    return ret;
}
int a1 = 21;
int a2 = -37;
int a3 = 123;
int a4 = 43;
int a5 = 100002;
int a6 = -1002;
int a7 = 246;
int a8= 2;
int a9 = 333;

int max = MAX(MAX(a1, a2, a3),
            MAX(a4, a5, a6),
            MAX(a7, a8, a9));
Console.WriteLine(max);