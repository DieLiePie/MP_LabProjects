
#include <stdlib.h>

int main() // ����� �������
{
    float a, b, d; // ������������� ����������
    const float pi = 3.14; // ���������

    //����
    printf("Input a, b: \n");
    scanf_s("%f", &a); // ����
    scanf_s("%f", &b);

    //�1
    printf("//1 \n");
    printf("S=%f \n", a*b); // �����
    printf("P=%f \n", 2 * (a + b));

    //�2
    printf("//2 \n");
    printf("Input D: \n");
    scanf_s("%f", &d); // ����
    printf("L=%f \n", d*pi); // �����

    //�3
    printf("//3 \n");
    printf("SA=%f \n", (a+b)/2); // �����

    //�4
    printf("//4 \n");
    printf("sum_kv=%f \n", a*a + b*b); // �����
    printf("Rz_kv=%f \n", (a*a)-(b*b));
    printf("Pr_kv=%f \n", a*a*b*b);
    printf("Ch_kv=%f \n", (a*a) / (b*b));

    //�5
    a = abs(a);
    b = abs(b);
    printf("//5 \n");
    printf("sumv=%f \n", a + b);
    printf("Rz=%f \n", (a - b));
    printf("Pr=%f \n", a*b);
    printf("Ch=%f \n", a / b);
}
