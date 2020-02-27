class Database{
	constructor(){
		this.mysql = require('mysql');
	}

	getFromDB(sql){
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


	getCoursesFromDB(sql){
		// Add the credentials to access your database
		this.connection = this.mysql.createConnection({
			host     : 'localhost',
			user     : 'admin',
			password : 'ACES2.0password', // or the original password : 'apaswword'
			database : 'ACES'
		});

		this.connection.connect();
		var results, x = "";
		this.connection.query(sql, function (error, results, fields) {
		  if (error) throw error;
		  console.log(results);
			var txt = "<table><tr><th>ID</th><th>Department</th><th>Course Number</th>";
	    txt += "<th>Course Name</th><th>Creation Date</th></tr>"

	    for (x in results){
				console.log(results[x]);
	      txt += "<tr><td>" + results[x].courseID + "</td> <td>" + results[x].department + "</td> <td>" + results[x].courseNum + "</td> <td>" + results[x].courseName + "</td> <td>" + results[x].creationDate + "</td></tr>";
	    }
	    txt += "</table>";
	    document.getElementById("id02").innerHTML = txt;
		  //$('#resultDiv').text(results[0].username);
		});

		this.connection.end();
	}

	getStudentsFromDB(sql){
		// Add the credentials to access your database
		this.connection = this.mysql.createConnection({
			host     : 'localhost',
			user     : 'admin',
			password : 'ACES2.0password', // or the original password : 'apaswword'
			database : 'ACES'
		});

		this.connection.connect();
		var results, x = "";
		this.connection.query(sql, function (error, results, fields) {
			if (error) throw error;
			console.log(results);
			var txt = "<table><tr><th>ID</th><th>Github Username</th><th>First Name</th>";
			txt += "<th>Last Name</th><th>Creation Date</th></tr>"

			for (x in results){
				console.log(results[x]);
				txt += "<tr><td>" + results[x].studentID + "</td> <td>" + results[x].ghUsername + "</td> <td>" + results[x].firstName + "</td> <td>" + results[x].lastName + "</td> <td>" + results[x].creationDate + "</td></tr>";
			}
			txt += "</table>";
			document.getElementById("id02").innerHTML = txt;
			//$('#resultDiv').text(results[0].username);
		});

		this.connection.end();
	}

	getSectionsFromDB(sql){
		// Add the credentials to access your database
		this.connection = this.mysql.createConnection({
			host     : 'localhost',
			user     : 'admin',
			password : 'ACES2.0password', // or the original password : 'apaswword'
			database : 'ACES'
		});

		this.connection.connect();
		var results, x = "";
		this.connection.query(sql, function (error, results, fields) {
			if (error) throw error;
			console.log(results);
			var txt = "<table><tr><th>Section ID</th><th>Course ID</th></tr>";

			for (x in results){
				console.log(results[x]);
				txt += "<tr><td>" + results[x].sectionID + "</td> <td>" + results[x].sectionCourseID + "</td></tr>";
			}
			txt += "</table>";
			document.getElementById("id02").innerHTML = txt;
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

	addSection(sectionCourseID){
			var sql = 'INSERT INTO sections (sectionCourseID) VALUES ("' + sectionCourseID +'");';

			this.getFromDB(sql);
	}

	addAssignment(assignmentSectionID, assignmentStudentID){
			var sql = 'INSERT INTO assignments (assignmentSectionID, assignmentStudentID) VALUES ("' + assignmentSectionID + '", "' + assignmentStudentID +'");';

			this.getFromDB(sql);
	}

//MySQL View classes

viewStudents(){
	var sql = 'SELECT * FROM students'

	result = this.getStudentsFromDB(sql);
	return result;
}

viewCourses(){
	var sql = 'SELECT * FROM courses'

	var result = this.getCoursesFromDB(sql);
	return result;
}

viewSections(){
	var sql = 'SELECT * FROM sections'

	result = this.getSectionsFromDB(sql);
	return result;
}

viewAssignments(){
	var sql = 'SELECT * FROM assignments'

	this.getFromDB(sql);
}

}
