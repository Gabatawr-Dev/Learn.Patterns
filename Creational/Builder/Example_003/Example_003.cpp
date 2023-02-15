#include <iostream>
#include "TariffBuilder.h"

using namespace tariff;

int main() {
    auto builder = TariffBuilder();

    builder.add_discount(111, 11);
    builder.add_discount(333, 33);
    builder.add_discount(222, 22);

    auto tariff = builder.build();
    tariff.apply();

    return 0;
}
