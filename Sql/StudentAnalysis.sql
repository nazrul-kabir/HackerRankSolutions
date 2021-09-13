/****** 
Student Analysis 
A school recently conducted its annual examination and wishes to know the list of academically low performing students to organize extra classes for them. Write a query to return the roll number and names of students who have a total of less than 100 marks including all 3 subjects. 
There are two tables: student information and examination_marks. Their primary keys are roll number. 
Schema: 
You are provided 2 tables: student_information, examination_marks. 
student_information 
Name Type Description 
rollnumber INTEGER The roll number of the student. This is the primary key. 
name STRING The name of the student. 

examination_marks 
Name Type Description 
roll_number INTEGER The roll number of the student. This is the primary key. 
subject_one INTEGER The marks of the student in first subject. 
subject_two INTEGER The marks of the student in second subject. 
subject three INTEGER The marks of the student in third subject.
******/
Select s.roll_number, s.name from student_information s inner join examination_marks m
on s.roll_number = m.roll_number
where (subject_one + subject_two + subject_three)<100