.PHONY: build test clean

SOLUTION := $(shell find $(SOURCEDIR) -name '*.sln')
TESTS := $(shell find $(SOURCEDIR) -name '*test*.dll')

build: clean
	xbuild $(SOLUTION)

test: build
	nunit-console $(TESTS)

clean:
	xbuild /target:Clean $(SOLUTION)
	find . -type d -name 'bin' -o -name 'obj' | xargs rm -rvf 
