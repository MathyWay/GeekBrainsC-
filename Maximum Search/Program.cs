int MAX(int ret, int b, int c)
{
    if(b > ret) ret = b;
    if(c > ret) ret = c;
    return ret;
}
int[] array = {23, 34, 1, 231, 1222, -333333, 12, 643, 1245};

int max = MAX(MAX(array[0], array[1], array[2]),
            MAX(array[3], array[4], array[5]),
            MAX(array[6], array[7], array[8]));
Console.WriteLine(max);