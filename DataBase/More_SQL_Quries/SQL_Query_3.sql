-- Specifying DataBase
USE Company_SD;

/*
-- [1] Display (Using Union Function)
 The name and the gender of the dependence that's gender is Female and depending on Female Employee.
 And the male dependence that depends on Male Employee.
*/
SELECT D.Dependent_name, D.Sex
FROM Dependent D INNER JOIN Employee E
ON E.SSN = D.ESSN AND D.Sex = 'F' AND E.Sex = 'F'
UNION
SELECT D.Dependent_name, D.Sex
FROM Dependent D INNER JOIN Employee E
ON E.SSN = D.ESSN AND D.Sex = 'M' AND E.Sex = 'M';

-- [2] For each project, list the project name and the total hours per week (for all employees) spent on that project.
SELECT P.Pname, SUM(W.Hours) [Total hours per weak]
FROM Project AS P INNER JOIN Works_for AS W
ON P.Pnumber = W.Pno
GROUP BY P.Pname;

-- [3] Display the data of the department which has the smallest employee ID over all employees' ID.
SELECT D.*
FROM Departments D INNER JOIN Employee E
ON D.Dnum = E.Dno
WHERE E.SSN = (SELECT MIN(SSN) FROM Employee);

-- [4] For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
SELECT D.Dname, MAX(E.Salary) [Maximum], MIN(E.Salary) [Minimum], AVG(E.Salary) [Average]
FROM Departments D INNER JOIN Employee E
ON D.Dnum = E.Dno
GROUP BY D.Dname;

-- [5] List the full name of all managers who have no dependents.
SELECT DISTINCT MGR.Fname, MGR.Lname
FROM Employee MGR
LEFT JOIN Employee E ON MGR.SSN = E.Superssn
LEFT JOIN Dependent DP ON MGR.SSN = DP.ESSN
WHERE DP.ESSN IS NULL;
 
-- [6] For each department-- if its average salary is less than the average salary of all employees-- display its number, name and number of its employees.
SELECT D.Dnum, D.Dname, COUNT(E.Dno) [Number of employee]
FROM Employee E INNER JOIN Departments D
ON D.Dnum = E.Dno
GROUP BY D.Dnum, D.Dname
HAVING AVG(E.Salary) < (SELECT AVG(Salary) FROM Employee);

/*
-- [7] Retrieve a list of employees names and the projects names they are working on ordered by department number and within each department,
	   ordered alphabetically by last name, first name.
*/
SELECT E.Fname, E.Lname, P.Pname
FROM Employee E 
INNER JOIN Departments D ON D.Dnum = E.Dno
INNER JOIN Project P ON P.Dnum = E.Dno
INNER JOIN Works_for W ON E.SSN = W.ESSn
ORDER BY D.Dnum, E.Lname, E.Fname;

-- [8] Try to get the max 2 salaries using subquery
SELECT MAX(Salary) [Top Salaries] FROM Employee
UNION ALL
SELECT MAX(SALARY) FROM Employee
WHERE SALARY < (SELECT MAX(SALARY) FROM Employee);

-- [9] Get the full name of employees that is similar to any dependent name
SELECT E.Fname, E.Lname
FROM Employee E, Dependent D
WHERE CONCAT(E.Fname, ' ', E.Lname) 
LIKE CONCAT('%', D.Dependent_name, '%');

-- [10] Display the employee number and name if at least one of them have dependents (use exists keyword) self-study.
SELECT SSN, Fname, Lname
FROM Employee E
WHERE EXISTS (
	SELECT 1 -- Any value we need only check that dependents exist or not, not retrieveing value.
	FROM Dependent D 
	WHERE E.SSN = D.ESSN
);
/*
	If dependents exists EXISTS return TRUE and the parent query display the rows that related with dependents
	If not exists any dependents the EXISTS return FALSE and the parent query will not display any rows
*/



/*
-- [11] In the department table insert new department called "DEPT IT" , with id 100, employee with SSN = 112233 
		as a manager for this department. The start date for this manager is '1-11-2006'
*/
INSERT INTO Departments
VALUES('DEPT IT', 100,112233, '1-11-2006')

/*
-- [12] Do what is required if you know that : Mrs.Noha Mohamed(SSN=968574)  moved to be the manager of the new department
		(id = 100), and they give you(your SSN =102672) her position (Dept. 20 manager) 

		A.  First try to update her record in the department table
		B	Update your record to be department 20 manager.
		C.	Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
*/
-------------A--------------
UPDATE Departments
SET MGRSSN = 968574
WHERE Dnum = 100
-------------B--------------
UPDATE Departments
SET MGRSSN = 102672
WHERE Dnum = 20
---   ---   ---   ---   ---
UPDATE Employee
SET Dno = 20
WHERE SSN = 102672
-------------C--------------
UPDATE Employee
SET Superssn = 102672
WHERE SSN = 102660

/*
-- [13] Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344) so\
	try to delete his data from your database in case you know that you will be temporarily in his position.
	Hint: (Check if Mr. Kamel has dependents, works as a department manager, supervises any employees 
	or works in any projects and handle these cases).
*/
-------------------------Delete his dependents data------------------------
DELETE FROM Dependent
WHERE ESSN = 223344;

-------------------------Update ManergerSSN with my SSN--------------------
UPDATE Employee
SET Superssn = 102672
WHERE Superssn = 223344;

-------------------------Update maneger of department----------------------
UPDATE Departments
SET MGRSSN = 102672
WHERE MGRSSN = 223344;

-------------------------Update woking for project-------------------------
UPDATE Works_for
SET ESSn = 102672
WHERE ESSn = 223344;

-------------------------Delete Kamel Mohamed data from table---------------
DELETE FROM Employee
WHERE SSN = 223344;


-- [14] Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
UPDATE Employee
SET Salary = Salary * 1.3 -- Salary = (Salary + Salary * 0.3)
WHERE SSN IN (
	SELECT E.SSN
	FROM Employee E
	INNER JOIN Works_for W ON E.SSN = W.ESSn
	INNER JOIN Project P ON W.Pno = P.Pnumber
	WHERE P.Pname = 'Al Rabwah'
);
