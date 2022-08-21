module Utils

module NodeGlobals = Fable.Import.Node.Globals
module Node = Fable.Import.Node.Exports

/// Resolves a path using the location of the target JS file
/// Note the function is inline so `__dirname` will belong to the calling file
let inline resolve (path: string) =
    Node.path.resolve(NodeGlobals.__dirname, path)
