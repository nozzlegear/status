module Tests

open Xunit
open Status
open System

[<Fact>]
let ``Creates InternalServerError from 500`` () =
    let code = fromInt 500

    Assert.Equal(InternalServerError, code)

[<Fact>]
let ``Can get a description`` () =
    let expected = "Internal Server Error"
    let code = InternalServerError

    Assert.Equal(expected, code.Description)
    Assert.Equal(expected, getDescription code)

[<Fact>]
let ``Can get an int from a code`` () =
    let expected = 500
    let code = InternalServerError

    Assert.Equal(expected, code.ToInt())
    Assert.Equal(expected, toInt code)

[<Fact>]
let ``Throws an ArgumentOutOfRangeException`` () =
    let memberMethod () = Code.FromInt(700) |> ignore
    let funcMethod () = fromInt 700 |> ignore

    Assert.Throws<ArgumentOutOfRangeException>(memberMethod) |> ignore
    Assert.Throws<ArgumentOutOfRangeException>(funcMethod) |> ignore