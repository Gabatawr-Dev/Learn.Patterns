#pragma once

#include "IStorage.h"

namespace storage {

    class PostgresStorage : public IStorage {
    public:
        void open() override;
        void execute_query() override;
        void close() override;
    };

}
