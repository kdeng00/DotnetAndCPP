#include "Arithmetic.h"


extern "C" {
int add(int, int);


int add(int a, int b) {
    Arithmetic matics;

    return matics.add(a, b);
}
}
