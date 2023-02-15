#include "Logger.h"

using namespace logger;

Logger& Logger::log(const std::string& msg, Level lvl) {

    static Logger instance;
    instance.os << instance.lvl_str[int(lvl)] << msg << std::endl;

    return instance;
}