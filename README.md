# EnterpriseSystem


Project Case Study

Enterprise Systems Assessment Guide

This project is the main assessment of this subject. It addresses the following objectives from the subject outline. This assignment will contribute to your ability to:

• Understand the .NET framework architecture;

• Understand the mechanisms and techniques for the deployment and configuration of.NET applications;

• Be able to utilize the .NET libraries, including ADO.NET, ASP.NET and other relevant classes;

• Have practical experience of how to write programs in the .NET environment by using Enterprise System concept.

You are required to develop .NET application. All work is to be completed individually. 


Scenario

AIT campus just setup new media library for current and future student in AIT Ultimo campus. Currently, AIT’s librarian uses a normal worksheet for control and record student activities, borrow, return and reserve DVD and Blu-ray Disc.
AIT’s librarian want to move to a IT based system where students can register their details online, and librarian/staff can then search through these registrations to find students who match the requested criteria.

User Requirements Summary

The requirements for the new system are as follows:

• The user interface for respondents and staff should be Win based application

• Student/Staff/Manager should be authenticated with username and password

• Once logged in, staff/manager can:

o Maintain (Add, Modify, Delete) master data including Media, Genre, Director and Languages

o View a list of all student activities

o The staff member should be able to enter as many or as few search criteria as
they want, and after clicking search should see a grid below their search criteria containing a list of all matching records, ordered in ascending order by date.

o Modify the details of an existing activity (if student asks to advise a change of registered detail such as password, email address etc.)

• Once logged in, student can:

o Search, borrow and reserve a book

o Modify own detail such as password, email address etc. o List own past activities

• Security, password, requirement

o Minimum of 1 lower case character o Minimum of 1 upper case character o Minimum of 1 numeric

o Minimum length of 8 characters

Things you don’t have to do

• Create an installer program.

Implementation Guidelines

A sample implementation would contain the following components

• User Interface (Win based application) o Login for staff/student

o Master information modify function (Media, Director, Categories etc.) o Media borrow/return function

o Query page with results (Reporting for librarian)

• Business Logic and Data Access o User Management

o Security and Authentication management 

o Query Management

-------------------------------------------------------------------------------------------------------

Part 1. Prototype

Enterprise Systems Assessment Guide

You are required to deploy your .Net prototype for scenario solution.

A prototype should demonstrate your ability to provide object-oriented design by using .NET Technology. It also needs to cover the following:

• Login Screen

• Media Search (Minimum of 2 criteria)

• Media Browsing

-------------------------------------------------------------------------------------------------------

Part 2. Programming .Net

Enterprise Systems Assessment Guide

You are required to create full- function .NET application to solve a case study.

Application function include:

• Login

• Media Browse

• Media search (at least 3 criteria including Title search)

• Media borrow

• Media reserve

• Media return

• Master information maintenance (Add new, Update, Delete)

• User information maintenance (Add new, Update, Delete)

• Reporting (at least 1 report)


-------------------------------------------------------------------------------------------------------



Part 3. Cloud Application

Enterprise Systems Assessment Guide

You are required to create a web services to replace local connection between Win-based User Interface (UI) and Business Logic function that you implemented in Part 2.

Part 3.1 Convert direct accesses to web services.

You should have 2 projects solution to complete this Assignment as following:

• Web service project – Developed in Visual Web Developer

• Win-based UI project – Developed in Visual C#

Part 3.2 Win-Based applications

Ensure that all function are required from Part 2 are working, after change the direct reference to Business Logic to Web Services. In this Assessment, portability would be concerned. All static value should be implemented as constant or enumeration.

In this Assessment, portability would be concerned. All static value should be implemented as constant or enumeration.

Implementation Guidelines

A sample implementation would contain the following components

• User Interface (Win based application) o Login for staff/student

                o Master information modify function (Media, Director, Categories etc.) o Media borrow/return function

                o Query page with results (Reporting for librarian/manager)

                o Logout Button

                o Do not add Business Logic and Data Access in UI Solution

• Web Services

            o Consist of Web services, Business Logic and Data Access project o Query Management (Select, Insert, Update and Delete)







-------------------------------------------------------------------------------------------------------




Part 1 Solution


You are required to deploy your .Net prototype for scenario solution.

A prototype should demonstrate your ability to provide object-oriented design by using .NET Technology. It also needs to cover the following:

Login Screen
Book Search (Minimum of 2 criteria)
Book Browsing
 

Matts BattlePlan Guide:

Publish Year search is your main reference throughout this process.

Key: Data Access Layer Business Logic Presentation Layer

Choose a column to search on from the ViewMedia view in the database. You can choose from :
Title, Budget, Language, Director, Genre
In MediaDS add a query to your viewMediaTableAdapter (right click, add query)
Write sql query using query editor to test that it works with execute query (reference publishYear)
Once happy, hit next until you get to the screen where you get to name the auto generated methods. Give them a meaningful name
Update MediaDAO to use the above generated methods you just made. Reference the publish year search method here.
If MediaModel does not show the attribute you are searching on, probably a good idea to add it at this stage
Update MediaLogic to use the MediaDAO methods you made, again reference how Publish Year is working
Update your presentation layer to use your mediaLogic to search for media and display results. Reference Publish Year search


-------------------------------------------------------------------------------------------------------


Part 2 Solution




You are required to create full-function .NET application to solve a case study.

 

Application function include:

Login
Media Browse
Media search (at least 3 criteria including Title search)
Media borrow
Media reserve
Media return
Master information maintenance (Add new, Update, Delete for Media, Genre, Language, Director)
User information maintenance (Add new, Update, Delete)
Reporting (at least 1 report)
 

Matt's BattlePlan

You should already have Login, Media Browse, Media Search and User information maintenance from class and the previous assignment.

Master information maintenance

Use the user add, update, delete code we did in class to help build the section to add Genre, Language and Director aswell as add, update, delete for Media. Remember to start in the Data Layer, then Business, then Presentation. NOTE: selecting genre,language,director for media should be a drop down

Media Borrow/Reserve/Return

You need to add to the user side to do the borrow, reserve, return. This part is intentionally vague. Look at the database and look at the TabReserve and TabBorrow tables.

Reserve:

This one is easier. All you need to do is add a new entry to the table adding the user and mediaID and get the current date of the system (google search C# get current date)

Borrow/Return:

Borrow is more complicated. So you need to add entries into it too, but only insert the user ID, media ID, borrow date and estimated return date. Let the rest of the fields be entered by default values. I'm guessing by the data here (I wouldn't have done it this way) that a media that has the ActualReturnDate greater then or equal to the current date, then its considered returned (default value seems to be 1/1/2000?)

Presentation:

I would add a Borrow and Reserve button to the current user page that Borrows or Reserves the media if its available. Only borrow a media if its not reserved by anyone else. If it is reserved by the user, delete their reservation when they borrow the media.

For return I would make a combo box populated with all of the media the user has borrowed and button next to it saying "Return Media" which basically sets the 'actualReturnDate' for that borrow entry to the current date. Only list borrowed media that have a actualReturnDate less then the BorrowDate (I know its confusing).

Reporting

This part is actually pretty easy. In admin, list a bunch of useful information e.g List all borrowed media entries or reserved media entries






-------------------------------------------------------------------------------------------------------




Part 3 Solution



You are required to create a web services to replace local connection between Win-based User Interface (UI) and Business Logic function that you implemented in Part 2. 

Part 3.1 Convert direct accesses to web services.

You should have 2 projects solution to complete this Assignment as following:

Web service project – Developed in Visual Web Developer
REST services integrated into the ASP.Net Project / Separate API Project.
UI project (Web) – Developed in Visual C#
Part 3.2 UI applications

Ensure that all function are required from Part 2 are working, after change the direct reference to Business Logic to Web Services.

In this Assessment, portability would be concerned. All static value should be implemented as constant or enumeration.

Implementation Guidelines

A sample implementation would contain the following components

User Interface (Win based application)
Login for staff/student
Master information modify function (Books, Authors, Categories etc.)
Books borrow/return function
Query page with results (Reporting for librarian/manager)
Logout Button
Do not add Business Logic and Data Access in UI Solution
Proper use of Constant and Enumeration
Web Services
Consist of Web services, Business Logic and Data Access project
Query Management (Select, Insert, Update and Delete)
 

Matts Battle Plan

First we need to make the web services part before we break our original project.

Web Services

Open up visual studio web developer and create a new ASP.NET empty web application. Once its ready, go file->add->existing project and add your Data Access layer csproj file and Business Logic Layer csproj file. Your web application needs a reference to the business logic layer. From here reference the code I've done in class to make web services for all of your business logic layers methods that the presentation needs.

Note: Can only send basic datatypes via web services (ints, doubles, arrays, strings etc) for cross compatability. So make sure to send either basic types OR dataTables if the information is a list of results.

Note: You are required to use both SOAP and REST services. Please see the marking criteria for more details.

Presentation Layers

This part is not fun. Remove all references of the Business and Data Access projects from your Presentation Layer project. It should have broken your project in all sorts of places. Good!

Run your web services project, it should run a localhost URL which you need to copy.

Now we need to add a web service reference in the presentation layer project, so right click services and choose 'Add Service Reference'. Ignore everything on this screen, click 'Advanced', ignore next screen and click 'Add Web Reference'. On the third screen, paste in the URL and click the green arrow next to it. It should find your web services. Now on the right hand side give your web services reference a name you can easily remember and click 'Add Reference'. It should add to a folder called 'Web References'.

From this point, reference the class code and basically swap out all of your business logic method calls here with web service calls. The hard part is just using datatables instead of using models. Good Luck!

 

About Separation of SOAP / REST Services:

You need to create appropriate REST services (REST Controllers in ASP.Net) to handle Master information maintenance.  ( add, update, delete and list operations of : Genre, Language, Director, Media )
In REST services, you are wrapping the SOAP services which are responsible of calling our Controller and Model components.





