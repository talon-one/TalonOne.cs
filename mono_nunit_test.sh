#!/usr/bin/env bash
#
# Generated by: https://github.com/openapitools/openapi-generator.git
#

# wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
# mozroots --import --sync

echo "[INFO] remove bin/Debug/TalonOne.Test.dll"
rm src/TalonOne.Test/bin/Debug/TalonOne.Test.dll 2> /dev/null

echo "[INFO] remove packages dlls"
rm -rf packages

echo "[INFO] install NUnit runners via NuGet"
# wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
# mozroots --import --sync
nuget install src/TalonOne.Test/packages.config -o packages

echo "[INFO] Install NUnit Console 3.x runners via NuGet"
nuget install NUnit.ConsoleRunner -Version 3.10.0 -OutputDirectory packages

echo "[INFO] Bls pack   uild the solution and run the unit test"
# `xbuild` is about to be deprecated, this was an intentional manual change -- keep it
msbuild -m TalonOne.sln && \
    mono ./packages/NUnit.ConsoleRunner.3.10.0/tools/nunit3-console.exe \
    src/TalonOne.Test/bin/Debug/TalonOne.Test.dll \
    --test=TalonOne.Test.IntegrationApiTests.UpdateCustomerProfileV2Test
