FROM microsoft/mssql-server-linux

ENV MSSQL_SA_PASSWORD=mySecurepass1979**
ENV ACCEPT_EULA=Y

COPY ./ACES_DB.bak /var/opt/mssql/backup/ACES_DB.bak
COPY restore.sql restore.sql
RUN (/opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Service Broker manager has started" && /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P 'mySecurepass1979**' -d master -i restore.sql