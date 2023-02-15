#include <iostream>
#include "Tariff.h"

using namespace tariff;

Tariff::Tariff(std::vector<double> amount, std::vector<int> discount)
: amount(std::move(amount)), discount(std::move(discount)) {
    assert(amount.size() == discount.size());
}

void Tariff::apply() {
    std::cout << "tariff is:" << std::endl;
    for (auto i = 0; i < amount.size(); ++i) {
        std::cout << "after " << amount[i] << " USD apply " << discount[i] << "%" << std::endl;
    }
}