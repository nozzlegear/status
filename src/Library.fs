module Status

    type Code =
        | Continue
        | SwitchingProtocols
        | Processing
        | OK
        | Created
        | Accepted
        | NonAuthoritativeInformation
        | NoContent
        | ResetContent
        | PartialContent
        | MultiStatus
        | AlreadyReported
        | Used
        | MultipleChoices
        | MovedPermanently
        | Found
        | SeeOther
        | NotModified
        | UseProxy
        | TemporaryRedirect
        | PermanentRedirect
        | BadRequest
        | Unauthorized
        | PaymentRequired
        | Forbidden
        | NotFound
        | MethodNotAllowed
        | NotAcceptable
        | ProxyAuthenticationRequired
        | RequestTimeout
        | Conflict
        | Gone
        | LengthRequired
        | PreconditionFailed
        | PayloadTooLarge
        | RequestUriTooLong
        | UnsupportedMediaType
        | RequestedRangeNotSatisfiable
        | ExpectationFailed
        | Teapot
        | MisdirectedRequest
        | UnprocessableEntity
        | Locked
        | FailedDependency
        | UpgradeRequired
        | PreconditionRequired
        | TooManyRequests
        | RequestHeaderFieldsTooLarge
        | ConnectionClosedWithoutResponse
        | UnavailableForLegalReasons
        | ClientClosedRequest
        | InternalServerError
        | NotImplemented
        | BadGateway
        | ServiceUnavailable
        | GatewayTimeout
        | HTTPVersionNotSupported
        | VariantAlsoNegotiates
        | InsufficientStorage
        | LoopDetected
        | NotExtended
        | NetworkAuthenticationRequired
        | NetworkConnectTimeoutError
        with
        member public x.Description =
            match x with
            | Continue -> "Continue"
            | SwitchingProtocols -> "Switching Protocols"
            | Processing -> "Processing"
            | OK -> "OK"
            | Created -> "Created"
            | Accepted -> "Accepted"
            | NonAuthoritativeInformation -> "Non-authoritative Information"
            | NoContent -> "No Content"
            | ResetContent -> "Reset Content"
            | PartialContent -> "Partial Content"
            | MultiStatus -> "Multi-Status"
            | AlreadyReported -> "Already Reported"
            | Used -> "IM Used"
            | MultipleChoices -> "Multiple Choices"
            | MovedPermanently -> "Moved Permanently"
            | Found -> "Found"
            | SeeOther -> "See Other"
            | NotModified -> "Not Modified"
            | UseProxy -> "Use Proxy"
            | TemporaryRedirect -> "Temporary Redirect"
            | PermanentRedirect -> "Permanent Redirect"
            | BadRequest -> "Bad Request"
            | Unauthorized -> "Unauthorized"
            | PaymentRequired -> "Payment Required"
            | Forbidden -> "Forbidden"
            | NotFound -> "Not Found"
            | MethodNotAllowed -> "Method Not Allowed"
            | NotAcceptable -> "Not Acceptable"
            | ProxyAuthenticationRequired -> "Proxy Authentication Required"
            | RequestTimeout -> "Request Timeout"
            | Conflict -> "Conflict"
            | Gone -> "Gone"
            | LengthRequired -> "Length Required"
            | PreconditionFailed -> "Precondition Failed"
            | PayloadTooLarge -> "Payload Too Large"
            | RequestUriTooLong -> "Request-URI Too Long"
            | UnsupportedMediaType -> "Unsupported Media Type"
            | RequestedRangeNotSatisfiable -> "Requested Range Not Satisfiable"
            | ExpectationFailed -> "Expectation Failed"
            | Teapot -> "I'm a teapot"
            | MisdirectedRequest -> "Misdirected Request"
            | UnprocessableEntity -> "Unprocessable Entity"
            | Locked -> "Locked"
            | FailedDependency -> "Failed Dependency"
            | UpgradeRequired -> "Upgrade Required"
            | PreconditionRequired -> "Precondition Required"
            | TooManyRequests -> "Too Many Requests"
            | RequestHeaderFieldsTooLarge -> "Request Header Fields Too Large"
            | ConnectionClosedWithoutResponse -> "Connection Closed Without Response"
            | UnavailableForLegalReasons -> "Unavailable For Legal Reasons"
            | ClientClosedRequest -> "Client Closed Request"
            | InternalServerError -> "Internal Server Error"
            | NotImplemented -> "Not Implemented"
            | BadGateway -> "Bad Gateway"
            | ServiceUnavailable -> "Service Unavailable"
            | GatewayTimeout -> "Gateway Timeout"
            | HTTPVersionNotSupported -> "HTTP Version Not Supported"
            | VariantAlsoNegotiates -> "Variant Also Negotiates"
            | InsufficientStorage -> "Insufficient Storage"
            | LoopDetected -> "Loop Detected"
            | NotExtended -> "Not Extended"
            | NetworkAuthenticationRequired -> "Network Authentication Required"
            | NetworkConnectTimeoutError -> "Network Connect Timeout Error"

        member x.ToInt () =
            match x with
            | Continue -> 100
            | SwitchingProtocols -> 101
            | Processing -> 102
            | OK -> 200
            | Created -> 201
            | Accepted -> 202
            | NonAuthoritativeInformation -> 203
            | NoContent -> 204
            | ResetContent -> 205
            | PartialContent -> 206
            | MultiStatus -> 207
            | AlreadyReported -> 208
            | Used -> 226
            | MultipleChoices -> 300
            | MovedPermanently -> 301
            | Found -> 302
            | SeeOther -> 303
            | NotModified -> 304
            | UseProxy -> 305
            | TemporaryRedirect -> 307
            | PermanentRedirect -> 308
            | BadRequest -> 400
            | Unauthorized -> 401
            | PaymentRequired -> 402
            | Forbidden -> 403
            | NotFound -> 404
            | MethodNotAllowed -> 405
            | NotAcceptable -> 406
            | ProxyAuthenticationRequired -> 407
            | RequestTimeout -> 408
            | Conflict -> 409
            | Gone -> 410
            | LengthRequired -> 411
            | PreconditionFailed -> 412
            | PayloadTooLarge -> 413
            | RequestUriTooLong -> 414
            | UnsupportedMediaType -> 415
            | RequestedRangeNotSatisfiable -> 416
            | ExpectationFailed -> 417
            | Teapot -> 418
            | MisdirectedRequest -> 421
            | UnprocessableEntity -> 422
            | Locked -> 423
            | FailedDependency -> 424
            | UpgradeRequired -> 426
            | PreconditionRequired -> 428
            | TooManyRequests -> 429
            | RequestHeaderFieldsTooLarge -> 431
            | ConnectionClosedWithoutResponse -> 444
            | UnavailableForLegalReasons -> 451
            | ClientClosedRequest -> 499
            | InternalServerError -> 500
            | NotImplemented -> 501
            | BadGateway -> 502
            | ServiceUnavailable -> 503
            | GatewayTimeout -> 504
            | HTTPVersionNotSupported -> 505
            | VariantAlsoNegotiates -> 506
            | InsufficientStorage -> 507
            | LoopDetected -> 508
            | NotExtended -> 510
            | NetworkAuthenticationRequired -> 511
            | NetworkConnectTimeoutError -> 599

        static member FromInt i =
            // Could have used a function match here instead of actual match, but that makes the method weird in C#. 
            // e.g. If this was a function you'd have to do `StatusCode.FromInt.Invoke(500)` in C#, rather than `FromInt(500)`. 
            match i with
            | 100 -> Continue
            | 101 -> SwitchingProtocols
            | 102 -> Processing
            | 200 -> OK
            | 201 -> Created
            | 202 -> Accepted
            | 203 -> NonAuthoritativeInformation
            | 204 -> NoContent
            | 205 -> ResetContent
            | 206 -> PartialContent
            | 207 -> MultiStatus
            | 208 -> AlreadyReported
            | 226 -> Used
            | 300 -> MultipleChoices
            | 301 -> MovedPermanently
            | 302 -> Found
            | 303 -> SeeOther
            | 304 -> NotModified
            | 305 -> UseProxy
            | 307 -> TemporaryRedirect
            | 308 -> PermanentRedirect
            | 400 -> BadRequest
            | 401 -> Unauthorized
            | 402 -> PaymentRequired
            | 403 -> Forbidden
            | 404 -> NotFound
            | 405 -> MethodNotAllowed
            | 406 -> NotAcceptable
            | 407 -> ProxyAuthenticationRequired
            | 408 -> RequestTimeout
            | 409 -> Conflict
            | 410 -> Gone
            | 411 -> LengthRequired
            | 412 -> PreconditionFailed
            | 413 -> PayloadTooLarge
            | 414 -> RequestUriTooLong
            | 415 -> UnsupportedMediaType
            | 416 -> RequestedRangeNotSatisfiable
            | 417 -> ExpectationFailed
            | 418 -> Teapot
            | 421 -> MisdirectedRequest
            | 422 -> UnprocessableEntity
            | 423 -> Locked
            | 424 -> FailedDependency
            | 426 -> UpgradeRequired
            | 428 -> PreconditionRequired
            | 429 -> TooManyRequests
            | 431 -> RequestHeaderFieldsTooLarge
            | 444 -> ConnectionClosedWithoutResponse
            | 451 -> UnavailableForLegalReasons
            | 499 -> ClientClosedRequest
            | 500 -> InternalServerError
            | 501 -> NotImplemented
            | 502 -> BadGateway
            | 503 -> ServiceUnavailable
            | 504 -> GatewayTimeout
            | 505 -> HTTPVersionNotSupported
            | 506 -> VariantAlsoNegotiates
            | 507 -> InsufficientStorage
            | 508 -> LoopDetected
            | 510 -> NotExtended
            | 511 -> NetworkAuthenticationRequired
            | 599 -> NetworkConnectTimeoutError
            | i -> raise <| System.ArgumentOutOfRangeException (sprintf "%i is not a valid status code." i)
            
    let fromInt = Code.FromInt

    let toInt (statusCode: Code) = statusCode.ToInt ()

    let getDescription (statusCode: Code) = statusCode.Description
