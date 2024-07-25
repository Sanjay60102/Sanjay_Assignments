-- Create Department table
use Assignment2
CREATE TABLE Department (
    Dept_no VARCHAR(2) PRIMARY KEY,
    Dept_name VARCHAR(50),
    Location VARCHAR(50)
);

-- Insert data into Department table
INSERT INTO Department (Dept_no, Dept_name, Location) VALUES
('d1', 'Research', 'Dallas'),
('d2', 'Accounting', 'Seattle'),
('d3', 'Marketing', 'Dallas');

-- Create Employee table
CREATE TABLE Employee (
    Emp_no INT PRIMARY KEY,
    Emp_fname VARCHAR(50),
    Emp_lname VARCHAR(50),
    Dept_no VARCHAR(2),
    FOREIGN KEY (Dept_no) REFERENCES Department(Dept_no)
);

-- Insert data into Employee table
INSERT INTO Employee (Emp_no, Emp_fname, Emp_lname, Dept_no) VALUES
(25348, 'Matthew', 'Smith', 'd3'),
(10102, 'Ann', 'Jones', 'd3'),
(18316, 'John', 'Barrimore', 'd1'),
(9031, 'Gayathri', 'Alla', 'd4'),
(2581, 'Keerthi', 'Singamsetty', 'd3'),
(29346, 'Bhavani', 'Peddi', 'd4'),
(1234, 'Sridevi', 'James', 'd1'),
(4321, 'Srinu', 'pottella', 'd2'),
(6789, 'Alekhya', 'Mallavarapu', 'd1'),
(29346, 'James', 'James', 'd2');

-- Create Project table
CREATE TABLE Project (
    Project_no VARCHAR(2) PRIMARY KEY,
    Project_name VARCHAR(50),
    Budget DECIMAL(10, 2)
);

-- Insert data into Project table
INSERT INTO Project (Project_no, Project_name, Budget) VALUES
('p1', 'Apollo', 120000),
('p2', 'Gemini', 95000),
('p3', 'Mercury', 185600);

-- Create Works_on table
CREATE TABLE Works_on (
    Emp_no INT,
    Project_no VARCHAR(2),
    Job VARCHAR(50),
    Enter_date DATE,
    PRIMARY KEY (Emp_no, Project_no),
    FOREIGN KEY (Emp_no) REFERENCES Employee(Emp_no),
    FOREIGN KEY (Project_no) REFERENCES Project(Project_no)
);

-- Insert data into Works_on table
INSERT INTO Works_on (Emp_no, Project_no, Job, Enter_date) VALUES
(10102, 'p1', 'Analyst', '1997-10-01'),
(10102, 'p3', 'Manager', '1999-01-01'),
(25348, 'p2', 'Clerk', '1998-02-15'),
(18316, 'p2', NULL, '1998-06-01'),
(29346, 'p2', NULL, '1997-12-15'),
(2581, 'p3', 'Analyst', '1998-10-15'),
(9031, 'p1', 'Manager', '1998-04-15'),
(28559, 'p1', NULL, '1998-08-01'),
(28559, 'p2', 'Clerk', '1992-02-01'),
(9031, 'p3', 'Clerk', '1997-11-15'),
(29346, 'p1', 'Clerk', '1998-01-04');

select * from Department
select * from Employee
select * from Project

--Get all row of the works_on table.
select * from Works_on

--Get the employee numbers for all clerks
select Emp_no from Works_on where Job='Clerk'

--Get the employee numbers for employees working in project p2, and having employee numbers smaller than 10000.
select Emp_no from Works_on where Project_no='p2' and Emp_no<10000

--Get the employee numbers for all employees who didn’t enter their project in 1998
select Emp_no from Works_on where YEAR(Enter_date)!=1998