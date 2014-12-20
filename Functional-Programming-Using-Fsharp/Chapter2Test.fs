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
    [<TestMethod>]
    member this.``2.4``() =
        Assert.AreEqual(3,occFromIth("meoowo",2,'o'))
        Assert.AreEqual(1,occFromIth("meoowo",5,'o'))
        Assert.AreEqual(0,occFromIth("meoowo",7,'o'))
    [<TestMethod>]
    member this.``2.5``() =
        Assert.AreEqual(3,occInString("meoowo",'o'))
    [<TestMethod>]
    member this.``2.6``() =
        Assert.IsTrue(notDivisible(2,5))
        Assert.IsFalse(notDivisible(3,9))
