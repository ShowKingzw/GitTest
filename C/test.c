#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// ö��
enum gender
{
    male,
    female
};
// �ṹ��
struct person
{
    char name[20];
    int age;
    enum gender gender;
};
int main()
{

#pragma region ���

    printf("Hello World!\n��ɽ��\n");
    printf("�������\n");
    // printf()Ĭ��ͬ�����
    //  system("pause");    // ��ֹ���к��Զ��˳�����ͷ�ļ�stdlib.h

#pragma endregion

#pragma region ��ʽ�������ռλ�������
    int num1 = 10;
    double num2 = 20;
    float num3 = 30;
    char char1 = 'M';

    //  %d �� %i  int
    printf("����һ��int:%d\n", num1);
    //  %lf	double
    printf("����һ��double:%lf\n", num2);
    //  %f	float
    printf("����һ��float:%f\n", num3);
    //  %c	char
    printf("����һ��char:%c\n", char1);

#pragma endregion

#pragma region ����
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
    default: // ��������Ҳ���Ҫbreak
        printf("null");
        printf("\n");
    }

#pragma endregion

#pragma region forѭ��
    for (int i = 0; i < 10; i++)
    {
        /* code */
        printf("%d\n", i);
    }

#pragma endregion

#pragma region ����array
    int arr1[] = {1, 2, 3}; // ����1
    for (int i = 0; i < 3; i++)
    {
        printf("Ԫ��%d\n", arr1[i]);
    }
    // �����±��޸�
    arr1[0] = 4;
    arr1[1] = 5;
    arr1[2] = 6;
    for (int i = 0; i < 3; i++)
    {
        printf("Ԫ��%d\n", arr1[i]);
    }
    // ����2
    int arr2[3]; // �̶������С
    arr2[0] = 4;
    arr2[1] = 5;
    arr2[2] = 6;
    for (int i = 0; i < 3; i++)
    {
        printf("Ԫ��%d\n", arr2[i]);
    }
    #pragma endregion

#pragma region �ַ���char[]
    char char2[] = "M����һ���ַ���";
    printf(":::%s\n", char2);
    printf("::%c\n", char2[0]); // �����ַ���
    // �޸��ַ���
    char2[0] = 'K';
    printf("::%s\n", char2);

    // �����ַ�����һ��ʽ �����һ�� \0
    char charArr[] = {'K', 'L', 'C', '\0'};
    printf("%s\n", charArr);
#pragma endregion

#pragma region �ṹ��
    // ����1
    struct person lc =
        {
            .name = "aaaa",
            .age = 18,
            .gender = male};

    // ����2
    struct person la = {"bb", 10, female};

    // ����3
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
