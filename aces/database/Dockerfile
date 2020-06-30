FROM microsoft/mssql-server-linux

ENV SA_PASSWORD=mySecurepass1979**
ENV ACCEPT_EULA=Y

COPY ./ACES_DB.bak /var/opt/mssql/backup/ACES_DB.bak
RUN /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P mySecurepass1979** -Q "RESTORE DATABASE ACES_DB FROM DISK='/var/opt/mssql/backup/ACES_DB.bak' WITH MOVE 'ACES_TEST' TO '/var/opt/mssql/data/ACES_TEST.mdf', MOVE 'ACES_TEST_log' TO '/var/opt/mssql/data/ACES_TEST_log.ldf'"