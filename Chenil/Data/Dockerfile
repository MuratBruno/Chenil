FROM mcr.microsoft.com/mssql/server
COPY . .
EXPOSE 1435:1433
#ENTRYPOINT ["Chenil/Data/entrypoint.sh" ]
CMD [ "/opt/mssql/bin/sqlservr" ]