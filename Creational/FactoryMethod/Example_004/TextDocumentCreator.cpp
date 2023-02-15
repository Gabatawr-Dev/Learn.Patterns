#include "TextDocument.h";
#include "TextDocumentCreator.h";

using namespace ctor;
using namespace doc;

Document* TextDocumentCreator::create() {
    return new TextDocument();
}