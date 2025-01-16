BUILD_DIR:=src/TalonOne
VERSION:=$(shell grep -om1 -E '^\[assembly: AssemblyVersion\("[0-9\.]+"\)\]$$' $(PWD)/$(BUILD_DIR)/Properties/AssemblyInfo.cs | sed 's/\[assembly: AssemblyVersion("\(.*\)")\]/\1/')

default: testenv

clean:
	rm -rf $(PWD)/$(BUILD_DIR)/TalonOne.$(VERSION)*.nupkg && \
	rm -rf $(PWD)/$(BUILD_DIR)/TalonOne.$(VERSION).snupkg

pack: clean
ifeq ($(VERSION),)
	@echo "***\033[0;31mERROR:\033[0m NO VERSION COULD BE EXTRACTED. Check out the AssemblyInfo.cs file"
	@exit 1
endif
	docker run \
		--rm \
		-v $(PWD):/tmp/talon-client \
		-w "/tmp/talon-client/$(BUILD_DIR)" \
		mcr.microsoft.com/dotnet/sdk:8.0 \
			dotnet pack TalonOne.csproj \
				-p:PackageVersion=$(VERSION) \
				--output . \
				--configuration Release \
				--include-source

publish: pack
ifeq ($(VERSION),)
	@echo "***\033[0;31mERROR:\033[0m NO VERSION COULD BE EXTRACTED. Check out the AssemblyInfo.cs file"
	@exit 1
endif
ifeq ($(apiKey),)
	@echo "***\033[0;31mERROR:\033[0m NO apiKey WAS NOT PROVIDED."
	@exit 1
endif
	docker run \
		--rm \
		-v $(PWD):/tmp/talon-client \
		-w "/tmp/talon-client/$(BUILD_DIR)" \
		mcr.microsoft.com/dotnet/sdk:8.0 \
			dotnet nuget push TalonOne.$(VERSION).nupkg \
				--api-key $(apiKey) \
				--source https://api.nuget.org/v3/index.json

.PHONY: testenv
testenv:
	docker run \
		--rm -it \
		-v $(PWD):/tmp/talon-client \
		-w /tmp/talon-client \
		mcr.microsoft.com/dotnet/sdk:8.0 \
		/bin/bash
