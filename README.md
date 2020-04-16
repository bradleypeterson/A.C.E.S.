# A.C.E.S. 2.0 <img src="Logo.png" height="30"/>
Anti-Cheat Enforcement Software is a software engineering project of Professor Brad Peterson at Weber State University. The project is composed of three major components.
 1. View the status of each student in a course through a web client.
 2. Run various anti-cheat software to ensure that a student is properly doing their work.
 3. Automatically grade assignments operating system agnostically and compiler agnostically.
## A.C.E.S. Dashboard
Directory: [A.C.E.S. 2.0/](https://github.com/tjh1541/A.C.E.S./tree/master/A.C.E.S.%202.0/)
### User Interface

*Status: Started*
#### Overview Page

*Status: Started*
#### Sections Page

*Status: Started*
#### Section Page

*Status: Started*
#### Courses Page

*Status: Started*
#### Course Page

*Status: Started*
#### Students Page

*Status: Started*
#### Student Page

*Status: Started*
#### Student Submissions Page

*Status: Started*
### Backend

*Status: Planned*
## A.C.E.S. Autocommit

*Status: Completed*

The auto commit functionallity auto commits the local repo every time the project is run. On every fifth it updates the 
repo and checks to see if the project is out of date and it if is it will not allow the user to run the unit tests.

## Github Actions

This repo contains a basic example of how to do a simple github action that when ran prints out hello world on github's linux server. The main files that should be looked at, are the github action's main.cpp, CMakelits.txt, and finally the ccpp.ymal file found in github actions' github workflows file.

## A.C.E.S. Anti-Cheat
Directory: [A.C.E.S. 2.0/Anti-Cheat](https://github.com/tjh1541/A.C.E.S./tree/master/A.C.E.S.%202.0/ACES%20Anti-Cheat)
### Watermarking
Directory: [A.C.E.S. 2.0/Anti-Cheat/Watermarking](https://github.com/tjh1541/A.C.E.S./tree/master/A.C.E.S.%202.0/ACES%20Anti-Cheat/Watermarking)

Creates a unique watermarked version of an assignment for each individual student. When a student submits there source code, the anti-cheat tool will be able to determin if any of the watermarkings have been tampered with or if the student has copied code from another source.

*Status: Started*

### Student Progress
Keeps track of the progress of a student on their assignment to determin if they are properly testing their codes, and is incrementally finishing their assignment. An abrupt completion of an assignment can be seen suspicious.

View [A.C.E.S. Autocommit](https://github.com/tjh1541/A.C.E.S./blob/master/README.md#aces-autocommit) for more info.

*Status: Started*

## A.C.E.S. Autotester
The Autotester uses Github Actions to automatically test, grade, and check for possible cheating for student's assignments which is pushed to the Github Classroom repository.

*Status: Planned*
# A.C.E.S. 1.0
Project worked on groups before Spring Semester of 2020. The project scope and requirements have had significant changes from A.C.E.S. 1.0 to A.C.E.S. 2.0 and A.C.E.S. 1.0 files have been depricated.
