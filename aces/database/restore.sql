RESTORE DATABASE ACES_DB 
FROM DISK='/var/opt/mssql/backup/ACES_DB.bak' 
WITH MOVE 'ACES_TEST' TO '/var/opt/mssql/data/ACES_TEST.mdf', 
MOVE 'ACES_TEST_log' TO '/var/opt/mssql/data/ACES_TEST_log.ldf'