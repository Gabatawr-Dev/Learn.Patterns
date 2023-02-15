#pragma once

namespace doc {

    class Document {
    public:
        virtual void show() = 0;
        virtual ~Document() = default;
    };

}