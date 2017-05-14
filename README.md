# sendmouse
command-line tool to emulate a mouse click on windows

## Release
[![Latest Release](https://img.shields.io/github/release/myfreeer/sendmouse.svg)](https://github.com/myfreeer/sendmouse/releases/latest)
[![Download](https://img.shields.io/github/downloads/myfreeer/sendmouse/total.svg)](https://github.com/myfreeer/sendmouse/releases)

## Usage
* run `sendmouse` with/without arguments and get current mouse position in console.
* run `sendmouse x y` (x y should be integer) to move mouse cursor to point (x,y) and emulate a left click.

## Build
[Releases](https://github.com/myfreeer/numlock/releases) are built with [tcc](https://bellard.org/tcc/) using command `tcc sendmouse.c -luser32`,
it can also be built with other compliers such as gcc.
