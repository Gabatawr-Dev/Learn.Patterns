#include "TariffBuilder.h"

using namespace tariff;

void TariffBuilder::add_discount(double subtotal, int discount) {
    tariff[subtotal] = discount;
}

Tariff TariffBuilder::build() {
    std::vector<double> amount;
    std::vector<int> discount;
    for (const auto& t : tariff) {
        amount.push_back(t.first);
        discount.push_back(t.second);
    }

    return Tariff(amount, discount);
}