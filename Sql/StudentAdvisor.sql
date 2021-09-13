/****** 
Student Advisor 
A university has started a student-advisor plan which assigns a professor as an advisor to each student for academic guidance. Write a query to find the roll number and names of students who either have a male advisor with a salary of more than 15,000 or a female advisor with a salary of more than 20,000. 
There are two tables in the database: student information and faculty information. The primary key of ation is roll number whereas that of faculty information is employee ID. 
♦ Schema : 
You are provided 2 tables: student_information, faculty_information. 
student information: 
Name Type Description 
roll_number INTEGER The roll number of the student. This is the primary key. 
name STRING The name of the student. 
advisor INTEGER The employee ID of the advisor of the student. 

faculty_information: 
Name Type Description 
employee_ID INTEGER The employee ID of the professor. This is the primary key. 
gender CHAR The gender of the professor (M for male and F for female). 
salary INTEGER The salary of the professor. 
Note: Information about any professor who acts as an advisor to a student is always present in faculty information. 

******/
select student.roll_number, student.name 
from student_information student, faculty_information faculty 
where student.advisor = faculty.employee_id and (faculty.gender = 'M' and faculty.salary > 15000 or faculty.gender = 'F' and faculty.salary > 20000) 