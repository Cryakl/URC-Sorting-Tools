:: A little utility to create folders with the same name of 7Z's and then move them inside.
:: This is incredibly niche and you probably will never need to use this.

@echo off
setlocal enabledelayedexpansion

for %%F in (*.7z) do (
    set "folderName=%%~nF"
    
    if not exist "!folderName!" mkdir "!folderName!"
    
    move "%%F" "!folderName!\"
)

:: Optionally delete the batch file itself after.
:: Del Move7ZsUtility.bat