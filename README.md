# A.C.E.S. 2.0 <img src="Logo.png" height="30"/>
Anti-Cheat Enforcement Software is a software engineering project of Professor Brad Peterson at Weber State University. The project is composed of three major components.
 1. View the status of each student in a course through a web client.
 2. Run various anti-cheat software to ensure that a student is properly doing their work.
 3. Automatically grade assignments operating system agnostically and compiler agnostically.
 
## A.C.E.S. in Docker Containers
 There are three containers for three parts of the project:
 1. The dashboard (user interface)
 2. Gitea (source control for the app, not development 😉 )
 3. The database
 
 *Note: to run these containers, navigate to the directory containing the docker-compose.yml in the console. Then run `docker-compose up -d`. To stop it, run `docker-compose down`. For persistant issues, run `docker system prune -a` to utterly destroy all containers, enabling you to start from scratch. For more detail about what is going on behind the scenes, checkout the Wiki.*  
 
## A.C.E.S. Dashboard
Directory: [A.C.E.S. 2.0/](https://github.com/tjh1541/A.C.E.S./tree/master/A.C.E.S.%202.0/)
### User Interface
*Status: Started*
#### Overview Page
*Status: Optional*

Visualize and summarize the many data collected by the client application.

#### Sections Page
*Status: Done*
<img src="https://github.com/bradleypeterson/A.C.E.S./blob/master/Images/Sections.png">

Display the list of sections which can be filtered by searching for the section’s name and by its archive status. Able to add a new section, edit a section, and archive/restore a section.

#### Section Page
*Status: Done*
<img src="https://github.com/bradleypeterson/A.C.E.S./blob/master/Images/Section.png">

Display the list of students which are enrolled in that section. Students can be filtered by searching for the student’s name and academic standing. Able to enroll/remove students.

#### Courses Page
*Status: Done*
<img src="https://github.com/bradleypeterson/A.C.E.S./blob/master/Images/Courses.png">

Display the list of courses which can be filtered by searching for the course’s name and by its archive status. Able to add a new course, edit a course, and archive/restore a course.

#### Course Page
*Status: Done*
<img src="https://github.com/bradleypeterson/A.C.E.S./blob/master/Images/Course.png">

Display the list of assignments for that course which can be filtered by searching for the assignment’s name and by its archive status. Able to add a new assignment, edit an assignment, and archive/restore an assignment.

#### Students Page
*Status: Done*
<img src="https://github.com/bradleypeterson/A.C.E.S./blob/master/Images/Students.png">

Display the list of students which can be filtered by searching for the student’s name, their academic standing, and by their archive status. Able to add a new student, edit a student, and archive/restore a student.

#### Student Page
*Status: In Progress*
<img src="https://github.com/bradleypeterson/A.C.E.S./blob/master/Images/Student.png">

Display details about the student and display the most recently submitted assignments and full history of assignment submissions. Able to override the assignment’s Academic Standing.

#### Student Submissions Page
*Status: Started*
<img src="https://github.com/bradleypeterson/A.C.E.S./blob/master/Images/Submissions.png">

Display list of all submissions of a student’s particular assignment. Able to download a submission from Github.

### Backend
*Status: Planned*

## A.C.E.S. Autocommit
*Status: Completed*

The auto commit functionallity auto commits the local repo every time the project is run. On every fifth it updates the 
repo and checks to see if the project is out of date and it if is it will not allow the user to run the unit tests.

## Github Actions
*Status: Planned*

This repo contains a basic example of how to do a simple github action that when ran prints out hello world on github's linux server. The main files that should be looked at, are the github action's main.cpp, CMakelits.txt, and finally the ccpp.ymal file found in github actions' github workflows file.

## A.C.E.S. Anti-Cheat
Directory: [A.C.E.S. 2.0/Anti-Cheat](https://github.com/tjh1541/A.C.E.S./tree/master/A.C.E.S.%202.0/ACES%20Anti-Cheat)
### Watermarking
*Status: Started*

Directory: [A.C.E.S. 2.0/Anti-Cheat/Watermarking](https://github.com/tjh1541/A.C.E.S./tree/master/A.C.E.S.%202.0/ACES%20Anti-Cheat/Watermarking)

Creates a unique watermarked version of an assignment for each individual student. When a student submits there source code, the anti-cheat tool will be able to determin if any of the watermarkings have been tampered with or if the student has copied code from another source.

### Student Progress
*Status: Started*

Keeps track of the progress of a student on their assignment to determin if they are properly testing their codes, and is incrementally finishing their assignment. An abrupt completion of an assignment can be seen suspicious.
View [A.C.E.S. Autocommit](https://github.com/tjh1541/A.C.E.S./blob/master/README.md#aces-autocommit) for more info.

## A.C.E.S. Autotester
*Status: Planned*

The Autotester uses Github Actions to automatically test, grade, and check for possible cheating for student's assignments which is pushed to the Github Classroom repository.

# A.C.E.S. 1.0
Project worked on groups before Spring Semester of 2020. The project scope and requirements have had significant changes from A.C.E.S. 1.0 to A.C.E.S. 2.0 and A.C.E.S. 1.0 files have been depricated.
