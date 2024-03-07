enviroment requirements

//in case of "session invalid, uninstall:
adb uninstall io.appium.uiautomator2.server.test
adb uninstall io.appium.uiautomator2.server

//appium server
1st of all, have node.js to use npm

//install appium core
npm i -g appium 

//if wish to update
npm update -g appium

//android sdk with android studio
install: Android SDK Platform-Tools and Java JDK

//Set up the ANDROID_HOME environment variable to point to the directory where the Android SDK is installed
same for JAVA_HOME, locate the jdk dir, and point it there.

//add jdk bin to path, and platform tools directory too

//install the driver:
appium driver install uiautomator2
//apium server ready

//download specflow for visual studio:
https://marketplace.visualstudio.com/_apis/public/gallery/publishers/TechTalkSpecFlowTeam/vsextensions/SpecFlowForVisualStudio2022/2022.1.91.26832/vspackage

//.net appium tst example:
https://appium.io/docs/en/latest/quickstart/test-dotnet/
//expression documentation:
https://docs.specflow.org/projects/specflow/en/latest/Bindings/Cucumber-Expressions.html

//for now, thats it, you can now begin
