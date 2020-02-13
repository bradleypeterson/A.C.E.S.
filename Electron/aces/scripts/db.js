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
	
    addClass(){
		var sql = 'SELECT `username`, `password`, `creationDate` FROM `users`';
		
		this.getFromDB(sql);
    }
}