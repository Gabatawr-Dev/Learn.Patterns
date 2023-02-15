#pragma once

#include "Document.h";

using namespace doc;

namespace ctor {

    class Creator {
    public:
        virtual Document* create() = 0;
        virtual ~Creator() = default;
    };

}