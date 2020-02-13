CREATE DATABASE ACES;

USE ACES;

create table users(
   userID INT NOT NULL AUTO_INCREMENT,
   username VARCHAR(100) NOT NULL,
   password VARCHAR(40) NOT NULL,
   creationDate DATE,
   PRIMARY KEY ( userID )
);

create table students(
   studentID INT NOT NULL AUTO_INCREMENT,
   ghUsername VARCHAR(100) NOT NULL,
   firstName VARCHAR(100) NOT NULL,
   lastName VARCHAR(100) NOT NULL,
   creationDate DATE,
   PRIMARY KEY ( userID )
);

create table course(
   courseID INT NOT NULL AUTO_INCREMENT,
   department VARCHAR(100) NOT NULL,
   courseNum VARCHAR(100) NOT NULL,
   lastName VARCHAR(100) NOT NULL,
   creationDate DATE,
   PRIMARY KEY ( userID )
);


INSERT INTO users(username, password, creationDate)
VALUES('RobertPickard','coolpassword',curdate());

DELETE FROM `users` WHERE `username` = 'Test';

ALTER USER 'admin'@'localhost' IDENTIFIED WITH mysql_native_password BY 'ACES2.0password'

flush privileges;