CREATE DATABASE ACES;

USE ACES;

create table students(
   studentID INT NOT NULL AUTO_INCREMENT,
   ghUsername VARCHAR(100) NOT NULL,
   firstName VARCHAR(100) NOT NULL,
   lastName VARCHAR(100) NOT NULL,
   creationDate DATE,
   FOREIGN KEY (studentID) REFERENCES users(userID),
   PRIMARY KEY ( studentID )
);

create table courses(
   courseID INT NOT NULL AUTO_INCREMENT,
   department VARCHAR(100) NOT NULL,
   courseNum VARCHAR(100) NOT NULL,
   courseName VARCHAR(100) NOT NULL,
   creationDate DATE,
   PRIMARY KEY ( courseID )
);

create table sections(
	sectionID INT NOT NULL AUTO_INCREMENT,
	sectionCourseID INT NOT NULL,
	FOREIGN KEY (sectionCourseID) REFERENCES courses(courseID),
	PRIMARY KEY (sectionID)
);

create table assignments(
	assignmentID INT NOT NULL AUTO_INCREMENT,
	assignmentSectionID INT NOT NULL,
	assignmentStudentID INT NOT NULL,
	FOREIGN KEY (assignmentSectionID) REFERENCES sections(sectionID),
	FOREIGN KEY (assignmentStudentID) REFERENCES students(studentID),
	PRIMARY KEY (assignmentID)
);


INSERT INTO users(username, password, creationDate)
VALUES('RobertPickard','coolpassword',curdate());

DELETE FROM `users` WHERE `username` = 'Test';

ALTER USER 'admin'@'localhost' IDENTIFIED WITH mysql_native_password BY 'ACES2.0password'

flush privileges;
