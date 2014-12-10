namespace Functional_Programming_Using_Fsharp.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open Functional_Programming_Using_Fsharp.Chapter1
[<TestClass>]
type One_1() = 
    [<TestMethod>]
    member this.``Adds 4``() =
        Assert.AreEqual(8, g 4 )


