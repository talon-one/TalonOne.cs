BUILD_DIR=src/TalonOne
VERSION=$(shell grep -om1 -E '^\[assembly: AssemblyVersion\("[0-9\.]+"\)\]$$' $(PWD)/$(BUILD_DIR)/Properties/AssemblyInfo.cs | sed 's/\[assembly: AssemblyVersion("\(.*\)")\]/\1/')

clean:
	rm -f $(PWD)/$(BUILD_DIR)/TalonOne.$(VERSION).nupkg

build: clean
	docker run \
		--rm \
		-v $(PWD):/tmp/talon-client \
		-w "/tmp/talon-client/$(BUILD_DIR)" \
		mono:6 \
		nuget pack -Prop Configuration=Release -IncludeReferencedProjects -properties version=$(VERSION)

push:
	docker run \
		--rm \
		-v $(PWD)/$(BUILD_DIR)/TalonOne.$(VERSION).nupkg:/tmp/talon-client \
		-w "/tmp/talon-client" \
		mono:6 \
		nuget push

publish: build push
