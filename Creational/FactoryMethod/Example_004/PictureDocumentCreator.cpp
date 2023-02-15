#include "PictureDocument.h";
#include "PictureDocumentCreator.h";

using namespace ctor;
using namespace doc;

Document* PictureDocumentCreator::create() {
    return new PictureDocument();
}