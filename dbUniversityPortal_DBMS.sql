
CREATE DATABASE dbUniversityPortal_DBMS

USE dbUniversityPortal_DBMS


CREATE TABLE Admin(
Admin_ID nvarchar(50) PRIMARY KEY,
Name nvarchar(50) NOT NULL,
Gender varchar(10),
Email nvarchar(70) NOT NULL,
PhoneNo nvarchar(20),
Password nvarchar(20) DEFAULT 'admin123' NOT NULL 
)

CREATE TABLE Notices(
Notice_NO int PRIMARY KEY IDENTITY(1,1),
Notice nvarchar(400) NOT NULL,
Notice_For varchar(20) NOT NULL
)

CREATE TABLE Departments(
Dept_No int PRIMARY KEY,
Dept_Name nvarchar(50) NOT NULL,
Dept_Block varchar(20)
)

CREATE TABLE Teachers(
Teacher_ID nvarchar(50) PRIMARY KEY,
Name nvarchar(50) NOT NULL,
Gender varchar(10),
Email nvarchar(70) NOT NULL,
PhoneNo nvarchar(20),
Password nvarchar(20) DEFAULT 'teacher123' NOT NULL,
Dept_No int FOREIGN KEY REFERENCES Departments(Dept_No)
ON DELETE NO ACTION
ON UPDATE CASCADE
NOT NULL
)

CREATE TABLE Students(
Student_ID nvarchar(50) PRIMARY KEY,
Name nvarchar(50) NOT NULL,
Gender varchar(10),
Email nvarchar(70) NOT NULL,
PhoneNo nvarchar(20),
Program nvarchar(50) NOT NULL,
Password nvarchar(20) DEFAULT 'student123' NOT NULL
)

CREATE TABLE Courses(
Course_ID nvarchar(10) PRIMARY KEY,
Course_Name nvarchar(50) NOT NULL,
Credit_Hours decimal(5,1) NOT NULL,
Prerequisite nvarchar(10) FOREIGN KEY REFERENCES Courses(Course_ID) NULL,
Teacher_ID nvarchar(50) FOREIGN KEY REFERENCES Teachers(Teacher_ID)
ON DELETE NO ACTION
ON UPDATE CASCADE
NOT NULL
)

CREATE TABLE Announcements(
Ann_No int PRIMARY KEY IDENTITY(1,1),
Announcement nvarchar(300) NOT NULL,
Teacher_ID nvarchar(50) FOREIGN KEY REFERENCES Teachers(Teacher_ID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Course_ID nvarchar(10) FOREIGN KEY REFERENCES Courses(Course_ID)
ON DELETE CASCADE
)

CREATE TABLE Enrolled(
Course_ID nvarchar(10) FOREIGN KEY REFERENCES Courses(Course_ID)
ON DELETE SET NULL
ON UPDATE CASCADE,
Student_ID nvarchar(50) FOREIGN KEY REFERENCES Students(Student_ID)
ON DELETE SET NULL
ON UPDATE CASCADE,
Reg_Date Date,
Attendence nvarchar(10),
Grade nvarchar(6),
Semester nvarchar(15)
)


CREATE VIEW Admin_Login_Table
AS
	SELECT Admin_ID,Password
	FROM Admin


CREATE PROCEDURE admin_login
(
	@ID nvarchar(50),
	@Password nvarchar(20)
)
AS
	BEGIN
		SELECT 'true' FROM Admin_Login_Table WHERE Admin_ID = @ID AND Password = @Password
	END


CREATE VIEW Student_Login_Table
AS
	SELECT Student_ID,Password
	FROM Students


CREATE PROCEDURE student_login
(
	@ID nvarchar(50),
	@Password nvarchar(20)
)
AS
	BEGIN
		SELECT 'true' FROM Student_Login_Table WHERE Student_ID = @ID AND Password = @Password
	END


CREATE VIEW Teacher_Login_Table
AS
	SELECT Teacher_ID,Password
	FROM Teachers


CREATE PROCEDURE teacher_login
(
	@ID nvarchar(50),
	@Password nvarchar(20)
)
AS
	BEGIN
		SELECT 'TRUE' FROM Teacher_Login_Table WHERE Teacher_ID = @ID AND Password = @Password
	END


CREATE PROCEDURE add_student
(
	@ID nvarchar(50),
    @Name nvarchar(50),
    @Gender varchar(10),
	@Email nvarchar(70),
	@PhoneNo nvarchar(20),
    @Program nvarchar(50),
    @Password nvarchar(20)
)
AS
	BEGIN
		INSERT INTO [dbo].[Students]
           (Student_ID,Name,Gender,Email,PhoneNo,Program,Password)
	     VALUES
           (@ID,@Name,@Gender,@Email,@PhoneNo,@Program,@Password)
	END


CREATE PROCEDURE program_students
(
	@Program nvarchar(50)
)
AS
	BEGIN
		SELECT * FROM Students WHERE Program LIKE '%'+@Program+'%';
	END


CREATE PROCEDURE update_student
(
	@ID nvarchar(50),
	@Name nvarchar(50),
	@Email nvarchar(70),
	@PhoneNo nvarchar(20),
	@Password nvarchar(20)
)
AS
	BEGIN
		UPDATE Students
		SET Name = @Name,
			Email = @Email,
			PhoneNo = @PhoneNo,
			Password = @Password
		WHERE Student_ID = @ID
	END


CREATE PROCEDURE search_student
(
	@ID nvarchar(50)
)
AS
	BEGIN
		SELECT * FROM Students WHERE Student_ID LIKE '%'+@ID+'%'
	END


CREATE PROCEDURE add_teacher
(
	@ID nvarchar(50),
    @Name nvarchar(50),
    @Gender varchar(10),
	@Email nvarchar(70),
	@PhoneNo nvarchar(20),
	@Password nvarchar(20),
    @Dept_No int
)
AS
	BEGIN
		INSERT INTO [dbo].[Teachers]
			(Teacher_ID,Name,Gender,Email,PhoneNo,Password,Dept_No)
	     VALUES
           (@ID,@Name,@Gender,@Email,@PhoneNo,@Password,@Dept_No)
	END


CREATE VIEW Teacher_Table
AS
	SELECT t.Teacher_ID,t.Name,t.Gender,t.Email,t.PhoneNo,t.Password,d.Dept_Name FROM Teachers t
	INNER JOIN Departments d
	ON t.Dept_No = d.Dept_No


CREATE PROCEDURE update_teacher
(
	@ID nvarchar(50),
	@Name nvarchar(50),
	@Email nvarchar(70),
	@PhoneNo nvarchar(20),
	@Password nvarchar(20),
	@Dept_No int
)
AS
	BEGIN
		UPDATE Teachers
		SET Name = @Name,
			Email = @Email,
			PhoneNo = @PhoneNo,
			Password = @Password,
			Dept_No = @Dept_No
		WHERE Teacher_ID = @ID
	END


CREATE PROCEDURE search_teacher
(
	@ID nvarchar(50)
)
AS
	BEGIN
		SELECT t.Teacher_ID,t.Name,t.Gender,t.Email,t.PhoneNo,t.Password,d.Dept_Name FROM Teachers t
		INNER JOIN Departments d
		ON t.Dept_No = d.Dept_No
		WHERE Teacher_ID LIKE '%'+@ID+'%'
	END


CREATE PROCEDURE dept_teacher
(
	@Dept_No nvarchar(50)
)
AS
	BEGIN
		SELECT t.Teacher_ID,t.Name,t.Gender,t.Email,t.PhoneNo,t.Password,d.Dept_Name FROM Teachers t
		INNER JOIN Departments d
		ON t.Dept_No = d.Dept_No
		WHERE d.Dept_No LIKE '%'+@Dept_No+'%';
	END


CREATE PROCEDURE add_course
(
	@Course_ID nvarchar(10),
	@Course_Name nvarchar(50),
	@Credit_Hours decimal(5,1),
	@Prerequisite nvarchar(10),
	@Teacher_ID nvarchar(50)
)
AS
	BEGIN
		INSERT INTO [dbo].[Courses]
           (Course_ID,Course_Name,Credit_Hours,Prerequisite,Teacher_ID)
	     VALUES
           (@Course_ID,@Course_Name,@Credit_Hours,@Prerequisite,@Teacher_ID)
	END


CREATE VIEW Course_Table
AS
	SELECT c.Course_ID,c.Course_Name,c.Credit_Hours,d.Course_Name AS 'Prerequisite',t.Name AS 'Teacher' FROM Courses c
	LEFT JOIN Courses d
	ON c.Prerequisite = d.Course_ID
	INNER JOIN Teachers t
	ON c.Teacher_ID = t.Teacher_ID


CREATE PROCEDURE search_course
(
	@ID nvarchar(50)
)
AS
	BEGIN
		SELECT c.Course_ID,c.Course_Name,c.Credit_Hours,d.Course_Name AS 'Prerequisite',t.Name AS 'Teacher' FROM Courses c
		LEFT JOIN Courses d
		ON c.Prerequisite = d.Course_ID
		INNER JOIN Teachers t
		ON c.Teacher_ID = t.Teacher_ID
		WHERE c.Course_ID like '%'+@ID+'%'
	END


CREATE PROCEDURE update_course
(
	@Course_ID nvarchar(10),
	@Course_Name nvarchar(50),
	@Credit_Hours decimal(5,1),
	@Prerequisite nvarchar(10),
	@Teacher_ID nvarchar(50)
)
AS
	BEGIN
		UPDATE Courses
		SET Course_Name = @Course_Name,
			Credit_Hours = @Credit_Hours,
			Prerequisite = @Prerequisite,
			Teacher_ID = @Teacher_ID
		 WHERE Course_ID = @Course_ID
	END


CREATE PROCEDURE update_admin
(
	@Admin_ID nvarchar(50),
	@Name nvarchar(50),
	@Email nvarchar(70),
	@PhoneNo nvarchar(20),
	@Password nvarchar(20)
)
AS
	BEGIN
		UPDATE Admin
		SET Name = @Name,
			Email = @Email,
			PhoneNo = @PhoneNo,
			Password = @Password
		WHERE Admin_ID = @Admin_ID
	END


CREATE PROCEDURE add_admin
(
	@Admin_ID nvarchar(50),
	@Name nvarchar(50),
	@Gender varchar(10),
	@Email nvarchar(70),
	@PhoneNo nvarchar(20),
	@Password nvarchar(20)
)
AS
	BEGIN
		INSERT INTO [dbo].[Admin]
           (Admin_ID,Name,Gender,Email,PhoneNo,Password)
	     VALUES
           (@Admin_ID,@Name,@Gender,@Email,@PhoneNo,@Password)
	END


CREATE PROCEDURE add_notice
(
	@Notice nvarchar(400),
	@Notice_For varchar(20)
)
AS
	BEGIN
		INSERT INTO [dbo].[Notices]
           (Notice,Notice_For)
	     VALUES
           (@Notice,@Notice_For)
	END

CREATE VIEW Reg_Course
AS
	SELECT Course_ID AS 'ID',Course_Name AS 'Name',Credit_Hours AS 'Cr.',Prerequisite AS 'Pre_Req' FROM Courses


CREATE PROCEDURE enroll_student
(
	@Course_ID nvarchar(10),
	@Student_ID nvarchar(50),
	@Reg_Date date,
	@Semester nvarchar(15)
)
AS
	BEGIN
		INSERT INTO [dbo].[Enrolled]
		(Course_ID,Student_ID,Reg_Date,Attendence,Grade,Semester)
     VALUES
           (@Course_ID,@Student_ID,@Reg_Date,'99','I',@Semester)
	END


CREATE VIEW Register_Course
AS
	SELECT e.Course_ID AS 'ID',c.Course_Name AS 'Name',e.Student_ID,e.Semester FROM Enrolled e
	INNER JOIN Courses c
	on e.Course_ID = c.Course_ID


CREATE VIEW Course_Registered
AS
	SELECT e.Student_ID as 'St_ID',e.Course_ID AS 'ID',c.Course_Name AS 'Name',e.Attendence,e.Grade,t.Name AS 'Teacher',e.Semester FROM Enrolled e
	INNER JOIN Courses c
	ON e.Course_ID = c.Course_ID
	INNER JOIN Teachers t
	ON c.Teacher_ID = t.Teacher_ID


CREATE VIEW Notice_Record
AS
	SELECT Notice,Notice_For FROM Notices


CREATE VIEW Student_Announcement
AS
	SELECT e.Student_ID,e.Course_ID AS 'Course', a.Announcement FROM Enrolled e
	INNER JOIN Announcements a
	ON e.Course_ID = a.Course_ID


CREATE VIEW Teacher_Announce
AS
	SELECT Ann_No AS 'ID',Announcement,Course_ID AS 'Course',Teacher_ID FROM Announcements


CREATE VIEW Teacher_Course
AS
	SELECT t.Teacher_ID,c.Course_ID AS 'ID',c.Course_Name AS 'Course' FROM Teachers t
	INNER JOIN Courses c
	ON t.Teacher_ID= c.Teacher_ID


CREATE PROCEDURE add_announcement
(	@Announcement nvarchar(300),
	@Teacher_ID nvarchar(50),
	@Course_ID nvarchar(10)
)
AS
	BEGIN
	INSERT INTO [dbo].[Announcements]
           (Announcement,Teacher_ID,Course_ID)
     VALUES
           (@Announcement,@Teacher_ID,@Course_ID)
	END


CREATE VIEW Techer_Assigned_Course
AS
	SELECT t.Teacher_ID,c.Course_ID AS 'ID',c.Course_Name AS 'COURSE',c.Credit_Hours AS 'Cr_Hour' FROM Teachers t
	INNER JOIN Courses c
	ON t.Teacher_ID = c.Teacher_ID


CREATE VIEW Course_Students
AS
	SELECT c.Course_ID,e.Student_ID AS 'ID',s.Name,s.Email,e.Attendence,e.Grade,e.Semester FROM Courses c
	INNER JOIN Enrolled e
	on c.Course_ID = e.Course_ID
	INNER JOIN Students s
	ON e.Student_ID = s.Student_ID


CREATE TRIGGER count_reg
ON Enrolled
AFTER INSERT
AS
	BEGIN
		IF(SELECT count(Student_ID) FROM Enrolled WHERE Student_ID = (SELECT Student_ID FROM inserted) AND Semester = (SELECT Semester FROM inserted)) >5
		BEGIN
			ROLLBACK
		END
		IF(SELECT count(Course_ID) FROM Enrolled WHERE Course_ID = (select Course_ID from inserted) AND Student_ID = (SELECT Student_ID FROM inserted) AND Semester = (SELECT Semester FROM inserted)) > 1
		BEGIN
			ROLLBACK
		END
	END


CREATE TRIGGER count_course
ON Courses
AFTER INSERT,UPDATE
AS
	BEGIN
		IF (SELECT count(Course_ID) FROM Courses WHERE Teacher_ID = (SELECT Teacher_ID FROM inserted)) >2
		BEGIN
			ROLLBACK
		END
	END


---------------------------------------------------------------

INSERT INTO Admin (Admin_ID,Name,Gender,Email,PhoneNo,Password)
VALUES
('admin','Admin','Male','admin@email.com','0300 1234567','123')

SELECT * FROM Admin


INSERT INTO Departments (Dept_No,Dept_Name,Dept_Block) VALUES
(10,'SOFTWARE ENGINEERING','A'),
(20,'COMPUTER SCIENCE','A'),
(30,'MANAGEMENT SCIENCES','B'),
(40,'PSYCHOLOGY','B'),
(50,'ECONOMICS','B'),
(60,'BIOSCIENCES','C')

SELECT * FROM Departments


INSERT INTO Teachers (Teacher_ID,Name,Gender,Email,PhoneNo,Password,Dept_No) VALUES
('arsalan','Arsalan Warsi','Male','arsalan@mail.com','0300 7654321','123',10),
('owais','Owais Ali','Male','owais@mail.com','0312 3213211','123',20),
('faizan','Faizan Warsi','Male','faizan@mail.com','0333 7657657','123',10),
('hassan','Hassan Warsi','Male','hassan@mail.com','0307 5432156','123',30),
('naseer','Naseer Ahmad','Male','naseer@mail.com','0331 0990990','123',40),
('imran','Muhammad Imran ','Male','imran@mail.com','0311 1984629','123',50),
('siraj','Muhammad Siraj','Male','siraj@mail.com','0345 6893156','123',60),
('sadia','Sadia Mirza','Female','sadia@mail.com','0333 3471245','123',10),
('khan','Ayesha Khan','Female','khan@mail.com','0311 7612942','123',10),
('zubair','Zubair Rao','Male','raozubair@mail.com','0300 0011001','123',10)

SELECT * FROM Teachers


INSERT INTO Courses VALUES ('-','-','0',NULL,'zubair')
INSERT INTO Courses VALUES ('CS1210','Introduction to Computing','3','-','owais')
INSERT INTO Courses VALUES ('CS1211','Introduction to Computing Lab','1','-','sadia')
INSERT INTO Courses VALUES ('CS1410','Computer Programming','3','-','zubair')
INSERT INTO Courses VALUES ('CS1411','Computer Programming Lab','1','-','sadia')
INSERT INTO Courses VALUES ('SE1420','Object Oriented Programming','3','CS1410','arsalan')
INSERT INTO Courses VALUES ('SE1421','Object Oriented Programming','1','CS1411','khan')
INSERT INTO Courses VALUES ('CS2230','Database Management Systems','3','SE1420','owais')
INSERT INTO Courses VALUES ('CS2231','Database Management Systems Lab','1','SE1421','khan')
INSERT INTO Courses VALUES ('SS1100','Freshman English','3','-','naseer')
INSERT INTO Courses VALUES ('BS1020','Cell Biology','3','-','siraj')
INSERT INTO Courses VALUES ('EC1000','Microeconomics','3','-','naseer')
INSERT INTO Courses VALUES ('MT1500','Business Mathematics','3','-','hassan')
INSERT INTO Courses VALUES ('MG1100','Principles of Management','3','-','hassan')

SELECT * FROM Courses


INSERT INTO Students (Name,Student_ID,Gender,Email,PhoneNo,Program,Password) VALUES
('Muhammad Hassan Warsi','SP19-BSSE-1034','Male','hassanwarsi@gmail.com','0300 2011001','BSSE','123'),
('Muhammad Faizan Warsi','SP19-BSSE-1130','Male','faizanwarsi29@mail.com','0344 3451237','BSSE','123'),
('Owais Ali','FA17-BSCS-0041','Male','owaisali27@icloud.com','0334 0000003','BSCS','123'),
('Hamza Taimoor','FA17-BBAH-0056','Male','hamzataimoor@hotmail.com','0345 0000004','BBA','123'),          
('Anum Khan','SP16-BBAH-0056','Female','khan_anum1@gmail.com','0334 0002348','BBA','123'),
('Mirza Talha Baig','FA17-BSCS-0001','Male','mirzatalhabaig@yahoo.com','0334 0034872','BSCS','123'),
('Umar Asghar','SP20-BEME-0045','Male','umarasghar111@gmai.com','0333 0234542 ','BEME','123'),
('Nabeel Qaiser','SP19-BSSE-0005','Male','nabeel123qaiser@gmail.com','0302 1234567','BSCS','123'),
('Irfan Afzal','FA16-BSBS-0101','Male','irfanafzal@hotmail.com','0300 9871234','BSBS','123'),
('Aliza Khan','FA16-BSCE-0010','Female','aliza_khan@yahoo.com','0312 4562953','BSEC','123'),
('Muhammad Irfan','SP20-BSPS-0001','Male','muhammadarfan33@yahoo.com','0311 3632851','BSPS','123'),
('Muhammad Ashraf','SP18-BSPS-1211','Male','muhammadashraf@yahoo.com','0303 6319432','BSPS','123'),
('Ahmad Hasan','FA18-BEME-0241','Male','ahmadhasan45@gmail.com','0332 4611263','BEME','123'),
('Muhammad Usman','SP18-BBAH-0076','Male','muhammadusman_@gmail.com','0307 3451234','BBA','123'),
('Sufyan Ali','FA16-BSBS-0001','Male','sufyanaliali55@hotmail.com','0300 9876543','BSBS','123'),
('Iqra Ghafoor','SP17-BEME-0012','Female','iqraghafoor22@yahoo.com','0345 2491262','BEME','123'),
('Muhammad Ashfad','FA17-BSSE-0721','Male','muhammadashfar34@gmail.com','0344 2344322','BSSE','123'),
('Saleem Raza','SP17-BEME-1203','Male','Ali-Raza@hotmail.com','0310 2391843','BEME','123'),
('Furqan Jatoi','FA16-BSBS-0031','Male','jatoi00@gmail.com','0331 0202005','BSBS','123'),
('Naeem Farooq','FA17-BSBS-0023','Male','naeem@hotmail.com','0301 1257249','BSBS','123'),
('Zainab Ali khan','SP19-BSES-0031','Female','zanab@hotmail.com','0300 4563728','BSEC','123'),
('Muzammil Qureshi','FA20-BSCS-0002','Male','mujji2gmail.com','0345 1233211','BSCS','123'),
('Anaya Malik','FA19-BBAH-0010','Female','malikanaya99@gmail.com','0311 0243542','BBA','123')

SELECT * FROM Students


INSERT INTO Enrolled  VALUES ('CS1210','SP19-BSSE-1130','01/06/2021','80','A','SPRING 2021')
INSERT INTO Enrolled  VALUES ('CS1210','SP17-BEME-0012','01/06/2021','70','B','SPRING 2021')
INSERT INTO Enrolled  VALUES ('CS1210','FA17-BSBS-0023','01/06/2021','88','C','SPRING 2021')
INSERT INTO Enrolled  VALUES ('CS1210','FA17-BBAH-0056','01/06/2021','99','D','SPRING 2021')
INSERT INTO Enrolled  VALUES ('CS1210','SP19-BSSE-1034','01/06/2021','100','D','SPRING 2021')
INSERT INTO Enrolled  VALUES ('CS1211','SP17-BEME-0012','01/06/2021','50','F','SPRING 2021')
INSERT INTO Enrolled  VALUES ('CS1211','FA17-BSBS-0023','01/06/2021','60','I','SPRING 2021')
INSERT INTO Enrolled  VALUES ('CS1211','FA17-BBAH-0056','01/06/2021','66','I','SPRING 2021')
INSERT INTO Enrolled  VALUES ('SE1420','FA17-BSBS-0023','01/06/2021','77','F','SPRING 2021')
INSERT INTO Enrolled  VALUES ('SE1420','SP19-BSES-0031','01/06/2021','89','A','SPRING 2021')
INSERT INTO Enrolled  VALUES ('SE1420','FA20-BSCS-0002','01/06/2021','95','A','SPRING 2021')
INSERT INTO Enrolled  VALUES ('SE1420','FA17-BSSE-0721','01/06/2021','45','B','SPRING 2021')
INSERT INTO Enrolled  VALUES ('SE1420','SP17-BEME-0012','01/06/2021','76','B','SPRING 2021')
INSERT INTO Enrolled  VALUES ('MG1100','SP19-BSSE-1130','01/06/2021','99','C','SPRING 2021')
INSERT INTO Enrolled  VALUES ('MG1100','SP19-BSES-0031','01/06/2021','100','C','SPRING 2021')
INSERT INTO Enrolled  VALUES ('MT1500','FA16-BSBS-0001','01/06/2021','93','D','SPRING 2021')
INSERT INTO Enrolled  VALUES ('MT1500','SP19-BSES-0031','01/06/2021','69','C','SPRING 2021')
INSERT INTO Enrolled  VALUES ('EC1000','FA17-BSSE-0721','01/06/2021','81','A','SPRING 2021')
INSERT INTO Enrolled  VALUES ('EC1000','SP19-BSES-0031','01/06/2021','86','B','SPRING 2021')
INSERT INTO Enrolled  VALUES ('SS1100','SP19-BSSE-1130','01/06/2021','50','A','SPRING 2021')
INSERT INTO Enrolled  VALUES ('CS2230','SP17-BEME-0012','01/06/2021','100','B','SPRING 2021')
INSERT INTO Enrolled  VALUES ('CS2230','SP19-BSSE-1034','01/06/2021','99','A','SPRING 2021')
INSERT INTO Enrolled  VALUES ('CS2231','SP19-BSSE-1034','01/06/2021','85','C','SPRING 2021')
INSERT INTO Enrolled  VALUES ('CS2231','SP19-BSSE-1130','01/06/2021','70','I','SPRING 2021')
INSERT INTO Enrolled  VALUES ('SE1420','SP19-BSES-0031','01/06/2021','88','D','SPRING 2021')
INSERT INTO Enrolled  VALUES ('SE1420','SP19-BSSE-1034','01/06/2021','64','A','SPRING 2021')
INSERT INTO Enrolled  VALUES ('SE1420','SP19-BSSE-1130','01/06/2021','71','I','SPRING 2021')
INSERT INTO Enrolled  VALUES ('MT1500','SP19-BSSE-1130','01/06/2021','93','A','SPRING 2021')

SELECT * FROM Enrolled