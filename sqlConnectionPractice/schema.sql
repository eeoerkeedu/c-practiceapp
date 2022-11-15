DROP DATABASE IF EXISTS students_db;
CREATE DATABASE students_db;

USE students_db;
CREATE TABLE student(
	id  INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(30) NOT NULL,
    last_name VARCHAR(30) NOT NULL,
    major VARCHAR(30) NOT NULL,
    active BOOLEAN NOT NULL,
    credit_hours INT DEFAULT 0
);