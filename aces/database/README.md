**ACES_DB.bak** - This backup file contains all of the databases schema and data. It is referenced in restore.sql

**Dockerfile** - This files orchestrates all the magic done by “docker-compose”

**restore.sql** - This is run by the Cockerfile to restore from ACES_DB.bak in our database docker container

**Restore_ACES_DB.sql** - This contains all the scripts necessary to create and seed the database in case the current backup technique with Docker stops working