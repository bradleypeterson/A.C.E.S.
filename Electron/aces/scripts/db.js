class Database{
	constructor(){
		this.mysql = require('mysql');
	}

	getFromDB(sql){
		// Add the credentials to access your database
		this.connection = this.mysql.createConnection({
			host     : 'localhost',
			user     : 'admin',
			password : 'ACES2.0password', // or the original password : 'apaswword'
			database : 'ACES'
		});

		this.connection.connect();

		this.connection.query(sql, function (error, results, fields) {
		  if (error) throw error;
		  console.log(results);
		  //$('#resultDiv').text(results[0].username);
		});

		this.connection.end();
	}

//MySQL add classes
	addCourse(name, num, department){
			var date = new Date();
			//Convert date to MySQL format
			date = date.getUTCFullYear() + '-' +
				('00' + (date.getUTCMonth()+1)).slice(-2) + '-' +
				('00' + date.getUTCDate()).slice(-2) + ' ' +
				('00' + date.getUTCHours()).slice(-2) + ':' +
				('00' + date.getUTCMinutes()).slice(-2) + ':' +
				('00' + date.getUTCSeconds()).slice(-2);

			var sql = 'INSERT INTO courses (courseName, courseNum, department, creationDate) VALUES ("' + name + '", "' + num + '", "' + department + '", "' + date + '");';


			this.getFromDB(sql);
	}

	addStudent(firstName, lastName, ghUsername){
			var date = new Date();
			//Convert date to MySQL format
			date = date.getUTCFullYear() + '-' +
				('00' + (date.getUTCMonth()+1)).slice(-2) + '-' +
				('00' + date.getUTCDate()).slice(-2) + ' ' +
				('00' + date.getUTCHours()).slice(-2) + ':' +
				('00' + date.getUTCMinutes()).slice(-2) + ':' +
				('00' + date.getUTCSeconds()).slice(-2);

			var sql = 'INSERT INTO students (ghUsername, firstName, lastName, creationDate) VALUES ("' + ghUsername + '", "' + firstName + '", "' + lastName + '", "' + date + '");';

			this.getFromDB(sql);
	}

	addSection(instructorID, sectionCourseID){
			var sql = 'INSERT INTO sections (instructorID, sectionCourseID) VALUES ("' + instructorID + '", "' + sectionCourseID +'");';

			this.getFromDB(sql);
	}

	addAssignment(assignmentSectionID, assignmentStudentID){
			var sql = 'INSERT INTO assignments (assignmentSectionID, assignmentStudentID) VALUES ("' + assignmentSectionID + '", "' + assignmentStudentID +'");';

			this.getFromDB(sql);
	}

//MySQL View classes

viewStudents(){
	var sql = 'SELECT * FROM students'

	this.getFromDB(sql);
}

viewCourses(){
	var sql = 'SELECT * FROM courses'

	this.getFromDB(sql);
}

viewSections(){
	var sql = 'SELECT * FROM sections'

	this.getFromDB(sql);
}

viewAssignments(){
	var sql = 'SELECT * FROM assignments'

	this.getFromDB(sql);
}

}
