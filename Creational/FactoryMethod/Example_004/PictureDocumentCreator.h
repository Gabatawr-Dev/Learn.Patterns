#pragma once

#include "Creator.h"

namespace ctor {

    class PictureDocumentCreator : public Creator {
    public:
        Document* create() override;
    };

}