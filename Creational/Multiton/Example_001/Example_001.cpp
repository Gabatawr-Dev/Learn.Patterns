#include <iostream>
#include "Logger.h"

using namespace logger;

int main() {
    Logger::log("started").log("in process");
    Logger::log("connect", Source::web);
    Logger::log("error", Source::db, Level::warn);

    return 0;
}