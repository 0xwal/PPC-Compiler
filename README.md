# PPC-Compiler
I created this app long time ago (last 2015) using some of SN resources to make it easy for developing ppc projects.
# How to use:
just build the app and open the .exe then start writing your ppc code :) thats it. GUI explains more :)

```
li %r3, 0x01
li %r4, 0xCC
bla 0x400414
cmpwi %r3, 0x00
beq  0x1C
bla 0x424218
lis %r12, 0x1005
lbz %r4, 0x0(%r12)
xori %r4, %r4, 0x01
stb %r4, 0x00(%r12)
bla 0x3B4280
```
<p align="center">
![alt text](https://raw.githubusercontent.com/BISOON/PPC-Compiler/master/PPC-Compiler.PNG)
</p>
<p align="center">
  <b>Some Links:</b><br>
  <a href="#">Link 1</a> |
  <a href="#">Link 2</a> |
  <a href="#">Link 3</a>
  <br><br>
  <img src="http://s.4cdn.org/image/title/105.gif">
</p>
