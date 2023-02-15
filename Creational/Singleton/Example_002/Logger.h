#pragma once

#include <iostream>

namespace logger {

    enum class Level : int { info, warn };

    class Logger {
    public:
        static Logger& log(const std::string& msg, Level lvl = Level::info);

        Logger(const Logger&) = delete;
        Logger& operator=(const Logger&) = delete;

    private:
        const char* lvl_str[2] = {
            "info: ",
            "warning: "
        };

        std::ostream& os;

        Logger():os{std::cerr}{}
    };

}