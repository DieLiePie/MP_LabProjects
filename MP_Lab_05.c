
#include <stdlib.h>
#include<stdio.h>

int main() // старт функции
{
    float x1, y1, x2, y2, A, B, C, A1, B1, C1, AC, BC, length, width; // »нициализаци€ переменных
    float x3, y3, x4, y4, x5, y5, X, Y, Z, p;

    //¬вод
    printf("#1 \n");
    printf("Input x1, y1: \n");
    scanf_s("%f", &x1); // ¬вод
    scanf_s("%f", &y1);

    printf("Input x2, y2: \n");
    scanf_s("%f", &x2); // ¬вод
    scanf_s("%f", &y2);

    //1
    printf("Length: %f \n", pow(pow((x2-x1),2)+pow((y2-y1),2), 0.5));

    //2
    printf("\n");
    printf("#2 \n");
    printf("Input A, B, C: \n");
    scanf_s("%f", &A);
    scanf_s("%f", &B);
    scanf_s("%f", &C);

    AC = fabs(A-C);
    BC = fabs(B-C);
    printf("AC: %f \n", AC);
    printf("BC: %f \n", BC);
    printf("AC+BC: %f \n", AC+BC);

    //3
    printf("\n");
    printf("#3 \n");
    printf("Input A1, B1, C1: \n");
    scanf_s("%f", &A);
    scanf_s("%f", &B);
    scanf_s("%f", &C);
    AC = fabs(A-C);
    BC = fabs(B-C);
    printf("AC*BC: %f \n", AC*BC);

    //4
    printf("\n");
    printf("#4 \n");
    printf("I used inputs from first exercise! \n"); // !!!
    width = fabs(x2-x1);
    length = fabs(y2-y1);
    printf("P = %f \n", (width+length)*2);
    printf("S = %f \n", width*length);

    //5
    printf("\n");
    printf("#5 \n");

    printf("Input x1, y1: \n");
    scanf_s("%f", &x3);
    scanf_s("%f", &y3);

    printf("Input x2, y2: \n");
    scanf_s("%f", &x4);
    scanf_s("%f", &y4);

    printf("Input x3, y3: \n");
    scanf_s("%f", &x5);
    scanf_s("%f", &y5);

    X = pow(pow((x4-x3),2)+pow((y4-y3),2), 0.5);
    Y = pow(pow((x5-x3),2)+pow((y5-y3),2), 0.5);
    Z = pow(pow((x5-x4),2)+pow((y5-y4),2), 0.5);
    p = (X+Y+Z)/2;
    printf("P = %f \n", X+Y+Z);
    printf("S = %f \n", pow(p*(p-X)*(p-Y)*(p-Z), 0.5));
}
