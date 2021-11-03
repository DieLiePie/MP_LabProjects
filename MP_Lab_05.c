
#include <stdlib.h>
#include<stdio.h>

int main() // старт функции
{
    float A, B; // Инициализация переменных

    //1
    printf("#1 \n");
    printf("Input A, B: \n");
    scanf_s("%f", &A); // Ввод
    scanf_s("%f", &B);

    A += B;
    B = A-B;
    A -= B;
    printf("A= %f \n", A);
    printf("B= %f \n", B);
}
