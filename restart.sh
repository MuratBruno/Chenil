#!/bin/sh
docker-compose stop
docker-compose down
docker-compose build
docker-compose up
read -p "Installation terminée consulter le site sur http://localhost:4202"