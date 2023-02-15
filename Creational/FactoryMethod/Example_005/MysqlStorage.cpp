#include <iostream>
#include "MysqlStorage.h"

using namespace storage;

void MysqlStorage::open() {
    std::cout << "connect to mysql" << std::endl;
}
void MysqlStorage::execute_query() {
    std::cout << "fetch mysql result" << std::endl;
}
void MysqlStorage::close() {
    std::cout << "disconnect from mysql" << std::endl;
}