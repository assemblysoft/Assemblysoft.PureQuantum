echo started register dll

if "%~1"=="" goto blank

echo "%1"

echo about to register dll
call regsvr32 "%1"
goto done

:blank
echo no argument supplied

:done
echo finished registering dll