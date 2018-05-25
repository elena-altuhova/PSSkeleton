@echo off
echo enter the parameter
echo %1
set v1=%1
echo Enter the directory of the solution 
%v1%\packages\NUnit.ConsoleRunner.3.8.0\tools\nunit3-console.exe --labels=All --out=%v1%\TestResult.txt "--result=%v1%\TestResult.xml;format=nunit2" %v1%\PSSkeleton\bin\Debug\PSSkeleton.dll
%v1%\packages\SpecFlow.2.3.2\tools\specflow.exe nunitexecutionreport %v1%\TestResult.xml  /out:MyResult.html
echo Created file myResult.html

 start myResult.html