# WindowsServiceWrapper
Start and kill a specific executable as Windows Service

## How to
1. In Service1.cs on line 16: ```private readonly string m_executablePath = @"PUT_FULL_PATH_HERE";``` hard code the path of the executable.
2. In Command Prompt as Administrator run ```sc.exe create "SERVICE_NAME" binPath="FULL_PATH_TO_WindowsServiceWrapper.exe"```.

> You can delete the service with ```sc.exe delete "SERVICE_NAME"```.
