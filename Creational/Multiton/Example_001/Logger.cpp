#include "Logger.h"

using namespace logger;

Logger& Logger::log(const std::string& msg, Source src, Level lvl) {

    static std::map<Source, Logger> pool;
    auto i = pool.find(src);

    if (i == pool.end()) {
        bool b;
        std::tie(i, b) = pool
            .emplace(std::make_pair(src, Logger(src)));
    }

    auto& instance = i->second;
    instance.os << instance.src_str[int(src)] << instance.lvl_str[int(lvl)]
        << msg << std::endl;

    return instance;
}