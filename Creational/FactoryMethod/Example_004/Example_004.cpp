#include "PictureDocumentCreator.h";
#include "TextDocumentCreator.h";

using namespace ctor;
using namespace doc;

template<typename T>
void create_and_show() {
    Creator* creator = new T();
    Document* doc = (*creator).create();
    delete creator;

    doc->show();
    delete doc;
}

int main() {
    create_and_show<PictureDocumentCreator>();
    create_and_show<TextDocumentCreator>();

    return 0;
}
