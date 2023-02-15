#pragma once

#include "IStorage.h"

namespace storage {

    class MysqlStorage : public IStorage {
    public:
        void open() override;
        void execute_query() override;
        void close() override;
    };

}
