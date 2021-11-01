
#include <stdlib.h>

int main() // старт функции
{
    float a, b, d; // Инициализация переменных
    const float pi = 3.14; // Константа

    //Ввод
    printf("Input a, b: \n");
    scanf_s("%f", &a); // Ввод
    scanf_s("%f", &b);

    //№1
    printf("//1 \n");
    printf("S=%f \n", a*b); // Вывод
    printf("P=%f \n", 2 * (a + b));

    //№2
    printf("//2 \n");
    printf("Input D: \n");
    scanf_s("%f", &d); // Ввод
    printf("L=%f \n", d*pi); // Вывод

    //№3
    printf("//3 \n");
    printf("SA=%f \n", (a+b)/2); // Вывод

    //№4
    printf("//4 \n");
    printf("sum_kv=%f \n", a*a + b*b); // Вывод
    printf("Rz_kv=%f \n", (a*a)-(b*b));
    printf("Pr_kv=%f \n", a*a*b*b);
    printf("Ch_kv=%f \n", (a*a) / (b*b));

    //№5
    a = abs(a);
    b = abs(b);
    printf("//5 \n");
    printf("sumv=%f \n", a + b);
    printf("Rz=%f \n", (a - b));
    printf("Pr=%f \n", a*b);
    printf("Ch=%f \n", a / b);
}
