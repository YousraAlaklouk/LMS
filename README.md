# LibrarySystem-AdvancedDB

This program is developed for Advanced database term Project SE308. 
In this project we are reposonle on the design of a Library manegmanet System connected to NoSql data base 

## HOW TO RUN FOR EARLY DEVELOPMENT
-   download or clone the repo [https://github.com/SamTheDemon/LibrarySystem-AdvancedDB.git](https://github.com/SamTheDemon/LibrarySystem-AdvancedDB.git).
-   Open it as project in Visual Studio Code.
-   import the database backup `LibraryManagment.bacpac`. 
-   Download `Bunifu_UI_1.52.dll` Framework
-   after downlaoding the framework, and opening the library solution in Visual Studio Code
-   to set up the framework you can follow the following steps or watch this video [Youtube-adding-framework-windows-form](https://www.youtube.com/watch?v=BVijtVjj_QQ).
-   From the **toolbox panel right click** in an empty place --> **Choose Item**.
-   Browse to the `Bunifu_UI_1.52.dll` location then it will take some time to load
-   ![image](https://user-images.githubusercontent.com/63297594/168149166-5f869e8e-654f-443c-860e-4f4df75d4b6b.png)
-   right click on Refrences -> Add refrence. 
-   ![image](https://user-images.githubusercontent.com/63297594/168148110-29005552-0e01-43e6-9d9e-0df9fd180ab5.png)
-   Then, Browser to the `Bunifu_UI_1.52.dll` location. then add it.




 ## USERS - ROLES
 This applications consist of three users types/roles:
 - admin
 - staff
 - Member
 - Admin login configuration    (username: admin, password: admin)
 - Staff login configuration    (username: staff, password: staff)
 - Member login configuration   (username: memberm passwpord: member)
 - An admin is able to:
    -   add/edit/delete admins, members, staff.
    -   add/edit/delete books, authors, publishers 
    -   view reports (panlety reports and borrwing reports)
    -   assign new users(admin, staff, member) login.
    -   view its own profile.
    -   **CAN'T borrow a book.**
 -  A staff is able to:
    -   cashier realted tasks, (receivng penalty, checking for penalty, etc...)
    -   add/edit/delete members.
    -   add/edit/delete books, authors, publishers.
    -   view reports (panlety reports and borrwing reports).
    -   view its own profile.
    -   **Borrow a book**.
 -  A member is able to:
    -  Borrow a book.
    -  return a book.
    -  view borrowing history
    -  Pay for panelty.
 
 
