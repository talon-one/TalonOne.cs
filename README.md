# Talon.One C# SDK

[Talon.One][0] enables marketers to create coupon, discount, loyalty, and referral marketing campaigns of virtually unlimited power and flexibility. This library is a provides a `TalonOne` namespace and `TalonOne.Client` class for interacting with the Talon.One API.

[0]: https://talon.one

## Install

Install the package via the NuGet package manager console:

```
PM> Install-Package TalonOne
```

## Usage

Right now the best example for getting started is in [this test fixture](TalonOne.Tests/LiveTestFixture.cs)

## Running the tests

The tests rely on some secrets being defined for setting the Talon.One endpoint, email, and password.
`TalonOne.Client` itself does not rely on having an email and password (you can supply a bearer
token for example), but this tests the ability to login/acquire a new bearer token.

To set up your secrets after cloning the project:

```
cd TalonOne.Tests
dotnet restore
dotnet user-secrets add Endpoint https://mycompany.talon.one/
dotnet user-secrets add Email myemail@mycompany.com
dotnet user-secrets add Password 5uP3r53cr3t
```

After this, running `dotnet test` will create a new application and perform a couple of requests before deleting it.

## License

```
MIT License

Copyright (c) 2017 Talon.One GmbH

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```