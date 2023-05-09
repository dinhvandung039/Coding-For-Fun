/// Chain Of Responsiility is a behavioral design pattern that lets you pass request a chain of handlers.
/// Upon receive request, vilidate the request either to process or to pass it to next handler of the chain.
/// Complexity: 2
/// Popularity: 2
/// 

// => decoupling event message request from how it is handled depending on the context
var ide = new IDE(null);
var editor = new CodeEditor(ide);
var codeSelection = new CodeSelection(editor);

codeSelection.HandleKey("Ctrl + F");
codeSelection.HandleKey("Alt + F4");
