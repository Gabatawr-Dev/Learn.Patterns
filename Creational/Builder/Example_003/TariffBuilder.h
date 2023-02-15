#pragma once

#include <iostream>
#include <map>
#include "Tariff.h"

namespace tariff {

    class TariffBuilder {
        std::map<double, int> tariff;

    public:
        void add_discount(double subtotal, int discount);
        Tariff build();
    };

}