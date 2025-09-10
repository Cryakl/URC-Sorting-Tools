:: A little utility to batch compress folders into 7Z archives.
:: You may need to change this for your use case.

@echo off
setlocal

set "Source_Dir=%cd%"

for /D %%F in ("%Source_Dir%\*") do (

  :: You might need to change this path depending on your 7-Zip installation.
    "C:\Program Files\7-Zip\7z.exe" a -t7z "%%F.7z" "%%F\*" -mx9 -p"infected"

)

endlocal

echo Batch compression completed.
pause
