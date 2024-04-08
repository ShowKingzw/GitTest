#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// 枚举
enum gender
{
    male,
    female
};
// 结构体
struct person
{
    char name[20];
    int age;
    enum gender gender;
};
int main()
{

#pragma region 输出

    printf("Hello World!\n穿山甲\n");
    printf("鸡汤来喽\n");
    // printf()默认同行输出
    //  system("pause");    // 防止运行后自动退出，需头文件stdlib.h

#pragma endregion

#pragma region 格式化输出（占位符输出）
    int num1 = 10;
    double num2 = 20;
    float num3 = 30;
    char char1 = 'M';

    //  %d 或 %i  int
    printf("这是一个int:%d\n", num1);
    //  %lf	double
    printf("这是一个double:%lf\n", num2);
    //  %f	float
    printf("这是一个float:%f\n", num3);
    //  %c	char
    printf("这是一个char:%c\n", char1);

#pragma endregion

#pragma region 常量
    const double pi = 3.14159;
    printf("%lf\n", pi);
#pragma endregion

#pragma region switch
    int day = 4;

    switch (day)
    {
    case 1:
        printf("Monday");
        break;
    case 2:
        printf("Tuesday");
        break;
    case 3:
        printf("Wednesday");
        break;
    case 4:
        printf("Thursday");
        break;
    case 5:
        printf("Friday");
        break;
    case 6:
        printf("Saturday");
        break;
    case 7:
        printf("Sunday");
        break;
    default: // 放在最后，且不需要break
        printf("null");
        printf("\n");
    }

#pragma endregion

#pragma region for循环
    for (int i = 0; i < 10; i++)
    {
        /* code */
        printf("%d\n", i);
    }

#pragma endregion

#pragma region 数组array
    int arr1[] = {1, 2, 3}; // 声明1
    for (int i = 0; i < 3; i++)
    {
        printf("元素%d\n", arr1[i]);
    }
    // 根据下标修改
    arr1[0] = 4;
    arr1[1] = 5;
    arr1[2] = 6;
    for (int i = 0; i < 3; i++)
    {
        printf("元素%d\n", arr1[i]);
    }
    // 声明2
    int arr2[3]; // 固定数组大小
    arr2[0] = 4;
    arr2[1] = 5;
    arr2[2] = 6;
    for (int i = 0; i < 3; i++)
    {
        printf("元素%d\n", arr2[i]);
    }
    #pragma endregion

#pragma region 字符串char[]
    char char2[] = "M这是一个字符串";
    printf(":::%s\n", char2);
    printf("::%c\n", char2[0]); // 访问字符串
    // 修改字符串
    char2[0] = 'K';
    printf("::%s\n", char2);

    // 声明字符串另一方式 必须加一个 \0
    char charArr[] = {'K', 'L', 'C', '\0'};
    printf("%s\n", charArr);
#pragma endregion

#pragma region 结构体
    // 声明1
    struct person lc =
        {
            .name = "aaaa",
            .age = 18,
            .gender = male};

    // 声明2
    struct person la = {"bb", 10, female};

    // 声明3
    struct person ls;
    strcpy(ls.name, "kk");
    ls.age = 20;
    ls.gender = male;

    printf("%s,%d,%d\n", lc.name, lc.age, lc.gender);
    printf("%s,%d,%d\n", la.name, la.age, la.gender);
    printf("%s,%d,%d\n", ls.name, ls.age, ls.gender);

#pragma endregion

    system("pause");
    return 0;
}
