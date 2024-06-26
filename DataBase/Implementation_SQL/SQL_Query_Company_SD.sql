-- Specify Database to use
USE Company_SD;

-- [1] Display the Department id, name and id and the name of its manager.
SELECT Dnum, Dname, Fname, Lname
FROM Departments AS D, Employee AS E
WHERE E.SSN = D.MGRSSN; 

/* Notes
	1. We can replace `,` with `INNER JOIN` between D and E
	   and When replace it we must replace `WHERE` with `ON`.

	2. `AS` is optional we can remove it.
	
	3. We can write SQL queries in uppercase or lowercase (personal preference)
*/

-- [2] Display the name of the departments and the name of the projects under its control.
SELECT Dname, Pname
FROM Departments D INNER JOIN Project P
ON D.Dnum = P.Dnum;

-- [3] Display the full data about all the dependence associated with the name of the employee they depend on him/her.
SELECT D.Dependent_name, D.Sex, D.Bdate, E.Fname, E.Lname 
FROM Dependent AS D INNER JOIN  Employee AS E
ON E.SSN = D.ESSN;

-- [4] Display the Id, name and location of the projects in Cairo or Alex city.
SELECT Pnumber, Pname, Plocation
FROM Project
WHERE City = 'Alex' OR City = 'Cairo';

-- [5] Display the Projects full data of the projects with a name starts with "a" letter.
SELECT * FROM Project
WHERE Pname LIKE 'a%';

-- [6] Display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
SELECT * FROM Employee
WHERE Salary BETWEEN 1000 AND 2000;

-- [7] Retrieve the names of all employees in department 10 who works more than or equal10 hours per week on "AL Rabwah" project.
SELECT DISTINCT E.Fname, E.Lname
FROM Employee AS E 
INNER JOIN Works_for AS W ON E.SSN = W.ESSn
INNER JOIN Project AS P ON P.Pnumber = W.Pno
WHERE E.Dno = 10 AND Hours >= 10 AND P.Pname = 'AL Rabwah';

-- [8] Find the names of the employees who directly supervised with Kamel Mohamed.
SELECT E.Fname, E.Lname
FROM Employee E, Employee MGR
WHERE MGR.SSN = E.Superssn AND MGR.Fname = 'Kamel' AND  MGR.Lname = 'Mohamed';

-- [9] Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
SElECT E.Fname, E.Lname, P.Pname
FROM Employee E, Project P
WHERE P.Dnum = E.Dno -- Relation between two forgin key Department_Number => PK
ORDER BY P.Pname; -- Alphabetical order based on project name

/*
-- [10] For each project located in Cairo City , find the project number, the controlling department name ,
   the department manager last name ,address and birthdate.
*/ -- We can solve this by inner join method but this is easier with commas
SELECT P.Pnumber, D.Dname, MGR.Lname, MGR.Address, MGR.Bdate
FROM Project P, Departments D, Employee MGR
WHERE P.City = 'Cairo' AND  D.Dnum = P.Dnum AND MGR.SSN = D.MGRSSN;

-- [11] Display All Data of the managers
SELECT DISTINCT MGR.*
FROM Employee E, Employee MGR
WHERE MGR.SSN = E.Superssn; -- Self relationship

-- [12] Display All Employees data and the data of their dependents even if they have no dependents
SELECT DISTINCT *
FROM Employee E LEFT OUTER JOIN Dependent D
ON E.SSN = D.ESSN;

-- [13] Insert your personal data to the employee table as a new employee in department number 30, SSN = 102672, Superssn = 112233, salary=3000.
INSERT INTO Employee(Fname, Lname, SSN, Bdate, Address, Sex, Salary, Superssn, Dno)
VALUES('Kareem', 'Hany', 102672,  2004-3-3, '234 Egypt cairo', 'M', 3000, 112233, 30);

/*
-- [14] Insert another employee with personal data your friend as new employee in department number 30,
   SSN = 102660, but don’t enter any value for salary or supervisor number to him.
*/
INSERT INTO Employee(Fname, Lname, SSN, Bdate, Address, Sex, Dno)
VALUES('Ahmed', 'ali', 102660,  2001-6-22, '534 Egypt Alex', 'M', 30);

-- [15] Upgrade your salary by 20 % of its last value.
UPDATE Employee 
SET Salary = (Salary + Salary * 0.2)
WHERE SSN = 102672;
