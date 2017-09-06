# Agile Project Manager
### Scrum Focused Project Hub

#####  _August 31st, 2017_

##### By _Jun Fritz_

## Description
Using an Agile approach to group projects is very interesting to me, so I've decided to create a project manager of my own.  Built with C# and ASP.NET Core, imagine yourself as the Scrum Master of any group project and create, view, edit, and delete all the essentials of a basic Scrum based project.  

## Specifications
 |Behavior|
 |---|
 | User create, read, update, delete a project |
 | User has control of deadlines, team members, tools, user stories, updates, and sprints of each project |
 | User can create, read, update, delete a sprint |
 | User can assign tasks and mark tasks complete|
 | User gets updated progress via progress bars|
 | User can create, read, update, delete individual tools in group toolbox |


![projectdetail - copy](https://user-images.githubusercontent.com/25647710/30091737-0f1f8aec-9270-11e7-950b-109209a767b3.PNG)

![projectforms](https://user-images.githubusercontent.com/25647710/30091738-0f1fbaa8-9270-11e7-8bd6-2cf650941994.PNG)

![usertaskbar - copy](https://user-images.githubusercontent.com/25647710/30091736-0f1fa522-9270-11e7-8d69-cf6446c8084a.PNG)

![indiesprint - copy](https://user-images.githubusercontent.com/25647710/30091735-0f1debe2-9270-11e7-8bf9-b67823e439a9.PNG)

![toolbox - copy](https://user-images.githubusercontent.com/25647710/30091739-0f25c4fc-9270-11e7-9cca-555cba0d9c8d.PNG)

## Setup/Installation Requirements

#### _**Replicating/Editing this Project**_

* You will need Microsoft Visual Studio 2015 in order to replicate or edit this project using these instructions.
* Click the "download or clone" button in this repository and copy the link.
* In your computers terminal, navigate to the desktop and enter "git clone" followed by pasting the link on your clipboard.
* Open up Microsoft Visual Studio 2015 and select File> Open> Project/Solution.
* Navigate to your desktop and double click on your project folder.
* Then double click on the "Microsoft Visual Studio Solution" type item (it will share the same name as the project as well as a VS icon).
* One the file has been opened by Visual Studio, bring back your command prompt and navigate to the root path of this project.
* If using PowerShell, your path to navigate will look something like this: 

         C:\Users\epicodus\documents\Visual Studio 2015\projects\Scrum\src\Scrum>
      
* Once you're in the project, run this command:

         dotnet ef database update
      
* The command above will create the database required for this project using the class information in the "Models" folder.
* Viewing and editing all CRUD (create, read, update, delete) functionality can be done in the "Controllers" folder.
* Viewing and editing all styling and images can be found in the "CSS" and "IMG" folders located within the "wwwroot" folder.
* Classes for objects and the one to many relationship used in this project can be found in the "Models" folder.
* All HTML is located in the Views folder and each separate subfolder in it.
* In order to run tests, rightclick on SonOfCodTests and choose "Build" then open up Test>Windows>TestExplorer and choose "Run All".

## Known bugs

  * No Known Bugs

## Support and contact details

 Contact jun.fritz@gmail.com with any comments, concerns, or questions.

## Technologies Used

 _HTML, CSS, ASP.NET Core, Microsoft Visual Studio 2015, C#, FontAwesome, BootStrap, UIKit_

### License

 MIT

 Copyright (c) 2017 **_Jun Fritz_**
 
 

### PRIORITY
* add full crud for sprints/tasks/userstories/tools/tasks
* improve app flow
* style individual tasks page/ add more detail to model (estimated time, difficulty level)
* finish project detail page
* style sprint detail page
* add github api to log in to github/gain access to project repository/commit and make changes with github (further exploration)
* pie chart???????
* reduce amount of buttons/ add user friendly icons

#### Completed:
* create project
* create sprint
* create user account
* add updates to projects
* add tasks to projects
* add tools to toolbox
* add tools to projects
* mark tasks complete
* full crud for "Tasks" objects
* progress bar for individual sprint to display task completion percentage
* progress bar for individual project to display sprint length percentage


#### To Do
* update/task completion timeline diagram
* full CRUD for updates, tools
* add roles to project (Product Owner, Scrum Master, Team Member)
* style with scss
* improve app flow
* pie chart for incompleted tasks to display type of task
* add MUI 
* MARP presentation with screenshots/videos
