#pragma once

#include "Creator.h"

namespace ctor {

    class TextDocumentCreator : public Creator {
    public:
        Document* create() override;
    };

}