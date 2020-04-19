#!/usr/bin/env bash
#
# Generated by: https://github.com/openapitools/openapi-generator.git
#

echo "[INFO] remove bin/Debug/TalonOne.Test.dll"
rm src/TalonOne.Test/bin/Debug/TalonOne.Test.dll 2> /dev/null

echo "[INFO] install NUnit runners via NuGet"
nuget install src/TalonOne.Test/packages.config -o packages

echo "[INFO] Install NUnit Console 3.x runners via NuGet"
nuget install NUnit.ConsoleRunner -Version 3.10.0 -o packages

echo "[INFO] Build the solution and run the unit test"
# `xbuild` is about to be deprecated, this was an intentioanl maunal change -- keep it
msbuild TalonOne.sln && \
    mono ./packages/NUnit.ConsoleRunner.3.10.0/tools/nunit3-console.exe src/TalonOne.Test/bin/Debug/TalonOne.Test.dll
