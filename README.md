### NoteTakingApplication
Develop an API for a note-taking application that allows users to create, edit, and organize their
notes. Your submission should provide endpoints that support the following functionalities:
1.CRUD (Create, Read, Update, Delete) Notes
2.Search Functionality
3.Ability to Categorize Notes

#### STEPS ON HOW TO RUN THE PROJECT USING VISUAL STUDIO:
1. Clone the repository containing this project to your local computer
2. Open Visual Studio on your computer
3. Open the solution file of the API project in visual studio(NoteTakingApplication.sln). To do this, select "File" from the menu bar and choose "Open">"Project/Solution". Naviagte to the folder that contains the solution file and select it i.e(NoteTakingApplication.sln), then click "Open"
4. Restore Dependencies required by the project. Open the Solution Explorer menu which can be found in View>Solution Explorer.
5. Right-click on the project name in the Solution Explorer. From the context menu, select "Restore NuGet Packages". This option will restore the packages specified in the project's .csproj file. Visual Studio will begin the package restoration process and retrieve the required packages from the NuGet package sources.
6. Afterwards, Right click on the solution in the solution explorer and select "Build Solution". Alternatively, use Ctrl + Shift + B keyboard shortcut. This will compile the code and generate the necessary build assets.
7. Run the API. To do this click on the "Start without debugging" button in the toolbar(it is usually a green arrow) or press the F5 key. This will enable Visual Studio to build and launch the project.
8. Once the API is running, you will be directed to a Swagger UI where you can test the various API endpoints, or you can also make use of Postman or a web broswer. You can make requests to the API's URL to interact with its endpoints
 



#### STEPS ON HOW TO RUN THE PROJECT USING VISUAL STUDIO CODE:
1. Clone the repository containing this project to your local computer
2. Open Visual Studio Code on your computer
3. Open the folder containing the cloned repository in Visual Studio Code. You can do this by selection "File" from the menu bar and choosing "Open Folder". Navigate to the folder that contains the project and click "Open"
4.Install the necessary extensions in Visual Studio Code for working with .NET projects. The extensions are: C# by Microsoft and C# Extensions by JosKreativ

5. Restore Dependencies required for this project. Open the terminal in Visual Studio Code. In the terminal, navigate to the root folder of the project(where the '.csproj' file is located). Run the following command to restore the dependencies: 
	"dotnet restore". This command will download and restore the required NuGet packages for the project
6. Build the project. To do this, use the following command in the terminal:
	"dotnet build". This command will compile the code and generate the necessary build assests
7. To run the API project, use the following command in the terminal:
	"dotnet run" . This command will start the API and make it available at the specified address( e.g "http://localhost:5128")
8. Test the API. Once the API is running, you can test its endpoints using a tool like Postman or you can open a web browser and navigate to the API's URL to see if it responding correctly.

The link to the Postman collection that contains the links for the endpoints:
