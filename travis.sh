#!/bin/sh

set -e

cd TalonOne.Tests
dotnet restore
dotnet user-secret add Endpoint "$TALONONE_ENDPOINT"
dotnet user-secret add Email "$TALONONE_EMAIL"
dotnet user-secret add Password "$TALONONE_PASSWORD"
dotnet test