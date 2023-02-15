#include <vector>
#include <cassert>

#pragma once

namespace tariff {

    class Tariff {
        const std::vector<double> amount;
        const std::vector<int> discount;

    public:
        Tariff(std::vector<double> amount, std::vector<int> discount);
        void apply();
    };

}