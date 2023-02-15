#pragma once

#include <iostream>
#include <map>

namespace logger {

    enum class Source : int { app, db, web };
    enum class Level : int { info, warn };

    class Logger {
    public:
        static Logger& log(const std::string& msg, Source src = Source::app, Level lvl = Level::info);

        Logger& operator=(const Logger&) = delete;
        
    private:
        const char* src_str[3] = {
            "app_",
            "database_",
            "web_"
        };

        const char* lvl_str[2] = {
            "info: ",
            "warning: "
        };

        Source s;
        std::ostream& os;

        explicit Logger(Source src):s{src},os{std::cerr}{}
    };

}