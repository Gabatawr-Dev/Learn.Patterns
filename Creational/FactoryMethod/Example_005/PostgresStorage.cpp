#include <iostream>
#include "PostgresStorage.h"

using namespace storage;

void PostgresStorage::open() {
    std::cout << "connect to postgres" << std::endl;
}
void PostgresStorage::execute_query() {
    std::cout << "fetch postgres result" << std::endl;
}
void PostgresStorage::close() {
    std::cout << "disconnect from postgres" << std::endl;
}