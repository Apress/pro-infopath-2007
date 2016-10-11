
:: Before running this file, sign the assembly in Project properties
::
:: To customize this file, find and replace
:: a) "myFeature" with your own feature name
:: b) "[IP_FORM_FILENAME]" with InfoPath form that needs to be uploaded (add additional lines for multiple forms)
:: b) "feature.xml" with the name of your feature.xml file
:: c) "workflow.xml" with the name of your workflow.xml file
:: d) "http://localhost" with the name of the site you wish to publish to

echo Copying the feature...

rd /s /q "%CommonProgramFiles%\Microsoft Shared\web server extensions\12\TEMPLATE\FEATURES\DemoSharePointWorkflow"
mkdir "%CommonProgramFiles%\Microsoft Shared\web server extensions\12\TEMPLATE\FEATURES\DemoSharePointWorkflow"

copy /Y feature.xml  "%CommonProgramFiles%\Microsoft Shared\web server extensions\12\TEMPLATE\FEATURES\DemoSharePointWorkflow\"
copy /Y workflow.xml "%CommonProgramFiles%\Microsoft Shared\web server extensions\12\TEMPLATE\FEATURES\DemoSharePointWorkflow\"
xcopy /s /Y *.xsn "%programfiles%\Common Files\Microsoft Shared\web server extensions\12\TEMPLATE\FEATURES\DemoSharePointWorkflow\"



echo Adding assemblies to the GAC...

"%programfiles%\Microsoft Visual Studio 8\SDK\v2.0\Bin\gacutil.exe" -uf DemoSharePointWorkflow
"%programfiles%\Microsoft Visual Studio 8\SDK\v2.0\Bin\gacutil.exe" -if bin\Debug\DemoSharePointWorkflow.dll


echo Verifying InfoPath Forms...

::Note: Verify InfoPath forms; copy line for each form
"%programfiles%\common files\microsoft shared\web server extensions\12\bin\stsadm" -o verifyformtemplate -filename ExpenseStatusForm.xsn
"%programfiles%\common files\microsoft shared\web server extensions\12\bin\stsadm" -o verifyformtemplate -filename ReviewExpenseForm.xsn


echo Activating the feature...

pushd %programfiles%\common files\microsoft shared\web server extensions\12\bin

::Note: Uncomment these lines if you've modified your deployment xml files or IP forms 
::stsadm -o deactivatefeature -filename DemoSharePointWorkflow\feature.xml -url http://localhost
::stsadm -o uninstallfeature -filename DemoSharePointWorkflow\feature.xml

stsadm -o installfeature -filename DemoSharePointWorkflow\feature.xml -force
stsadm -o activatefeature -filename DemoSharePointWorkflow\feature.xml -url http://localhost

echo Doing an iisreset...

popd
iisreset
