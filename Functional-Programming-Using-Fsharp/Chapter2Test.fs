namespace Functional_Programming_Using_Fsharp.Tests

open Microsoft.VisualStudio.TestTools.UnitTesting
open Functional_Programming_Using_Fsharp.Chapter2
[<TestClass>]
type Chapter2() = 
    [<TestMethod>]
    member this.``2.1``() =
        Assert.IsTrue(f(24))
        Assert.IsTrue(f(27))
        Assert.IsFalse(f(29))
        Assert.IsFalse(f(30))
    [<TestMethod>]
    member this.``2.2``() =
        Assert.AreEqual("sssss",pow("s",5))
    [<TestMethod>]
    member this.``2.3``() =
        Assert.IsTrue(isIthChar("meow",2,'o'))
        Assert.IsFalse(isIthChar("meow",3,'o'))
