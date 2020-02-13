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
	
    addCourse(name, num, department){
		var date = new Date();
		date = date.getUTCFullYear() + '-' +
			('00' + (date.getUTCMonth()+1)).slice(-2) + '-' +
			('00' + date.getUTCDate()).slice(-2) + ' ' + 
			('00' + date.getUTCHours()).slice(-2) + ':' + 
			('00' + date.getUTCMinutes()).slice(-2) + ':' + 
			('00' + date.getUTCSeconds()).slice(-2);
			
		var sql = 'INSERT INTO courses (courseName, courseNum, department, creationDate) VALUES ("' + name + '", "' + num + '", "' + department + '", "' + date + '");';
		
		this.getFromDB(sql);
    }
}