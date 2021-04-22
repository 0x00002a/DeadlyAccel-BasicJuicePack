echo off
cls
D:\bin\texconv.exe *.png -nologo -y -f BC7_UNORM -pmalpha -if LINEAR
ren *.DDS *.dds
pause