#include <iostream>
#include "MysqlStorage.h"
#include "PostgresStorage.h"

using namespace storage;

int main(int argc, char** argv) {
    // argc всегда больше 0
    // argv[0] путь к программе
    for (int i = 0; i < argc; i++)
        std::cout << argv[i] << std::endl;
  
    auto env = argc
        ? Storage::postgres
        : Storage::mysql;

    IStorage* storage;
    switch (env) {
        
        case Storage::mysql: {
            storage = new MysqlStorage();
            break;
        }
        case Storage::postgres: {
            storage = new PostgresStorage();
            break;
        }
        default: return 0;
    }

    storage->open();
    storage->execute_query();
    storage->close();

    delete storage;

    return 0;
}
