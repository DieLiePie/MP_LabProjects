
#include <stdlib.h>
#include<stdio.h>

int main() // старт функции
{
    float A, B, C, A1, B1, C1, y, x; // »нициализаци€ переменных

    //1
    printf("#1 \n");
    printf("Input A, B: \n");
    scanf_s("%f", &A); // ¬вод
    scanf_s("%f", &B);

    A += B;
    B = A-B;
    A -= B;
    printf("A= %f \n", A);
    printf("B= %f \n", B);

    //2
    printf("\n");
    printf("#2 \n");
    printf("Input A, B, C: \n");
    scanf_s("%f", &A1); // ¬вод
    scanf_s("%f", &B1);
    scanf_s("%f", &C1);

    y = B1;
    B1 = A1;
    A1 = C1;
    C1 = y;

    printf("A= %f \n", A1);
    printf("B= %f \n", B1);
    printf("C= %f \n", C1);

    //3
    printf("\n");
    printf("#3 \n");
    printf("Input A, B, C: \n");
    scanf_s("%f", &A1); // ¬вод
    scanf_s("%f", &B1);
    scanf_s("%f", &C1);

    y = A1;
    A1 = B1;
    B1 = C1;
    C1 = y;

    printf("A= %f \n", A1);
    printf("B= %f \n", B1);
    printf("C= %f \n", C1);

    //4
    printf("\n");
    printf("#4 \n");
    printf("Input x: \n");
    scanf_s("%f", &x);

    printf("y= %f \n", 3*pow(x, 6)-6*x*x-7);

    //5
    printf("\n");
    printf("#5 \n");
    printf("Input x: \n");
    scanf_s("%f", &x);

    printf("y= %f \n", 4*pow(x-3, 6)-7*pow(x-3, 3)+2);

    //6
    printf("\n");
    printf("#6 \n");
    printf("Input A: \n");
    scanf_s("%f", &A);
    B = A*A;
    B = B*B;
    B = B*B;
    printf("%f \n", B);

    //7
    printf("\n");
    printf("#7 \n");
    printf("Input A: \n");
    scanf_s("%f", &A);
    B = A*A;
    C = B*A;
    B = C;
    C = C*C;
    C = C*C;
    C = C*B;
    printf("%f \n", C);
}
