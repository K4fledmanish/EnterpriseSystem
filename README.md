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
What to submit

A solution, which include; Win-based UI and Web Services project.


-------------------------------------------------------------------------------------------------------

