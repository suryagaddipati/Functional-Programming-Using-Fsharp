namespace Functional_Programming_Using_Fsharp.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open Functional_Programming_Using_Fsharp.Chapter1
[<TestClass>]
type Chapter1() = 
    [<TestMethod>]
    member this.``1.1``() =
        Assert.AreEqual(8, g 4 )
    [<TestMethod>]
    member this.``1.2``() =
        Assert.AreEqual(5.0, h 3.0 4.0 )
    [<TestMethod>]
    member this.``1.3``() =
        Assert.AreEqual(8, g' 4 )
        Assert.AreEqual(5.0, h' 3.0 4.0 )
    [<TestMethod>]
    member this.``1.4``() =
        Assert.AreEqual(15, f 5 )


