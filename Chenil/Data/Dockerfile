FROM mcr.microsoft.com/mssql/server
COPY . .
EXPOSE 1435:1433
#Application de la migration
ENTRYPOINT ["Chenil/Data/entrypoint.sh" ]

#Lancement de sql server
CMD [ "/opt/mssql/bin/sqlservr" ]