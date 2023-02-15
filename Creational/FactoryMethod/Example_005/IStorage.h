#pragma once

namespace storage {

    enum class Storage { mysql, postgres };

    class IStorage {
    public:
        virtual void open() = 0;
        virtual void execute_query() = 0;
        virtual void close() = 0;

        virtual ~IStorage() = default;
    };

}

