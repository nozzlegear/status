# status
A lightweight .NET package for working with HTTP status codes and status code descriptions.

## Installation

Install with dotnet cli:

```sh
dotnet add package status
```

Install with Paket:

```sh
paket add status
```

## Usage

This small package was built with both C# and F# in mind. It should feel right at home in either language.

```cs
// C#
// Because the package was built as an F# module, there's no using statement. `Status` is just available.

var code = Status.Code.InternalServerError;
int statusCodeAsInt = code.ToInt(); // 500
string description = code.Description; // Internal Server Error

// Or, create a code from an int
var code = Status.Code.FromInt(500);
```

```fs
// F#
open Status

let code = InternalServerError

// Match on the code
let isInternalServerError = function
| InternalServerError -> true
| _ -> false

let description =
    fromInt 500
    |> getDescription
    |> printfn "%s" // Prints "Internal Server Error"

let statusCodeAsInt =
    InternalServerError
    |> toInt
    |> printfn "%i" // Prints 500
```