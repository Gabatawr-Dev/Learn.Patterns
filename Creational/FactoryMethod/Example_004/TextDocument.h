#pragma once

#include "Document.h";

namespace doc {

    class TextDocument : public Document {
    public:
        void show() override;
    };

}