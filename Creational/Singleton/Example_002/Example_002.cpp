#include <iostream>
#include "Logger.h"

using namespace logger;

int main() {
    Logger::log("started").log("in process");
    Logger::log("error", Level::warn);

    return 0;
}
