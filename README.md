# LibrarySystem-AdvancedDB

This is another version of a previous work where it was developed using Relational database management and now its' database has been transferred to NoSQL(MongoDB).

This program is developed for the Advanced database term Project SE308. 
In this project, we are responsible for the design of a Library Management System LMS connected to the NoSql database (MongoDB).
Team Member:  [Yousra Alaklouk](https://github.com/YousraAlaklouk), [Sami Haj](https://github.com/SamTheDemon),[Abdulaziz Alhussein](https://github.com/AbdulazizSE).


## HOW TO RUN: 
 ### setting up winform.
-   download or clone the repo [https://github.com/YousraAlaklouk/LMS](https://github.com/YousraAlaklouk/LMS).
-   Open it as a project in Visual Studio Code.
-   import the database backup `LibraryManagment.bacpac`. 
-   Download `Bunifu_UI_1.52.dll` Framework
-   after downloading the framework, and opening the library solution in Visual Studio Code
-   to set up the framework you can follow the following steps or watch this video [Youtube-adding-framework-windows-form](https://www.youtube.com/watch?v=BVijtVjj_QQ).
-   From the **toolbox panel right click** in an empty place --> **Choose Item**.
-   Browse to the `Bunifu_UI_1.52.dll` location then it will take some time to load
-   ![image](https://user-images.githubusercontent.com/63297594/168149166-5f869e8e-654f-443c-860e-4f4df75d4b6b.png)
-   right-click on References -> Add reference. 
-   ![image](https://user-images.githubusercontent.com/63297594/168148110-29005552-0e01-43e6-9d9e-0df9fd180ab5.png)
-   Then, Browser to the `Bunifu_UI_1.52.dll` location. then add it. 
 ### setting up mongoDB.
 -  You need to have your own database, collections and connection string URL:
 -  Change it to your connection String at `client = new MongoClient("mongodb+srv://<Username>:<Password>@cluster0.kpzzh.mongodb.net/?retryWrites=true&w=majority");`
   - Change <Username> and <password> to your, to your username and password.
 -  if you have your own database then change the name of the data base at `mongodb = client.GetDatabase("LibraryManagement");`
 -  same will be applied for collection names(BOOK) and Object models(AddBook1) `BookCollection = mongodb.GetCollection<AddBook1>("BOOK");`
           

 ## USERS - ROLES
 This applications consist of three users types/roles  (Admin, Staff, Member):
 ### admin
 - Admin login configuration    (username: admin, password: admin).
 - An admin is able to:
    -   add/edit/delete admins, members, staff.
    -   add/edit/delete books, authors, publishers 
    -   view reports (panlety reports and borrwing reports)
    -   assign new users(admin, staff, member) login.
    -   view its own profile.
    -   **CAN'T borrow a book.**
 ### staff
 - Staff login configuration    (username: staff, password: staff).
  -  A staff is able to:
    -   cashier realted tasks, (receivng penalty, checking for penalty, etc...)
    -   add/edit/delete members.
    -   add/edit/delete books, authors, publishers.
    -   view reports (panlety reports and borrwing reports).
    -   view its own profile.
    -   **Borrow a book**.
 ### Member
 - Member login configuration   (username: memberm passwpord: member).
 -  A member is able to:
    -  Borrow a book.
    -  Return a book.
    -  View borrowing history.
    -  Pay for panelty.
 
## Things to improve: 
 - Complete the roles functionalities where an admin can add a new role and give it a specific access to specific interfaces(Tasks). 
 - Improve Cashier functionalities.
 - Adding Payment API, to allow real payment. 
 - Improve the GUI of the application.
